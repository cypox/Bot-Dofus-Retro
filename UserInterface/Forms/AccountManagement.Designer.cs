﻿namespace Bot_Dofus_1._29._1.UserInterface.Forms
{
    partial class AccountManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagement));
            this.tabControlPrincipalAccounts = new System.Windows.Forms.TabControl();
            this.ListaCuentas = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_informacion = new System.Windows.Forms.PictureBox();
            this.label_informacionClickCuentas = new System.Windows.Forms.Label();
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.ColumnaNombreCuenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaNombreServidor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaNombrePersonaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripFormCuentas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDelPersonajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarCuenta = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_informacion_agregar_cuenta = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Agregar_Retroceder = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Nombre_Cuenta = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Eleccion_Servidor = new System.Windows.Forms.Label();
            this.label_Nombre_Personaje = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCharacterName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.boton_Agregar_Cuenta = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imagenesFormCuentas = new System.Windows.Forms.ImageList(this.components);
            this.realCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlPrincipalAccounts.SuspendLayout();
            this.ListaCuentas.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_informacion)).BeginInit();
            this.contextMenuStripFormCuentas.SuspendLayout();
            this.AgregarCuenta.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_informacion_agregar_cuenta)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrincipalAccounts
            // 
            this.tabControlPrincipalAccounts.Controls.Add(this.ListaCuentas);
            this.tabControlPrincipalAccounts.Controls.Add(this.AgregarCuenta);
            this.tabControlPrincipalAccounts.Controls.Add(this.tabPage1);
            this.tabControlPrincipalAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipalAccounts.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabControlPrincipalAccounts.ImageList = this.imagenesFormCuentas;
            this.tabControlPrincipalAccounts.ItemSize = new System.Drawing.Size(137, 28);
            this.tabControlPrincipalAccounts.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipalAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlPrincipalAccounts.Name = "tabControlPrincipalAccounts";
            this.tabControlPrincipalAccounts.SelectedIndex = 0;
            this.tabControlPrincipalAccounts.Size = new System.Drawing.Size(484, 461);
            this.tabControlPrincipalAccounts.TabIndex = 0;
            // 
            // ListaCuentas
            // 
            this.ListaCuentas.Controls.Add(this.tableLayoutPanel1);
            this.ListaCuentas.ImageKey = "lista_cuentas.png";
            this.ListaCuentas.Location = new System.Drawing.Point(4, 32);
            this.ListaCuentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListaCuentas.Name = "ListaCuentas";
            this.ListaCuentas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListaCuentas.Size = new System.Drawing.Size(453, 354);
            this.ListaCuentas.TabIndex = 0;
            this.ListaCuentas.Text = "Liste des comptes";
            this.ListaCuentas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewAccounts, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.00565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.99435F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 346);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.15801F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.84199F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_informacion, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_informacionClickCuentas, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 304);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox_informacion
            // 
            this.pictureBox_informacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_informacion.Image = global::Bot_Dofus_1._29._1.Properties.Resources.informacion;
            this.pictureBox_informacion.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_informacion.Name = "pictureBox_informacion";
            this.pictureBox_informacion.Size = new System.Drawing.Size(38, 33);
            this.pictureBox_informacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_informacion.TabIndex = 0;
            this.pictureBox_informacion.TabStop = false;
            // 
            // label_informacionClickCuentas
            // 
            this.label_informacionClickCuentas.AutoSize = true;
            this.label_informacionClickCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_informacionClickCuentas.Location = new System.Drawing.Point(47, 0);
            this.label_informacionClickCuentas.Name = "label_informacionClickCuentas";
            this.label_informacionClickCuentas.Size = new System.Drawing.Size(391, 39);
            this.label_informacionClickCuentas.TabIndex = 1;
            this.label_informacionClickCuentas.Text = "Clic droit pour connecter/modifier/supprimer un compte\\r\\r\\double clic sur un com" +
    "pte pour le connecter";
            this.label_informacionClickCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaNombreCuenta,
            this.ColumnaNombreServidor,
            this.ColumnaNombrePersonaje});
            this.listViewAccounts.ContextMenuStrip = this.contextMenuStripFormCuentas;
            this.listViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAccounts.FullRowSelect = true;
            this.listViewAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAccounts.HideSelection = false;
            this.listViewAccounts.Location = new System.Drawing.Point(3, 4);
            this.listViewAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(441, 293);
            this.listViewAccounts.TabIndex = 1;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;
            this.listViewAccounts.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListViewAccountsColumnWidthChanging);
            this.listViewAccounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewAccountsDoubleClick);
            //
            // ColumnaNombreCuenta
            // 
            this.ColumnaNombreCuenta.Text = "Nom de compte";
            this.ColumnaNombreCuenta.Width = 148;
            // 
            // ColumnaNombreServidor
            // 
            this.ColumnaNombreServidor.Text = "Serveur";
            this.ColumnaNombreServidor.Width = 107;
            // 
            // ColumnaNombrePersonaje
            // 
            this.ColumnaNombrePersonaje.Text = "Nom du personnage";
            this.ColumnaNombrePersonaje.Width = 184;
            // 
            // contextMenuStripFormCuentas
            // 
            this.contextMenuStripFormCuentas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripFormCuentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStripFormCuentas.Name = "contextMenuStripFormCuentas";
            this.contextMenuStripFormCuentas.Size = new System.Drawing.Size(147, 82);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Image = global::Bot_Dofus_1._29._1.Properties.Resources.flecha_direccion_izquierda;
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.conectarToolStripMenuItem.Text = "Connexion";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItemClick);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.contraseñaToolStripMenuItem,
            this.nombreDelPersonajeToolStripMenuItem});
            this.modificarToolStripMenuItem.Image = global::Bot_Dofus_1._29._1.Properties.Resources.boton_ajustes;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.modificarToolStripMenuItem.Text = "Modification";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cuentaToolStripMenuItem.Text = "Compte";
            this.cuentaToolStripMenuItem.Click += new System.EventHandler(this.ModifyAccount);
            // 
            // contraseñaToolStripMenuItem
            // 
            this.contraseñaToolStripMenuItem.Name = "contraseñaToolStripMenuItem";
            this.contraseñaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.contraseñaToolStripMenuItem.Text = "Mot de passe";
            this.contraseñaToolStripMenuItem.Click += new System.EventHandler(this.ModifyAccount);
            // 
            // nombreDelPersonajeToolStripMenuItem
            // 
            this.nombreDelPersonajeToolStripMenuItem.Name = "nombreDelPersonajeToolStripMenuItem";
            this.nombreDelPersonajeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.nombreDelPersonajeToolStripMenuItem.Text = "Nom du personnage";
            this.nombreDelPersonajeToolStripMenuItem.Click += new System.EventHandler(this.ModifyAccount);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Bot_Dofus_1._29._1.Properties.Resources.cruz_roja;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.eliminarToolStripMenuItem.Text = "Retiré";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItemClick);
            // 
            // AgregarCuenta
            // 
            this.AgregarCuenta.Controls.Add(this.tableLayoutPanel3);
            this.AgregarCuenta.ImageKey = "agregar_cuenta.png";
            this.AgregarCuenta.Location = new System.Drawing.Point(4, 32);
            this.AgregarCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgregarCuenta.Name = "AgregarCuenta";
            this.AgregarCuenta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgregarCuenta.Size = new System.Drawing.Size(476, 425);
            this.AgregarCuenta.TabIndex = 1;
            this.AgregarCuenta.Text = "Ajouter un compte";
            this.AgregarCuenta.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_Agregar_Retroceder, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71429F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.714286F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(470, 417);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.374384F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.62562F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox_informacion_agregar_cuenta, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(464, 42);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // pictureBox_informacion_agregar_cuenta
            // 
            this.pictureBox_informacion_agregar_cuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_informacion_agregar_cuenta.Image = global::Bot_Dofus_1._29._1.Properties.Resources.informacion;
            this.pictureBox_informacion_agregar_cuenta.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_informacion_agregar_cuenta.Name = "pictureBox_informacion_agregar_cuenta";
            this.pictureBox_informacion_agregar_cuenta.Size = new System.Drawing.Size(32, 36);
            this.pictureBox_informacion_agregar_cuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_informacion_agregar_cuenta.TabIndex = 1;
            this.pictureBox_informacion_agregar_cuenta.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(41, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(420, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laissez le champ \"Personnage\" vide si vous voulez que le robot connecte la premiè" +
    "re personne sur le compte.";
            // 
            // checkBox_Agregar_Retroceder
            // 
            this.checkBox_Agregar_Retroceder.AutoSize = true;
            this.checkBox_Agregar_Retroceder.Checked = true;
            this.checkBox_Agregar_Retroceder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Agregar_Retroceder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Agregar_Retroceder.Location = new System.Drawing.Point(3, 386);
            this.checkBox_Agregar_Retroceder.Name = "checkBox_Agregar_Retroceder";
            this.checkBox_Agregar_Retroceder.Size = new System.Drawing.Size(464, 28);
            this.checkBox_Agregar_Retroceder.TabIndex = 51;
            this.checkBox_Agregar_Retroceder.Text = "Retour à l\'onglet \"Liste des comptes\" après l\'ajout du compte";
            this.checkBox_Agregar_Retroceder.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.boton_Agregar_Cuenta, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.63636F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.36364F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(464, 329);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.realCbx, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label_Nombre_Cuenta, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label_Password, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label_Eleccion_Servidor, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label_Nombre_Personaje, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.76923F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(458, 282);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label_Nombre_Cuenta
            // 
            this.label_Nombre_Cuenta.AutoSize = true;
            this.label_Nombre_Cuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Nombre_Cuenta.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre_Cuenta.Location = new System.Drawing.Point(3, 0);
            this.label_Nombre_Cuenta.Name = "label_Nombre_Cuenta";
            this.label_Nombre_Cuenta.Size = new System.Drawing.Size(177, 66);
            this.label_Nombre_Cuenta.TabIndex = 1;
            this.label_Nombre_Cuenta.Text = "Compte:";
            this.label_Nombre_Cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(3, 66);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(177, 66);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Mot de passe:";
            this.label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Eleccion_Servidor
            // 
            this.label_Eleccion_Servidor.AutoSize = true;
            this.label_Eleccion_Servidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Eleccion_Servidor.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Eleccion_Servidor.Location = new System.Drawing.Point(3, 132);
            this.label_Eleccion_Servidor.Name = "label_Eleccion_Servidor";
            this.label_Eleccion_Servidor.Size = new System.Drawing.Size(177, 55);
            this.label_Eleccion_Servidor.TabIndex = 5;
            this.label_Eleccion_Servidor.Text = "Serveur (Global)";
            this.label_Eleccion_Servidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Nombre_Personaje
            // 
            this.label_Nombre_Personaje.AutoSize = true;
            this.label_Nombre_Personaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Nombre_Personaje.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre_Personaje.Location = new System.Drawing.Point(3, 224);
            this.label_Nombre_Personaje.Name = "label_Nombre_Personaje";
            this.label_Nombre_Personaje.Size = new System.Drawing.Size(177, 58);
            this.label_Nombre_Personaje.TabIndex = 7;
            this.label_Nombre_Personaje.Text = "Personnage:";
            this.label_Nombre_Personaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.textBoxCharacterName, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(186, 227);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(269, 52);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // textBoxCharacterName
            // 
            this.textBoxCharacterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCharacterName.Location = new System.Drawing.Point(3, 20);
            this.textBoxCharacterName.MaxLength = 25;
            this.textBoxCharacterName.Name = "textBoxCharacterName";
            this.textBoxCharacterName.Size = new System.Drawing.Size(263, 25);
            this.textBoxCharacterName.TabIndex = 5;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.comboBoxServer, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(186, 135);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.39F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.61F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(269, 49);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.DisplayMember = "Name";
            this.comboBoxServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(3, 15);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(263, 25);
            this.comboBoxServer.TabIndex = 6;
            this.comboBoxServer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxServerSelectedIndexChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.textBoxPassword, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(186, 69);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(269, 60);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Location = new System.Drawing.Point(3, 23);
            this.textBoxPassword.MaxLength = 25;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(263, 25);
            this.textBoxPassword.TabIndex = 4;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.textBoxAccountName, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(186, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(269, 60);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAccountName.Location = new System.Drawing.Point(3, 23);
            this.textBoxAccountName.MaxLength = 25;
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(263, 25);
            this.textBoxAccountName.TabIndex = 2;
            // 
            // boton_Agregar_Cuenta
            // 
            this.boton_Agregar_Cuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boton_Agregar_Cuenta.Location = new System.Drawing.Point(3, 291);
            this.boton_Agregar_Cuenta.Name = "boton_Agregar_Cuenta";
            this.boton_Agregar_Cuenta.Size = new System.Drawing.Size(458, 35);
            this.boton_Agregar_Cuenta.TabIndex = 9;
            this.boton_Agregar_Cuenta.Text = "Ajoutez le compte";
            this.boton_Agregar_Cuenta.UseVisualStyleBackColor = true;
            this.boton_Agregar_Cuenta.Click += new System.EventHandler(this.ButtonAddAccountClick);
            // 
            // tabPage1
            // 
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 354);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ajouter plusieurs comptes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imagenesFormCuentas
            // 
            this.imagenesFormCuentas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagenesFormCuentas.ImageStream")));
            this.imagenesFormCuentas.TransparentColor = System.Drawing.Color.Transparent;
            this.imagenesFormCuentas.Images.SetKeyName(0, "agregar_cuenta.png");
            this.imagenesFormCuentas.Images.SetKeyName(1, "lista_cuentas.png");
            // 
            // realCbx
            // 
            this.realCbx.DisplayMember = "Name";
            this.realCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.realCbx.FormattingEnabled = true;
            this.realCbx.Location = new System.Drawing.Point(186, 190);
            this.realCbx.Name = "realCbx";
            this.realCbx.Size = new System.Drawing.Size(269, 25);
            this.realCbx.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Serveur (Local)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GestionCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabControlPrincipalAccounts);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "GestionCuentas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de comptes";
            this.tabControlPrincipalAccounts.ResumeLayout(false);
            this.ListaCuentas.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_informacion)).EndInit();
            this.contextMenuStripFormCuentas.ResumeLayout(false);
            this.AgregarCuenta.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_informacion_agregar_cuenta)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipalAccounts;
        private System.Windows.Forms.TabPage ListaCuentas;
        private System.Windows.Forms.TabPage AgregarCuenta;
        private System.Windows.Forms.ImageList imagenesFormCuentas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFormCuentas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox_informacion;
        private System.Windows.Forms.Label label_informacionClickCuentas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox_informacion_agregar_cuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Agregar_Retroceder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label_Nombre_Cuenta;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Eleccion_Servidor;
        private System.Windows.Forms.Button boton_Agregar_Cuenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.ColumnHeader ColumnaNombreCuenta;
        private System.Windows.Forms.ColumnHeader ColumnaNombreServidor;
        private System.Windows.Forms.ColumnHeader ColumnaNombrePersonaje;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDelPersonajeToolStripMenuItem;
        private System.Windows.Forms.Label label_Nombre_Personaje;
        private System.Windows.Forms.TextBox textBoxCharacterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox realCbx;
    }
}