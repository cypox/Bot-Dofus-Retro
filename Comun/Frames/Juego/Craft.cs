using Bot_Dofus_1._29._1.Comun.Frames.Transporte;
using Bot_Dofus_1._29._1.Comun.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_Dofus_1._29._1.Comun.Frames.Juego
{
    internal class Craft : Frame
    {
        [PaqueteAtributo("EMKO+")]
        public void get_Added_Item(TcpClient cliente, string paquete)
        {
            string[] item = paquete.Substring(5).Split('|');
            int inv_id = int.Parse(item[0]);
            int quantity = int.Parse(item[1]);
            //cliente.account.Logger.LogInfo("CRAFT", "Added item " + inv_id + " with quantity " + quantity + " to workshop");
        }

        [PaqueteAtributo("EmKO+")]
        public void get_Added_Item_After_Craft(TcpClient cliente, string paquete)
        {
            string[] item = paquete.Substring(5).Split('|');
            uint inv_id = uint.Parse(item[0]);
            int quantity = int.Parse(item[1]);
            int template = int.Parse(item[2]);
            string stats = item[3];
            cliente.account.game.character.inventario._objetos[inv_id].stats = stats;
            cliente.account.game.character.fm_object = cliente.account.game.character.inventario._objetos[inv_id];
            cliente.account.Logger.LogInfo("CRAFT", "Added item " + inv_id + " with quantity " + quantity + " of template " + template + " with stats " + stats + " to player");
            cliente.account.Logger.LogInfo("CRAFT", "Crafted " + cliente.account.game.character.success_rate + " from " + cliente.account.game.character.total_crafts + " total crafts");

            double rate = (double)cliente.account.game.character.success_rate / (double)cliente.account.game.character.total_crafts;
            cliente.account.Logger.LogInfo("CRAFT", "Rate : " + Math.Round(rate, 2) * 100 + "%");
        }

        //[PaqueteAtributo("Im0194")]
        [PaqueteAtributo("EcK")]
        public void get_Successful_Craft(TcpClient cliente, string paquete)
        {
            cliente.account.game.character.total_crafts++;
            cliente.account.game.character.success_rate++;
            cliente.account.Logger.LogInfo("CRAFT", "(Critical) Success Craft.");
        }

        /*
        [PaqueteAtributo("Im0183")]
        public void get_Failed_Craft(TcpClient cliente, string paquete)
        {
            cliente.account.game.character.total_crafts++;
            cliente.account.game.character.success_rate++;
            cliente.account.Logger.LogInfo("CRAFT", "Success Craft.");
        }
        */

        //[PaqueteAtributo("Im0117")]
        [PaqueteAtributo("EcEF")]
        public void get_Incorrect_Craft(TcpClient cliente, string paquete)
        {
            cliente.account.game.character.total_crafts++;
            cliente.account.Logger.LogInfo("CRAFT", "Failed or Incorrect Craft.");

            // TODO : add the craft to the client and restart the craft from there when im0117 is intercepted
        }
    }
}
