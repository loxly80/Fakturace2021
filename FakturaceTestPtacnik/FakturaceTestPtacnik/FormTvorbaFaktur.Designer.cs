namespace FakturaceTestPtacnik
{
    partial class FormTvorbaFaktur
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
            this.listViewNaSklade = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCenaBezDPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNaSklade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewNaSklade
            // 
            this.listViewNaSklade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNazev,
            this.columnHeaderCenaBezDPH,
            this.columnHeaderNaSklade});
            this.listViewNaSklade.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewNaSklade.FullRowSelect = true;
            this.listViewNaSklade.GridLines = true;
            this.listViewNaSklade.HideSelection = false;
            this.listViewNaSklade.Location = new System.Drawing.Point(0, 0);
            this.listViewNaSklade.Name = "listViewNaSklade";
            this.listViewNaSklade.Size = new System.Drawing.Size(332, 450);
            this.listViewNaSklade.TabIndex = 0;
            this.listViewNaSklade.UseCompatibleStateImageBehavior = false;
            this.listViewNaSklade.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 52;
            // 
            // columnHeaderNazev
            // 
            this.columnHeaderNazev.Text = "Název";
            this.columnHeaderNazev.Width = 122;
            // 
            // columnHeaderCenaBezDPH
            // 
            this.columnHeaderCenaBezDPH.Text = "Cena bez DPH";
            this.columnHeaderCenaBezDPH.Width = 86;
            // 
            // columnHeaderNaSklade
            // 
            this.columnHeaderNaSklade.Text = "Na skladě";
            this.columnHeaderNaSklade.Width = 69;
            // 
            // FormTvorbaFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewNaSklade);
            this.Name = "FormTvorbaFaktur";
            this.Text = "Vytvoření faktury";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewNaSklade;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNazev;
        private System.Windows.Forms.ColumnHeader columnHeaderCenaBezDPH;
        private System.Windows.Forms.ColumnHeader columnHeaderNaSklade;
    }
}