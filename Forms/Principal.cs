﻿using Bot_Dofus_1._29._1.Controles.TabControl;
using Bot_Dofus_1._29._1.Interfaces;
using Bot_Dofus_1._29._1.Otros;
using Bot_Dofus_1._29._1.Otros.Grupos;
using Bot_Dofus_1._29._1.Utilities.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/*
    Este archivo es parte del proyecto BotDofus_1.29.1

    BotDofus_1.29.1 Copyright (C) 2019 Alvaro Prendes — Todos los derechos reservados.
	Creado por Alvaro Prendes
    web: http://www.salesprendes.com
*/

namespace Bot_Dofus_1._29._1.Forms
{
    public partial class Principal : Form
    {
        public static Dictionary<string, Pagina> cuentas_cargadas;

        public Principal()
        {
            InitializeComponent();
            cuentas_cargadas = new Dictionary<string, Pagina>();

            Directory.CreateDirectory("mapas");
            Directory.CreateDirectory("items");
        }

        private void gestionDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GestionCuentas gestion_cuentas = new GestionCuentas())
            {
                if (gestion_cuentas.ShowDialog() == DialogResult.OK)
                {
                    List<AccountConfig> cuentas_para_cargar = gestion_cuentas.get_Cuentas_Cargadas();

                    if (cuentas_para_cargar.Count < 2)
                    {
                        AccountConfig cuenta_conf = cuentas_para_cargar[0];
                        cuentas_cargadas.Add(cuenta_conf.accountUsername, agregar_Nueva_Tab_Pagina(cuenta_conf.accountUsername, new UI_Principal(new Account(cuenta_conf)), "Ninguno"));
                    }
                    else
                    {
                        AccountConfig configuracion_lider = cuentas_para_cargar.First();
                        Account lider = new Account(configuracion_lider);
                        Grupo grupo = new Grupo(lider);
                        cuentas_cargadas.Add(configuracion_lider.accountUsername, agregar_Nueva_Tab_Pagina(configuracion_lider.accountUsername, new UI_Principal(lider), configuracion_lider.accountUsername));
                        cuentas_para_cargar.Remove(configuracion_lider);

                        foreach (AccountConfig cuenta_conf in cuentas_para_cargar)
                        {
                            Account cuenta = new Account(cuenta_conf);

                            grupo.agregar_Miembro(cuenta);
                            cuentas_cargadas.Add(cuenta_conf.accountUsername, agregar_Nueva_Tab_Pagina(cuenta_conf.accountUsername, new UI_Principal(cuenta), grupo.lider.accountConfig.accountUsername));
                        }
                    }
                }
            }
        }

        private Pagina agregar_Nueva_Tab_Pagina(string titulo, UserControl control, string nombre_grupo)
        {
            Pagina nueva_pagina = tabControlCuentas.agregar_Nueva_Pagina(titulo);
            nueva_pagina.cabezera.propiedad_Imagen = Properties.Resources.circulo_rojo;
            nueva_pagina.cabezera.propiedad_Estado = "Desconectado";
            nueva_pagina.cabezera.propiedad_Grupo = nombre_grupo;
            nueva_pagina.contenido.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            return nueva_pagina;
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Opciones form_opciones = new Opciones())
                form_opciones.ShowDialog();
        }
    }
}
