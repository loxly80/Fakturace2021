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
    public partial class FormFakturaNahled : Form
    {
        public Sqlrepository sqlrepository;
        public Zakaznik Zakaznik { get; set; }
        public List<Zbozi> zboziFaktura;

        public FormFakturaNahled(Zakaznik zakaznik)
        {
            InitializeComponent();
            sqlrepository = new Sqlrepository(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = FakturaceTestPtacnik; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            Zakaznik = zakaznik;
        }

        private void FormFakturaNahled_Load(object sender, EventArgs e)
        {
            textBoxJmeno.Text = Zakaznik.Jmeno;
            textBoxTypZakaznika.Text = Zakaznik.TypZakaznika;
            textBoxAdresa.Text = Zakaznik.Adresa;
            textBoxEmail.Text = Zakaznik.Email;
            textBoxICO.Text = Zakaznik.ICO.ToString();
            textBoxTelefon.Text = Zakaznik.Telefon.ToString();
        
        }

       


    }
}
