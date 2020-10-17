﻿using Bot_Dofus_1._29._1.Otros;
using Bot_Dofus_1._29._1.Otros.Game.Character.Spells;
using System;
using System.Reflection;
using System.Windows.Forms;

/*
    Este archivo es parte del proyecto BotDofus_1.29.1

    BotDofus_1.29.1 Copyright (C) 2019 Alvaro Prendes — Todos los derechos reservados.
    Creado por Alvaro Prendes
    web: http://www.salesprendes.com
*/

namespace Bot_Dofus_1._29._1.Interfaces
{
    public partial class UI_Hechizos : UserControl
    {
        private Account cuenta;

        public UI_Hechizos()
        {
            InitializeComponent();
            set_DoubleBuffered(dataGridView_hechizos);
        }

        public void set_Cuenta(Account _cuenta)
        {
            cuenta = _cuenta;
            cuenta.game.character.hechizos_actualizados += actualizar_Agregar_Lista_Hechizos;
        }

        private void actualizar_Agregar_Lista_Hechizos()
        {
            dataGridView_hechizos.BeginInvoke((Action)(() =>
            {
                dataGridView_hechizos.Rows.Clear();

                foreach (Spell spell in cuenta.game.character.hechizos.Values)
                    dataGridView_hechizos.Rows.Add(new object[] { spell.id, spell.nombre, spell.nivel, (spell.nivel == 7 || spell.id == 0 ? "-" : "Subir hechizo") });
            }));
        }

        public static void set_DoubleBuffered(Control control) => typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, control, new object[] { true });
    }
}
