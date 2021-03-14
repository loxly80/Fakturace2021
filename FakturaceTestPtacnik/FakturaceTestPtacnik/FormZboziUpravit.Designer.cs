namespace FakturaceTestPtacnik
{
    partial class FormZboziUpravit
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.numericUpDownCenaBezDPH = new System.Windows.Forms.NumericUpDown();
            this.comboBoxNaSklade = new System.Windows.Forms.ComboBox();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.buttonStorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenaBezDPH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena bez DPH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Na skladě:";
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Location = new System.Drawing.Point(112, 29);
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(120, 20);
            this.textBoxNazev.TabIndex = 3;
            // 
            // numericUpDownCenaBezDPH
            // 
            this.numericUpDownCenaBezDPH.Location = new System.Drawing.Point(112, 55);
            this.numericUpDownCenaBezDPH.Name = "numericUpDownCenaBezDPH";
            this.numericUpDownCenaBezDPH.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCenaBezDPH.TabIndex = 4;
            // 
            // comboBoxNaSklade
            // 
            this.comboBoxNaSklade.FormattingEnabled = true;
            this.comboBoxNaSklade.Items.AddRange(new object[] {
            "ano",
            "ne"});
            this.comboBoxNaSklade.Location = new System.Drawing.Point(112, 81);
            this.comboBoxNaSklade.Name = "comboBoxNaSklade";
            this.comboBoxNaSklade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNaSklade.TabIndex = 5;
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(50, 117);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonUlozit.TabIndex = 6;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // buttonStorno
            // 
            this.buttonStorno.Location = new System.Drawing.Point(146, 117);
            this.buttonStorno.Name = "buttonStorno";
            this.buttonStorno.Size = new System.Drawing.Size(75, 23);
            this.buttonStorno.TabIndex = 7;
            this.buttonStorno.Text = "Storno";
            this.buttonStorno.UseVisualStyleBackColor = true;
            this.buttonStorno.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // FormZboziUpravit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 152);
            this.Controls.Add(this.buttonStorno);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.comboBoxNaSklade);
            this.Controls.Add(this.numericUpDownCenaBezDPH);
            this.Controls.Add(this.textBoxNazev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormZboziUpravit";
            this.Text = "Úprava zboží";
            this.Load += new System.EventHandler(this.FormZboziUpravit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenaBezDPH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNazev;
        private System.Windows.Forms.NumericUpDown numericUpDownCenaBezDPH;
        private System.Windows.Forms.ComboBox comboBoxNaSklade;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Button buttonStorno;
    }
}