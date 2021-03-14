namespace FakturaceTestPtacnik
{
    partial class FormZakaznici
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
            this.listViewZakaznici = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTypZakaznika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderICO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemVytvoritFakturu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewZakaznici
            // 
            this.listViewZakaznici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderJmeno,
            this.columnHeaderTypZakaznika,
            this.columnHeaderAdresa,
            this.columnHeaderICO,
            this.columnHeaderEmail,
            this.columnHeaderTelefon});
            this.listViewZakaznici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewZakaznici.FullRowSelect = true;
            this.listViewZakaznici.GridLines = true;
            this.listViewZakaznici.HideSelection = false;
            this.listViewZakaznici.Location = new System.Drawing.Point(0, 24);
            this.listViewZakaznici.Name = "listViewZakaznici";
            this.listViewZakaznici.Size = new System.Drawing.Size(800, 426);
            this.listViewZakaznici.TabIndex = 0;
            this.listViewZakaznici.UseCompatibleStateImageBehavior = false;
            this.listViewZakaznici.View = System.Windows.Forms.View.Details;
            this.listViewZakaznici.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewZakaznici_ColumnClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 72;
            // 
            // columnHeaderJmeno
            // 
            this.columnHeaderJmeno.Text = "Název/příjmení a jméno";
            this.columnHeaderJmeno.Width = 157;
            // 
            // columnHeaderTypZakaznika
            // 
            this.columnHeaderTypZakaznika.Text = "Typ zákazníka";
            this.columnHeaderTypZakaznika.Width = 113;
            // 
            // columnHeaderAdresa
            // 
            this.columnHeaderAdresa.Text = "Adresa";
            this.columnHeaderAdresa.Width = 154;
            // 
            // columnHeaderICO
            // 
            this.columnHeaderICO.Text = "IČO";
            this.columnHeaderICO.Width = 96;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 112;
            // 
            // columnHeaderTelefon
            // 
            this.columnHeaderTelefon.Text = "Telefon";
            this.columnHeaderTelefon.Width = 91;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemVytvoritFakturu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemVytvoritFakturu
            // 
            this.toolStripMenuItemVytvoritFakturu.Name = "toolStripMenuItemVytvoritFakturu";
            this.toolStripMenuItemVytvoritFakturu.Size = new System.Drawing.Size(101, 20);
            this.toolStripMenuItemVytvoritFakturu.Text = "Vytvořit fakturu";
            this.toolStripMenuItemVytvoritFakturu.Click += new System.EventHandler(this.toolStripMenuItemVytvoritFakturu_Click);
            // 
            // FormZakaznici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewZakaznici);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormZakaznici";
            this.Text = "Evidence zákazníků";
            this.Load += new System.EventHandler(this.FormZakaznici_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewZakaznici;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderJmeno;
        private System.Windows.Forms.ColumnHeader columnHeaderTypZakaznika;
        private System.Windows.Forms.ColumnHeader columnHeaderAdresa;
        private System.Windows.Forms.ColumnHeader columnHeaderICO;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVytvoritFakturu;
    }
}