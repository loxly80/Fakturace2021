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
    public partial class FormTvorbaFaktur : Form
    {

        public Sqlrepository sqlrepository;
        public List<Zbozi> zboziNaSklade;
        public List<Zbozi> zboziFaktura;
        public Zakaznik Zakaznik { get; set; }

        public FormTvorbaFaktur(Zakaznik zakaznik)
        {
            InitializeComponent();
            sqlrepository = new Sqlrepository(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = FakturaceTestPtacnik; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            Zakaznik = zakaznik;
            zboziNaSklade = new List<Zbozi>();
        }

        public void NactiZboziNaSklade()
        {
            zboziNaSklade = sqlrepository.NactiZboziNaSklade();
            listViewNaSklade.Items.Clear();
            foreach(var zboziNaSklade in zboziNaSklade)
            {
                listViewNaSklade.Items.Add(zboziNaSklade.GetViewItem());
            }
        }

        public void NactiZboziFaktura()
        {
            zboziFaktura = sqlrepository.NactiZboziFaktury(Zakaznik);
            listViewFaktura.Items.Clear();
            foreach(var zboziFaktura in zboziFaktura)
            {
                listViewFaktura.Items.Add(zboziFaktura.GetViewItem());
            }
        }

        private void FormTvorbaFaktur_Load(object sender, EventArgs e)
        {
            NactiZboziNaSklade();
            NactiZboziFaktura();
        }

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            if(listViewNaSklade.SelectedIndices.Count > 0)
            {
                sqlrepository.PridejZboziDoFaktury(Zakaznik, zboziNaSklade[listViewNaSklade.SelectedIndices[0]]);
                NactiZboziFaktura();
            }
            else
            {
                MessageBox.Show("Zvolte zboží, které chcete přidat do faktury");
            }
        }

        private void buttonOdebrat_Click(object sender, EventArgs e)
        {
            if (listViewFaktura.SelectedIndices.Count > 0)
            {
                sqlrepository.VratZboziDoSkladu(Zakaznik, zboziFaktura[listViewFaktura.SelectedIndices[0]]);
                NactiZboziFaktura();
            }
            else
            {
                MessageBox.Show("Zvolte zboží, které chcete odebrat z faktury");
            }
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            FormFakturaNahled formFakturaNahled = new FormFakturaNahled(Zakaznik);
            formFakturaNahled.ShowDialog();
        }
    }
}
