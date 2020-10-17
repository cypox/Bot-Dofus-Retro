namespace Bot_Dofus_1._29._1.Interfaces
{
    partial class UI_Craft
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openTool = new System.Windows.Forms.Button();
            this.add_item = new System.Windows.Forms.Button();
            this.add_fo_rune = new System.Windows.Forms.Button();
            this.craft = new System.Windows.Forms.Button();
            this.closeWorkshop = new System.Windows.Forms.Button();
            this.remove_rune = new System.Windows.Forms.Button();
            this.add_in_rune = new System.Windows.Forms.Button();
            this.automate_Craft = new System.Windows.Forms.Button();
            this.stop_auto = new System.Windows.Forms.Button();
            this.auto_fm_amu = new System.Windows.Forms.Button();
            this.fm_anneau = new System.Windows.Forms.Button();
            this.fm_cm = new System.Windows.Forms.Button();
            this.fm_chapeau = new System.Windows.Forms.Button();
            this.fm_cape = new System.Windows.Forms.Button();
            this.auto_chapeau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openTool
            // 
            this.openTool.Location = new System.Drawing.Point(168, 55);
            this.openTool.Name = "openTool";
            this.openTool.Size = new System.Drawing.Size(75, 23);
            this.openTool.TabIndex = 0;
            this.openTool.Text = "FM AMU";
            this.openTool.UseVisualStyleBackColor = true;
            this.openTool.Click += new System.EventHandler(this.openTool_Click);
            // 
            // add_item
            // 
            this.add_item.Location = new System.Drawing.Point(103, 355);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(75, 23);
            this.add_item.TabIndex = 1;
            this.add_item.Text = "Put Item";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // add_fo_rune
            // 
            this.add_fo_rune.Location = new System.Drawing.Point(35, 397);
            this.add_fo_rune.Name = "add_fo_rune";
            this.add_fo_rune.Size = new System.Drawing.Size(103, 23);
            this.add_fo_rune.TabIndex = 2;
            this.add_fo_rune.Text = "Put FO Rune";
            this.add_fo_rune.UseVisualStyleBackColor = true;
            this.add_fo_rune.Click += new System.EventHandler(this.add_rune_Click);
            // 
            // craft
            // 
            this.craft.Location = new System.Drawing.Point(103, 436);
            this.craft.Name = "craft";
            this.craft.Size = new System.Drawing.Size(75, 23);
            this.craft.TabIndex = 3;
            this.craft.Text = "Craft";
            this.craft.UseVisualStyleBackColor = true;
            this.craft.Click += new System.EventHandler(this.craft_Click);
            // 
            // closeWorkshop
            // 
            this.closeWorkshop.Location = new System.Drawing.Point(184, 436);
            this.closeWorkshop.Name = "closeWorkshop";
            this.closeWorkshop.Size = new System.Drawing.Size(75, 23);
            this.closeWorkshop.TabIndex = 4;
            this.closeWorkshop.Text = "Close";
            this.closeWorkshop.UseVisualStyleBackColor = true;
            this.closeWorkshop.Click += new System.EventHandler(this.closeWorkshop_Click);
            // 
            // remove_rune
            // 
            this.remove_rune.Location = new System.Drawing.Point(141, 397);
            this.remove_rune.Name = "remove_rune";
            this.remove_rune.Size = new System.Drawing.Size(110, 23);
            this.remove_rune.TabIndex = 5;
            this.remove_rune.Text = "Remove Rune";
            this.remove_rune.UseVisualStyleBackColor = true;
            this.remove_rune.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_in_rune
            // 
            this.add_in_rune.Location = new System.Drawing.Point(257, 397);
            this.add_in_rune.Name = "add_in_rune";
            this.add_in_rune.Size = new System.Drawing.Size(103, 23);
            this.add_in_rune.TabIndex = 6;
            this.add_in_rune.Text = "Put IN Rune";
            this.add_in_rune.UseVisualStyleBackColor = true;
            this.add_in_rune.Click += new System.EventHandler(this.add_in_rune_Click);
            // 
            // automate_Craft
            // 
            this.automate_Craft.Location = new System.Drawing.Point(281, 55);
            this.automate_Craft.Name = "automate_Craft";
            this.automate_Craft.Size = new System.Drawing.Size(188, 23);
            this.automate_Craft.TabIndex = 7;
            this.automate_Craft.Text = "Automate ANNEAU CHEF BWORK";
            this.automate_Craft.UseVisualStyleBackColor = true;
            this.automate_Craft.Click += new System.EventHandler(this.automate_Craft_ClickAsync);
            // 
            // stop_auto
            // 
            this.stop_auto.Location = new System.Drawing.Point(535, 215);
            this.stop_auto.Name = "stop_auto";
            this.stop_auto.Size = new System.Drawing.Size(75, 23);
            this.stop_auto.TabIndex = 8;
            this.stop_auto.Text = "Stop Auto";
            this.stop_auto.UseVisualStyleBackColor = true;
            this.stop_auto.Click += new System.EventHandler(this.stop_auto_Click);
            // 
            // auto_fm_amu
            // 
            this.auto_fm_amu.Location = new System.Drawing.Point(304, 26);
            this.auto_fm_amu.Name = "auto_fm_amu";
            this.auto_fm_amu.Size = new System.Drawing.Size(119, 23);
            this.auto_fm_amu.TabIndex = 9;
            this.auto_fm_amu.Text = "Automate AMU";
            this.auto_fm_amu.UseVisualStyleBackColor = true;
            this.auto_fm_amu.Click += new System.EventHandler(this.auto_fm_amu_Click);
            // 
            // fm_anneau
            // 
            this.fm_anneau.Location = new System.Drawing.Point(49, 55);
            this.fm_anneau.Name = "fm_anneau";
            this.fm_anneau.Size = new System.Drawing.Size(103, 23);
            this.fm_anneau.TabIndex = 10;
            this.fm_anneau.Text = "FM ANNEAU";
            this.fm_anneau.UseVisualStyleBackColor = true;
            this.fm_anneau.Click += new System.EventHandler(this.fm_anneau_Click);
            // 
            // fm_cm
            // 
            this.fm_cm.Location = new System.Drawing.Point(281, 84);
            this.fm_cm.Name = "fm_cm";
            this.fm_cm.Size = new System.Drawing.Size(188, 23);
            this.fm_cm.TabIndex = 11;
            this.fm_cm.Text = "Automate ANNEAU CM";
            this.fm_cm.UseVisualStyleBackColor = true;
            this.fm_cm.Click += new System.EventHandler(this.fm_cm_Click);
            // 
            // fm_chapeau
            // 
            this.fm_chapeau.Location = new System.Drawing.Point(49, 215);
            this.fm_chapeau.Name = "fm_chapeau";
            this.fm_chapeau.Size = new System.Drawing.Size(103, 23);
            this.fm_chapeau.TabIndex = 12;
            this.fm_chapeau.Text = "FM CHAPEAU";
            this.fm_chapeau.UseVisualStyleBackColor = true;
            this.fm_chapeau.Click += new System.EventHandler(this.fm_chapeau_Click);
            // 
            // fm_cape
            // 
            this.fm_cape.Location = new System.Drawing.Point(168, 215);
            this.fm_cape.Name = "fm_cape";
            this.fm_cape.Size = new System.Drawing.Size(103, 23);
            this.fm_cape.TabIndex = 13;
            this.fm_cape.Text = "FM CAPE";
            this.fm_cape.UseVisualStyleBackColor = true;
            this.fm_cape.Click += new System.EventHandler(this.fm_cape_Click);
            // 
            // auto_chapeau
            // 
            this.auto_chapeau.Location = new System.Drawing.Point(320, 215);
            this.auto_chapeau.Name = "auto_chapeau";
            this.auto_chapeau.Size = new System.Drawing.Size(119, 23);
            this.auto_chapeau.TabIndex = 14;
            this.auto_chapeau.Text = "Automate Coiffe";
            this.auto_chapeau.UseVisualStyleBackColor = true;
            this.auto_chapeau.Click += new System.EventHandler(this.auto_chapeau_Click);
            // 
            // UI_Craft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.auto_chapeau);
            this.Controls.Add(this.fm_cape);
            this.Controls.Add(this.fm_chapeau);
            this.Controls.Add(this.fm_cm);
            this.Controls.Add(this.fm_anneau);
            this.Controls.Add(this.auto_fm_amu);
            this.Controls.Add(this.stop_auto);
            this.Controls.Add(this.automate_Craft);
            this.Controls.Add(this.add_in_rune);
            this.Controls.Add(this.remove_rune);
            this.Controls.Add(this.closeWorkshop);
            this.Controls.Add(this.craft);
            this.Controls.Add(this.add_fo_rune);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.openTool);
            this.Name = "UI_Craft";
            this.Size = new System.Drawing.Size(790, 500);
            this.Load += new System.EventHandler(this.UI_Craft_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openTool;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button add_fo_rune;
        private System.Windows.Forms.Button craft;
        private System.Windows.Forms.Button closeWorkshop;
        private System.Windows.Forms.Button remove_rune;
        private System.Windows.Forms.Button add_in_rune;
        private System.Windows.Forms.Button automate_Craft;
        private System.Windows.Forms.Button stop_auto;
        private System.Windows.Forms.Button auto_fm_amu;
        private System.Windows.Forms.Button fm_anneau;
        private System.Windows.Forms.Button fm_cm;
        private System.Windows.Forms.Button fm_chapeau;
        private System.Windows.Forms.Button fm_cape;
        private System.Windows.Forms.Button auto_chapeau;
    }
}
