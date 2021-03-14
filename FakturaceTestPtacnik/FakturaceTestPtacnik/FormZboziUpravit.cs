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
    public partial class FormZboziUpravit : Form
    {

        public Zbozi Zbozi { get; set; }

        public FormZboziUpravit(Zbozi zbozi)
        {
            InitializeComponent();
            Zbozi = zbozi;
        }

        private void FormZboziUpravit_Load(object sender, EventArgs e)
        {
            textBoxNazev.Text = Zbozi.Nazev;
            numericUpDownCenaBezDPH.Value = Zbozi.CenaBezDPH;
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            Zbozi.Nazev = textBoxNazev.Text;
            Zbozi.CenaBezDPH = Convert.ToInt32(numericUpDownCenaBezDPH.Value);
            Zbozi.NaSklade = comboBoxNaSklade.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }

        private void buttonStorno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
