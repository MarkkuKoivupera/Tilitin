namespace Tilitin
{
    partial class Tilitin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TlSrpMnI_Tuo = new System.Windows.Forms.ToolStripMenuItem();
            this.TlSrpMnI_Vie = new System.Windows.Forms.ToolStripMenuItem();
            this.TlSrpMnI_TuoCvsTeksti = new System.Windows.Forms.ToolStripMenuItem();
            this.TlSrpMnI_VieCvsTeksti = new System.Windows.Forms.ToolStripMenuItem();
            this.TlSrpMnI_Asetukset = new System.Windows.Forms.ToolStripMenuItem();
            this.yhtiönTiedotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TlSrpMnI_TilinPäätös = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.TlSrpMnI_Asetukset,
            this.TlSrpMnI_TilinPäätös});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlSrpMnI_Tuo,
            this.TlSrpMnI_Vie});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "&Tiedosto";
            // 
            // TlSrpMnI_Tuo
            // 
            this.TlSrpMnI_Tuo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlSrpMnI_TuoCvsTeksti});
            this.TlSrpMnI_Tuo.Name = "TlSrpMnI_Tuo";
            this.TlSrpMnI_Tuo.Size = new System.Drawing.Size(180, 22);
            this.TlSrpMnI_Tuo.Text = "&Tuo";
            // 
            // TlSrpMnI_Vie
            // 
            this.TlSrpMnI_Vie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlSrpMnI_VieCvsTeksti});
            this.TlSrpMnI_Vie.Name = "TlSrpMnI_Vie";
            this.TlSrpMnI_Vie.Size = new System.Drawing.Size(180, 22);
            this.TlSrpMnI_Vie.Text = "&Vie";
            // 
            // TlSrpMnI_TuoCvsTeksti
            // 
            this.TlSrpMnI_TuoCvsTeksti.Name = "TlSrpMnI_TuoCvsTeksti";
            this.TlSrpMnI_TuoCvsTeksti.Size = new System.Drawing.Size(180, 22);
            this.TlSrpMnI_TuoCvsTeksti.Text = ".CVS teksti";
            // 
            // TlSrpMnI_VieCvsTeksti
            // 
            this.TlSrpMnI_VieCvsTeksti.Name = "TlSrpMnI_VieCvsTeksti";
            this.TlSrpMnI_VieCvsTeksti.Size = new System.Drawing.Size(180, 22);
            this.TlSrpMnI_VieCvsTeksti.Text = ".CVS Tekti";
            // 
            // TlSrpMnI_Asetukset
            // 
            this.TlSrpMnI_Asetukset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yhtiönTiedotToolStripMenuItem});
            this.TlSrpMnI_Asetukset.Name = "TlSrpMnI_Asetukset";
            this.TlSrpMnI_Asetukset.Size = new System.Drawing.Size(70, 20);
            this.TlSrpMnI_Asetukset.Text = "&Asetukset";
            // 
            // yhtiönTiedotToolStripMenuItem
            // 
            this.yhtiönTiedotToolStripMenuItem.Name = "yhtiönTiedotToolStripMenuItem";
            this.yhtiönTiedotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yhtiönTiedotToolStripMenuItem.Text = "&Yhtiön tiedot";
            // 
            // TlSrpMnI_TilinPäätös
            // 
            this.TlSrpMnI_TilinPäätös.Name = "TlSrpMnI_TilinPäätös";
            this.TlSrpMnI_TilinPäätös.Size = new System.Drawing.Size(76, 20);
            this.TlSrpMnI_TilinPäätös.Text = "Tilin&päätös";
            // 
            // Tilitin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 542);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tilitin";
            this.Text = "TiliTin - kirjanpito";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TlSrpMnI_Tuo;
        private System.Windows.Forms.ToolStripMenuItem TlSrpMnI_TuoCvsTeksti;
        private System.Windows.Forms.ToolStripMenuItem TlSrpMnI_Vie;
        private System.Windows.Forms.ToolStripMenuItem TlSrpMnI_VieCvsTeksti;
        private System.Windows.Forms.ToolStripMenuItem TlSrpMnI_Asetukset;
        private System.Windows.Forms.ToolStripMenuItem yhtiönTiedotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TlSrpMnI_TilinPäätös;
    }
}

