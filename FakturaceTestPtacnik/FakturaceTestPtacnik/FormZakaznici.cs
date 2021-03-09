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
    public partial class FormZakaznici : Form
    {

        public Sqlrepository sqlrepository;
        List<Zakaznik> zakaznici;
        private string[] sloupce = new string[] { "IdZakaznika", "Jmeno", "TypZakaznika", "Adresa", "ICO", "Email", "Telefon"};
        private int sloupecTrideni = 0;
        private bool sestupne;

        public FormZakaznici()
        {
            InitializeComponent();
            sqlrepository = new Sqlrepository(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = FakturaceTestPtacnik; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

        public void NactiData()
        {
            zakaznici = sqlrepository.NactiZakazniky(sloupce[sloupecTrideni], sestupne);
            listViewZakaznici.Items.Clear();
            foreach(var zakaznik in zakaznici)
            {
                listViewZakaznici.Items.Add(zakaznik.GetListViewItem());
            }
        }

        private void FormZakaznici_Load(object sender, EventArgs e)
        {
            NactiData();
        }

        private void listViewZakaznici_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == sloupecTrideni)
            {
                sestupne = !sestupne;
            }
            sloupecTrideni = e.Column;
            NactiData();
        }
    }
}
