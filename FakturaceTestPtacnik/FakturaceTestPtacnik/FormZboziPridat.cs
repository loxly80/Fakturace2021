using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaceTestPtacnik
{
    public partial class FormZboziPridat : Form
    {
        public Zbozi Zbozi { get; set; }

        public FormZboziPridat(Zbozi zbozi)
        {
            InitializeComponent();
            Zbozi = zbozi;
        }

        private void FormZboziPridat_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            Zbozi.Nazev = textBoxNazev.Text;
            Zbozi.CenaBezDPH = Convert.ToInt32(numericUpDownCenaBezDPH.Value);
            DialogResult = DialogResult.OK;
        }

        private void buttonStorno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
