namespace FakturaceTestPtacnik
{
    partial class FormZbozi
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
            this.listViewZbozi = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCenaBezDPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNaSklade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemPridat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpravit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSmazat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewZbozi
            // 
            this.listViewZbozi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNazev,
            this.columnHeaderCenaBezDPH,
            this.columnHeaderNaSklade});
            this.listViewZbozi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewZbozi.FullRowSelect = true;
            this.listViewZbozi.GridLines = true;
            this.listViewZbozi.HideSelection = false;
            this.listViewZbozi.Location = new System.Drawing.Point(0, 24);
            this.listViewZbozi.Name = "listViewZbozi";
            this.listViewZbozi.Size = new System.Drawing.Size(439, 297);
            this.listViewZbozi.TabIndex = 0;
            this.listViewZbozi.UseCompatibleStateImageBehavior = false;
            this.listViewZbozi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderNazev
            // 
            this.columnHeaderNazev.Text = "Název";
            this.columnHeaderNazev.Width = 127;
            // 
            // columnHeaderCenaBezDPH
            // 
            this.columnHeaderCenaBezDPH.Text = "Cena bez DPH";
            this.columnHeaderCenaBezDPH.Width = 117;
            // 
            // columnHeaderNaSklade
            // 
            this.columnHeaderNaSklade.Text = "Na skladě";
            this.columnHeaderNaSklade.Width = 131;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPridat,
            this.toolStripMenuItemUpravit,
            this.toolStripMenuItemSmazat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemPridat
            // 
            this.toolStripMenuItemPridat.Name = "toolStripMenuItemPridat";
            this.toolStripMenuItemPridat.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItemPridat.Text = "Přidat";
            this.toolStripMenuItemPridat.Click += new System.EventHandler(this.toolStripMenuItemPridat_Click);
            // 
            // toolStripMenuItemUpravit
            // 
            this.toolStripMenuItemUpravit.Name = "toolStripMenuItemUpravit";
            this.toolStripMenuItemUpravit.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItemUpravit.Text = "Upravit";
            this.toolStripMenuItemUpravit.Click += new System.EventHandler(this.toolStripMenuItemUpravit_Click);
            // 
            // toolStripMenuItemSmazat
            // 
            this.toolStripMenuItemSmazat.Name = "toolStripMenuItemSmazat";
            this.toolStripMenuItemSmazat.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItemSmazat.Text = "Smazat";
            this.toolStripMenuItemSmazat.Click += new System.EventHandler(this.toolStripMenuItemSmazat_Click);
            // 
            // FormZbozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 321);
            this.Controls.Add(this.listViewZbozi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormZbozi";
            this.Text = "Evidence zboží";
            this.Load += new System.EventHandler(this.FormZbozi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewZbozi;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNazev;
        private System.Windows.Forms.ColumnHeader columnHeaderCenaBezDPH;
        private System.Windows.Forms.ColumnHeader columnHeaderNaSklade;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPridat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpravit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSmazat;
    }
}