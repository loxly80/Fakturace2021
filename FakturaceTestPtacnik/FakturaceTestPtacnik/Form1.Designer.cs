namespace FakturaceTestPtacnik
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonZakaznici = new System.Windows.Forms.Button();
            this.buttonZbozi = new System.Windows.Forms.Button();
            this.buttonTvorbaFaktur = new System.Windows.Forms.Button();
            this.buttonStatistiky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonZakaznici
            // 
            this.buttonZakaznici.Location = new System.Drawing.Point(12, 12);
            this.buttonZakaznici.Name = "buttonZakaznici";
            this.buttonZakaznici.Size = new System.Drawing.Size(173, 143);
            this.buttonZakaznici.TabIndex = 0;
            this.buttonZakaznici.Text = "Zákazníci";
            this.buttonZakaznici.UseVisualStyleBackColor = true;
            this.buttonZakaznici.Click += new System.EventHandler(this.buttonZakaznici_Click);
            // 
            // buttonZbozi
            // 
            this.buttonZbozi.Location = new System.Drawing.Point(191, 12);
            this.buttonZbozi.Name = "buttonZbozi";
            this.buttonZbozi.Size = new System.Drawing.Size(173, 143);
            this.buttonZbozi.TabIndex = 1;
            this.buttonZbozi.Text = "Zboží";
            this.buttonZbozi.UseVisualStyleBackColor = true;
            this.buttonZbozi.Click += new System.EventHandler(this.buttonZbozi_Click);
            // 
            // buttonTvorbaFaktur
            // 
            this.buttonTvorbaFaktur.Location = new System.Drawing.Point(370, 12);
            this.buttonTvorbaFaktur.Name = "buttonTvorbaFaktur";
            this.buttonTvorbaFaktur.Size = new System.Drawing.Size(173, 143);
            this.buttonTvorbaFaktur.TabIndex = 2;
            this.buttonTvorbaFaktur.Text = "Faktury";
            this.buttonTvorbaFaktur.UseVisualStyleBackColor = true;
            this.buttonTvorbaFaktur.Click += new System.EventHandler(this.buttonTvorbaFaktur_Click);
            // 
            // buttonStatistiky
            // 
            this.buttonStatistiky.Location = new System.Drawing.Point(549, 12);
            this.buttonStatistiky.Name = "buttonStatistiky";
            this.buttonStatistiky.Size = new System.Drawing.Size(173, 143);
            this.buttonStatistiky.TabIndex = 3;
            this.buttonStatistiky.Text = "Statistiky";
            this.buttonStatistiky.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 163);
            this.Controls.Add(this.buttonStatistiky);
            this.Controls.Add(this.buttonTvorbaFaktur);
            this.Controls.Add(this.buttonZbozi);
            this.Controls.Add(this.buttonZakaznici);
            this.Name = "Form1";
            this.Text = "Formulář";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonZakaznici;
        private System.Windows.Forms.Button buttonZbozi;
        private System.Windows.Forms.Button buttonTvorbaFaktur;
        private System.Windows.Forms.Button buttonStatistiky;
    }
}

