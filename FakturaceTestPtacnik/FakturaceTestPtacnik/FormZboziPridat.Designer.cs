namespace FakturaceTestPtacnik
{
    partial class FormZboziPridat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCenaBezDPH = new System.Windows.Forms.NumericUpDown();
            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.buttonPridat = new System.Windows.Forms.Button();
            this.buttonStorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenaBezDPH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena bez DPH:";
            // 
            // numericUpDownCenaBezDPH
            // 
            this.numericUpDownCenaBezDPH.Location = new System.Drawing.Point(92, 54);
            this.numericUpDownCenaBezDPH.Name = "numericUpDownCenaBezDPH";
            this.numericUpDownCenaBezDPH.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCenaBezDPH.TabIndex = 2;
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Location = new System.Drawing.Point(92, 25);
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazev.TabIndex = 3;
            // 
            // buttonPridat
            // 
            this.buttonPridat.Location = new System.Drawing.Point(40, 97);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(75, 23);
            this.buttonPridat.TabIndex = 4;
            this.buttonPridat.Text = "Přidat";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // buttonStorno
            // 
            this.buttonStorno.Location = new System.Drawing.Point(147, 97);
            this.buttonStorno.Name = "buttonStorno";
            this.buttonStorno.Size = new System.Drawing.Size(75, 23);
            this.buttonStorno.TabIndex = 5;
            this.buttonStorno.Text = "Storno";
            this.buttonStorno.UseVisualStyleBackColor = true;
            this.buttonStorno.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // FormZboziPridat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 139);
            this.Controls.Add(this.buttonStorno);
            this.Controls.Add(this.buttonPridat);
            this.Controls.Add(this.textBoxNazev);
            this.Controls.Add(this.numericUpDownCenaBezDPH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormZboziPridat";
            this.Text = "Přidat zboží";
            this.Load += new System.EventHandler(this.FormZboziPridat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenaBezDPH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCenaBezDPH;
        private System.Windows.Forms.TextBox textBoxNazev;
        private System.Windows.Forms.Button buttonPridat;
        private System.Windows.Forms.Button buttonStorno;
    }
}