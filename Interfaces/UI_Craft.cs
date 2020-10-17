using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bot_Dofus_1._29._1.Otros;
using Bot_Dofus_1._29._1.Otros.Mapas;
using Bot_Dofus_1._29._1.Otros.Mapas.Entidades;
using Bot_Dofus_1._29._1.Otros.Game.Entidades.Manejadores.Movimientos;
using Bot_Dofus_1._29._1.Otros.Game.Character.Inventory;

namespace Bot_Dofus_1._29._1.Interfaces
{
    public partial class UI_Craft : UserControl
    {
        private Account cuenta;
        private InventoryObject current_rune = null;
        bool automatic = false;


        public UI_Craft(Account _cuenta)
        {
            InitializeComponent();
            cuenta = _cuenta;
        }

        private void openTool_Click(object sender, EventArgs e)
        {
            Map mapa = cuenta.game.map;

            /* BONTA
            short workshop_cell_id = 266;
            // Cell tool_cell = cuenta.game.map.GetCellFromId(workshop_cell_id);
            Cell workshop_cell = cuenta.game.map.GetCellFromId(281);
            //*/

            //* BRAKMAR
            short workshop_cell_id = 357;
            // Cell tool_cell = cuenta.game.map.GetCellFromId(workshop_cell_id);
            Cell workshop_cell = cuenta.game.map.GetCellFromId(342);
            //*/

            //* AMULETTE
            short action = 169;
            //*/
            /* ANNEAU
            short action = 168;
            //*/

            switch (cuenta.game.manager.movimientos.get_Mover_A_Celda(workshop_cell, new List<Cell>()))
            {
                case ResultadoMovimientos.EXITO:
                    cuenta.Logger.LogInfo("UI_CRAFT", "En route vers l'atelier");
                    break;

                case ResultadoMovimientos.SameCell:
                case ResultadoMovimientos.FALLO:
                case ResultadoMovimientos.PathfindingError:
                    cuenta.Logger.LogError("UI_CRAFT", "Impossible de se deplacer a l'atelier");
                    break;
            }

            string open_workshop_packet = "GA500" + workshop_cell_id + ";" + action;

            cuenta.connexion.SendPacket(open_workshop_packet, true);

        }

        private void add_item_Click(object sender, EventArgs e)
        {
            InventoryObject amulet_de_bouftou = cuenta.game.character.inventario.get_Objeto_Modelo_Id(2425);
            uint inv_id = amulet_de_bouftou.id_inventario;
            string add_object_packet = "EMO+" + inv_id + "|1";
            cuenta.connexion.SendPacket(add_object_packet, true);
        }

        private void add_rune_Click(object sender, EventArgs e)
        {
            current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
            uint rune_inv_id = current_rune.id_inventario;
            int quantity = current_rune.cantidad;
            string add_object_packet = "EMO+" + rune_inv_id + "|" + quantity;
            cuenta.connexion.SendPacket(add_object_packet, true);
        }

        private void craft_Click(object sender, EventArgs e)
        {
            string craft_packet = "EK";
            cuenta.connexion.SendPacket(craft_packet, true);
        }

        private void closeWorkshop_Click(object sender, EventArgs e)
        {
            string close_ws_packet = "EV";
            cuenta.connexion.SendPacket(close_ws_packet, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current_rune == null)
                return;
            uint rune_inv_id = current_rune.id_inventario;
            int quantity = current_rune.cantidad;
            string add_object_packet = "EMO-" + rune_inv_id + "|" + quantity;
            cuenta.connexion.SendPacket(add_object_packet, true);
        }

        private void add_in_rune_Click(object sender, EventArgs e)
        {
            current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1522);
            uint rune_inv_id = current_rune.id_inventario;
            int quantity = current_rune.cantidad;
            string add_object_packet = "EMO+" + rune_inv_id + "|" + quantity;
            cuenta.connexion.SendPacket(add_object_packet, true);
        }

        private async void automate_Craft_ClickAsync(object sender, EventArgs e)
        {
            // add item
            InventoryObject anneau_bwork = cuenta.game.character.inventario.get_Objeto_Modelo_Id(6805);
            cuenta.game.character.fm_object = anneau_bwork;
            uint inv_id = anneau_bwork.id_inventario;
            string add_object_packet = "EMO+" + inv_id + "|1";
            cuenta.connexion.SendPacket(add_object_packet, true);
            await Task.Delay(800);

            automatic = true;

            // add runes
            current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
            uint rune_inv_id = current_rune.id_inventario;
            int quantity = current_rune.cantidad;
            string add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
            cuenta.connexion.SendPacket(add_rune_packet, true);
            await Task.Delay(800);

            while (automatic)
            {
                await Task.Delay(800);
                // craft
                string craft_packet = "EK";
                cuenta.connexion.SendPacket(craft_packet, true);
                await Task.Delay(800);

                // parse stats
                stats item_stats = parse_stats(cuenta.game.character.fm_object.stats);
                int force = item_stats.force;
                int intel = item_stats.intelligence;
                int agil = item_stats.agilite;
                int sag = item_stats.sagesse;
                int vita = item_stats.vitalite;

                // remove current rune
                // tr = to remove
                uint rune_inv_id_tr = current_rune.id_inventario;
                int quantity_tr = current_rune.cantidad;
                string add_object_packet_tr = "EMO-" + rune_inv_id_tr + "|" + quantity_tr;
                cuenta.connexion.SendPacket(add_object_packet_tr, true);
                await Task.Delay(800);

                // set current rune to minimum stat
                if (agil < force)
                {
                    if (agil < vita) // agi are most expensive so only take when the smallest
                    {
                        // add age runes
                        current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1524);
                    }
                    else
                    {
                        // add vi runes
                        current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1523);
                    }
                }
                else
                {
                    if (force <= vita) // if equal still take fo runes cause it's cheaper
                    {
                        // add fo runes
                        current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
                    }
                    else
                    {
                        // add vi runes
                        current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1523);
                    }
                }

                // put smallest rune (current)
                rune_inv_id = current_rune.id_inventario;
                quantity = current_rune.cantidad;
                add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
                cuenta.connexion.SendPacket(add_rune_packet, true);
                await Task.Delay(800);
            }
            string close_ws_packet = "EV";
            cuenta.connexion.SendPacket(close_ws_packet, true);
        }

        private void stop_auto_Click(object sender, EventArgs e)
        {
            automatic = false;
        }

        struct stats
        {
            public int force;
            public int intelligence;
            public int agilite;
            public int vitalite;
            public int sagesse;
            public int chance;
        }

        private stats parse_stats(string stat_packet)
        {
            stats item_stats;
            item_stats.force = 0;
            item_stats.intelligence = 0;
            item_stats.agilite = 0;
            item_stats.vitalite = 0;
            item_stats.sagesse = 0;
            item_stats.chance = 0;
            // 76#9#0#0#0d0+9,7e#9#0#0#0d0+9
            string[] stats = stat_packet.Split(',');
            foreach (string s in stats)
            {
                string type = s.Split('#')[0];
                if (type == "76")
                    item_stats.force = int.Parse(s.Split('+')[1]);
                if (type == "77")
                    item_stats.agilite = int.Parse(s.Split('+')[1]);
                else if (type == "7e")
                    item_stats.intelligence = int.Parse(s.Split('+')[1]);
                else if (type == "7d")
                    item_stats.vitalite = int.Parse(s.Split('+')[1]);
                else if (type == "7c")
                    item_stats.sagesse = int.Parse(s.Split('+')[1]);
                else if (type == "7b")
                    item_stats.chance = int.Parse(s.Split('+')[1]);
            }
            return item_stats;
        }

        private void fm_anneau_Click(object sender, EventArgs e)
        {
            Map mapa = cuenta.game.map;

            /* BONTA
            short workshop_cell_id = 266;
            // Cell tool_cell = cuenta.game.map.GetCellFromId(workshop_cell_id);
            Cell workshop_cell = cuenta.game.map.GetCellFromId(281);
            //*/

            //* BRAKMAR
            short workshop_cell_id = 357;
            // Cell tool_cell = cuenta.game.map.GetCellFromId(workshop_cell_id);
            Cell workshop_cell = cuenta.game.map.GetCellFromId(342);
            //*/

            /* AMULETTE
            short action = 169;
            //*/
            //* ANNEAU
            short action = 168;
            //*/

            switch (cuenta.game.manager.movimientos.get_Mover_A_Celda(workshop_cell, new List<Cell>()))
            {
                case ResultadoMovimientos.EXITO:
                    cuenta.Logger.LogInfo("UI_CRAFT", "En route vers l'atelier");
                    break;

                case ResultadoMovimientos.SameCell:
                case ResultadoMovimientos.FALLO:
                case ResultadoMovimientos.PathfindingError:
                    cuenta.Logger.LogError("UI_CRAFT", "Impossible de se deplacer a l'atelier");
                    break;
            }

            string open_workshop_packet = "GA500" + workshop_cell_id + ";" + action;

            cuenta.connexion.SendPacket(open_workshop_packet, true);
        }

        private async void auto_fm_amu_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            // add item
            //InventoryObject amulet_de_bouftou = cuenta.game.character.inventario.get_Objeto_Modelo_Id(2425);
            InventoryObject amulet_de_bouftou = cuenta.game.character.inventario.get_Objeto_Modelo_Id(2443);
            cuenta.game.character.fm_object = amulet_de_bouftou;
            uint inv_id = amulet_de_bouftou.id_inventario;
            string add_object_packet = "EMO+" + inv_id + "|1";
            cuenta.connexion.SendPacket(add_object_packet, true);
            await Task.Delay(500);

            automatic = true;

            string rune = "fo";
            // add runes
            current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
            uint rune_inv_id = current_rune.id_inventario;
            int quantity = current_rune.cantidad;
            string add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
            cuenta.connexion.SendPacket(add_rune_packet, true);

            while (automatic)
            {
                await Task.Delay(500);
                // craft
                string craft_packet = "EK";
                cuenta.connexion.SendPacket(craft_packet, true);

                // parse stats
                await Task.Delay(500);
                stats item_stats = parse_stats(cuenta.game.character.fm_object.stats);
                int force = item_stats.force;
                int intel = item_stats.intelligence;
                int agil = item_stats.agilite;
                int sag = item_stats.sagesse;
                int vita = item_stats.vitalite;

                // if reached 10
                if (rune == "fo")
                {
                    if (force > 27)
                    {
                        rune = "in";
                        // tr = to remove
                        uint rune_inv_id_tr = current_rune.id_inventario;
                        int quantity_tr = current_rune.cantidad;
                        string add_object_packet_tr = "EMO-" + rune_inv_id + "|" + quantity;
                        cuenta.connexion.SendPacket(add_object_packet_tr, true);
                        // wait
                        await Task.Delay(500);
                        // add in runes
                        current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1522);
                        rune_inv_id = current_rune.id_inventario;
                        quantity = current_rune.cantidad;
                        add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
                        cuenta.connexion.SendPacket(add_rune_packet, true);
                    }
                }
                else
                {
                    if (intel > 27)
                    {
                        rune = "fo";
                        // tr = to remove
                        uint rune_inv_id_tr = current_rune.id_inventario;
                        int quantity_tr = current_rune.cantidad;
                        string add_object_packet_tr = "EMO-" + rune_inv_id + "|" + quantity;
                        cuenta.connexion.SendPacket(add_object_packet_tr, true);
                        // wait
                        await Task.Delay(500);
                        // add fo runes
                        current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
                        rune_inv_id = current_rune.id_inventario;
                        quantity = current_rune.cantidad;
                        add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
                        cuenta.connexion.SendPacket(add_rune_packet, true);
                    }
                }
                await Task.Delay(500);
            }
            string close_ws_packet = "EV";
            cuenta.connexion.SendPacket(close_ws_packet, true);
        }

        private async void fm_cm_Click(object sender, EventArgs e)
        {
            // add item
            InventoryObject anneau_cm = cuenta.game.character.inventario.get_Objeto_Modelo_Id(8470);
            cuenta.game.character.fm_object = anneau_cm;
            uint inv_id = anneau_cm.id_inventario;
            string add_object_packet = "EMO+" + inv_id + "|1";
            cuenta.connexion.SendPacket(add_object_packet, true);
            await Task.Delay(800);

            automatic = true;

            // add runes
            current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
            uint rune_inv_id = current_rune.id_inventario;
            int quantity = current_rune.cantidad;
            string add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
            cuenta.connexion.SendPacket(add_rune_packet, true);
            await Task.Delay(800);

            while (automatic)
            {
                await Task.Delay(800);
                // craft
                string craft_packet = "EK";
                cuenta.connexion.SendPacket(craft_packet, true);
                await Task.Delay(800);

                // parse stats
                stats item_stats = parse_stats(cuenta.game.character.fm_object.stats);
                int force = item_stats.force;
                int intel = item_stats.intelligence;
                int agil = item_stats.agilite;
                int sag = item_stats.sagesse;
                int vita = item_stats.vitalite;

                // remove current rune
                // tr = to remove
                uint rune_inv_id_tr = current_rune.id_inventario;
                int quantity_tr = current_rune.cantidad;
                string add_object_packet_tr = "EMO-" + rune_inv_id_tr + "|" + quantity_tr;
                cuenta.connexion.SendPacket(add_object_packet_tr, true);
                await Task.Delay(800);

                // set current rune to minimum stat
                if (force < 30)
                {
                    // add fo runes
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
                }
                else if (intel < 25)
                {
                    // add ine runes
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1522);
                }
                else if (sag < 20)
                {
                    // add fo runes
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1521);
                }
                else if (vita < 75)
                {
                    // add vi runes
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1523);
                }
                else
                {
                    // justt add fo runes cause cheapest
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
                }

                // put smallest rune (current)
                rune_inv_id = current_rune.id_inventario;
                quantity = current_rune.cantidad;
                add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
                cuenta.connexion.SendPacket(add_rune_packet, true);
                await Task.Delay(800);
            }
            string close_ws_packet = "EV";
            cuenta.connexion.SendPacket(close_ws_packet, true);
        }

        private void fm_chapeau_Click(object sender, EventArgs e)
        {
            //* BRAKMAR
            short workshop_cell_id = 312;
            // Cell tool_cell = cuenta.game.map.GetCellFromId(workshop_cell_id);
            Cell workshop_cell = cuenta.game.map.GetCellFromId(297);
            //*/

            // coiffe
            short action = 166;
            //sac action = 167
            //cape action = 165

            switch (cuenta.game.manager.movimientos.get_Mover_A_Celda(workshop_cell, new List<Cell>()))
            {
                case ResultadoMovimientos.EXITO:
                    cuenta.Logger.LogInfo("UI_CRAFT", "En route vers l'atelier");
                    break;

                case ResultadoMovimientos.SameCell:
                case ResultadoMovimientos.FALLO:
                case ResultadoMovimientos.PathfindingError:
                    cuenta.Logger.LogError("UI_CRAFT", "Impossible de se deplacer a l'atelier");
                    break;
            }

            string open_workshop_packet = "GA500" + workshop_cell_id + ";" + action;

            cuenta.connexion.SendPacket(open_workshop_packet, true);
        }

        private async void auto_chapeau_Click(object sender, EventArgs e)
        {
            cuenta.game.character.success_rate = 0;
            cuenta.game.character.total_crafts = 0;

            // add item
            //InventoryObject coiffe_bouf = cuenta.game.character.inventario.get_Objeto_Modelo_Id(2411);
            //InventoryObject coiffe_bouf = cuenta.game.character.inventario.get_Objeto_Modelo_Id(2474);
            InventoryObject cape_cb = cuenta.game.character.inventario.get_Objeto_Modelo_Id(6811);
            cuenta.game.character.fm_object = cape_cb;
            uint inv_id = cape_cb.id_inventario;
            string add_object_packet = "EMO+" + inv_id + "|1";
            cuenta.connexion.SendPacket(add_object_packet, true);
            await Task.Delay(800);

            automatic = true;

            // add runes
            current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1525);
            uint rune_inv_id = current_rune.id_inventario;
            int quantity = current_rune.cantidad;
            string add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
            cuenta.connexion.SendPacket(add_rune_packet, true);
            await Task.Delay(800);

            while (automatic)
            {
                await Task.Delay(800);
                // craft
                string craft_packet = "EK";
                cuenta.connexion.SendPacket(craft_packet, true);
                await Task.Delay(800);

                // parse stats
                stats item_stats = parse_stats(cuenta.game.character.fm_object.stats);
                int force = item_stats.force;
                int intel = item_stats.intelligence;
                int agil = item_stats.agilite;
                int sag = item_stats.sagesse;
                int vita = item_stats.vitalite;
                int chance = item_stats.chance;

                // remove current rune
                // tr = to remove
                uint rune_inv_id_tr = current_rune.id_inventario;
                int quantity_tr = current_rune.cantidad;
                string add_object_packet_tr = "EMO-" + rune_inv_id_tr + "|" + quantity_tr;
                cuenta.connexion.SendPacket(add_object_packet_tr, true);
                await Task.Delay(800);

                // set current rune to minimum stat
                /*
                if (force < 35)
                {
                    // add fo runes
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1519);
                }
                else
                {
                    // add ine runes
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1522);
                }
                */
                //*
                if (chance <= agil)
                {
                    // add cha runes
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1525);
                }
                else
                {
                    // add age runes
                    current_rune = cuenta.game.character.inventario.get_Objeto_Modelo_Id(1524);
                }
                //*/
                // put smallest rune (current)
                rune_inv_id = current_rune.id_inventario;
                quantity = current_rune.cantidad;
                add_rune_packet = "EMO+" + rune_inv_id + "|" + quantity;
                cuenta.connexion.SendPacket(add_rune_packet, true);
                await Task.Delay(800);
            }
            string close_ws_packet = "EV";
            cuenta.connexion.SendPacket(close_ws_packet, true);
        }

        private void fm_cape_Click(object sender, EventArgs e)
        {
            //* BRAKMAR
            short workshop_cell_id = 312;
            // Cell tool_cell = cuenta.game.map.GetCellFromId(workshop_cell_id);
            Cell workshop_cell = cuenta.game.map.GetCellFromId(297);
            //*/

            // coiffe
            short action = 165;
            // coiffe action = 166
            //sac action = 167
            //cape action = 165

            switch (cuenta.game.manager.movimientos.get_Mover_A_Celda(workshop_cell, new List<Cell>()))
            {
                case ResultadoMovimientos.EXITO:
                    cuenta.Logger.LogInfo("UI_CRAFT", "En route vers l'atelier");
                    break;

                case ResultadoMovimientos.SameCell:
                case ResultadoMovimientos.FALLO:
                case ResultadoMovimientos.PathfindingError:
                    cuenta.Logger.LogError("UI_CRAFT", "Impossible de se deplacer a l'atelier");
                    break;
            }

            string open_workshop_packet = "GA500" + workshop_cell_id + ";" + action;

            cuenta.connexion.SendPacket(open_workshop_packet, true);
        }

        private void UI_Craft_Load(object sender, EventArgs e)
        {

        }
    }
}
