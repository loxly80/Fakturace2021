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
            this.listViewFaktura = new System.Windows.Forms.ListView();
            this.columnHeaderFakturaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFakturaNazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFakturaCenaBezDPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPridat = new System.Windows.Forms.Button();
            this.buttonOdebrat = new System.Windows.Forms.Button();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumFakturace = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listViewNaSklade
            // 
            this.listViewNaSklade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNazev,
            this.columnHeaderCenaBezDPH,
            this.columnHeaderNaSklade});
            this.listViewNaSklade.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewNaSklade.FullRowSelect = true;
            this.listViewNaSklade.GridLines = true;
            this.listViewNaSklade.HideSelection = false;
            this.listViewNaSklade.Location = new System.Drawing.Point(449, 0);
            this.listViewNaSklade.Name = "listViewNaSklade";
            this.listViewNaSklade.Size = new System.Drawing.Size(335, 572);
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
            // listViewFaktura
            // 
            this.listViewFaktura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFakturaID,
            this.columnHeaderFakturaNazev,
            this.columnHeaderFakturaCenaBezDPH});
            this.listViewFaktura.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewFaktura.FullRowSelect = true;
            this.listViewFaktura.GridLines = true;
            this.listViewFaktura.HideSelection = false;
            this.listViewFaktura.Location = new System.Drawing.Point(0, 0);
            this.listViewFaktura.Name = "listViewFaktura";
            this.listViewFaktura.Size = new System.Drawing.Size(287, 572);
            this.listViewFaktura.TabIndex = 1;
            this.listViewFaktura.UseCompatibleStateImageBehavior = false;
            this.listViewFaktura.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFakturaID
            // 
            this.columnHeaderFakturaID.Text = "ID";
            // 
            // columnHeaderFakturaNazev
            // 
            this.columnHeaderFakturaNazev.Text = "Název";
            this.columnHeaderFakturaNazev.Width = 126;
            // 
            // columnHeaderFakturaCenaBezDPH
            // 
            this.columnHeaderFakturaCenaBezDPH.Text = "Cena bez DPH";
            this.columnHeaderFakturaCenaBezDPH.Width = 95;
            // 
            // buttonPridat
            // 
            this.buttonPridat.Location = new System.Drawing.Point(311, 181);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(115, 42);
            this.buttonPridat.TabIndex = 2;
            this.buttonPridat.Text = "<--- Přidat zboží do faktury";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // buttonOdebrat
            // 
            this.buttonOdebrat.Location = new System.Drawing.Point(311, 243);
            this.buttonOdebrat.Name = "buttonOdebrat";
            this.buttonOdebrat.Size = new System.Drawing.Size(115, 42);
            this.buttonOdebrat.TabIndex = 3;
            this.buttonOdebrat.Text = "---> Odebrat zboží z faktury";
            this.buttonOdebrat.UseVisualStyleBackColor = true;
            this.buttonOdebrat.Click += new System.EventHandler(this.buttonOdebrat_Click);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(311, 393);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(115, 42);
            this.buttonUlozit.TabIndex = 4;
            this.buttonUlozit.Text = "Uložit fakturu";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datum fakturace";
            // 
            // dateTimePickerDatumFakturace
            // 
            this.dateTimePickerDatumFakturace.Location = new System.Drawing.Point(311, 56);
            this.dateTimePickerDatumFakturace.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDatumFakturace.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDatumFakturace.Name = "dateTimePickerDatumFakturace";
            this.dateTimePickerDatumFakturace.Size = new System.Drawing.Size(115, 20);
            this.dateTimePickerDatumFakturace.TabIndex = 6;
            this.dateTimePickerDatumFakturace.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            // 
            // FormTvorbaFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 572);
            this.Controls.Add(this.dateTimePickerDatumFakturace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.buttonOdebrat);
            this.Controls.Add(this.buttonPridat);
            this.Controls.Add(this.listViewFaktura);
            this.Controls.Add(this.listViewNaSklade);
            this.Name = "FormTvorbaFaktur";
            this.Text = "Vytvoření faktury";
            this.Load += new System.EventHandler(this.FormTvorbaFaktur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNaSklade;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNazev;
        private System.Windows.Forms.ColumnHeader columnHeaderCenaBezDPH;
        private System.Windows.Forms.ColumnHeader columnHeaderNaSklade;
        private System.Windows.Forms.ListView listViewFaktura;
        private System.Windows.Forms.ColumnHeader columnHeaderFakturaID;
        private System.Windows.Forms.ColumnHeader columnHeaderFakturaNazev;
        private System.Windows.Forms.ColumnHeader columnHeaderFakturaCenaBezDPH;
        private System.Windows.Forms.Button buttonPridat;
        private System.Windows.Forms.Button buttonOdebrat;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumFakturace;
    }
}