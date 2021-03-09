namespace TestFakturacePtacnik
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
            this.buttonFakturace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonZakaznici
            // 
            this.buttonZakaznici.Location = new System.Drawing.Point(12, 12);
            this.buttonZakaznici.Name = "buttonZakaznici";
            this.buttonZakaznici.Size = new System.Drawing.Size(161, 130);
            this.buttonZakaznici.TabIndex = 0;
            this.buttonZakaznici.Text = "Zákazníci";
            this.buttonZakaznici.UseVisualStyleBackColor = true;
            // 
            // buttonZbozi
            // 
            this.buttonZbozi.Location = new System.Drawing.Point(179, 12);
            this.buttonZbozi.Name = "buttonZbozi";
            this.buttonZbozi.Size = new System.Drawing.Size(161, 130);
            this.buttonZbozi.TabIndex = 1;
            this.buttonZbozi.Text = "Zboží";
            this.buttonZbozi.UseVisualStyleBackColor = true;
            // 
            // buttonFakturace
            // 
            this.buttonFakturace.Location = new System.Drawing.Point(347, 12);
            this.buttonFakturace.Name = "buttonFakturace";
            this.buttonFakturace.Size = new System.Drawing.Size(161, 130);
            this.buttonFakturace.TabIndex = 2;
            this.buttonFakturace.Text = "Fakturace";
            this.buttonFakturace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 156);
            this.Controls.Add(this.buttonFakturace);
            this.Controls.Add(this.buttonZbozi);
            this.Controls.Add(this.buttonZakaznici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Formulář";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonZakaznici;
        private System.Windows.Forms.Button buttonZbozi;
        private System.Windows.Forms.Button buttonFakturace;
    }
}

