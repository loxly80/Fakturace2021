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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZakaznici_Click(object sender, EventArgs e)
        {
            FormZakaznici formZakaznici = new FormZakaznici();
            formZakaznici.ShowDialog();
        }

        private void buttonZbozi_Click(object sender, EventArgs e)
        {
            FormZbozi formZbozi = new FormZbozi();
            formZbozi.ShowDialog();
        }

        private void buttonTvorbaFaktur_Click(object sender, EventArgs e)
        {
            FormTvorbaFaktur formTvorbaFaktur = new FormTvorbaFaktur();
            formTvorbaFaktur.ShowDialog();
        }
    }
}
