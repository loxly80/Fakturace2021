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
    public partial class FormZbozi : Form
    {

        public Sqlrepository sqlrepository;
        List<Zbozi> zbozi;

        public FormZbozi()
        {
            InitializeComponent();
            sqlrepository = new Sqlrepository(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = FakturaceTestPtacnik; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

        public void NactiData()
        {
            zbozi = sqlrepository.NactiZbozi();
            listViewZbozi.Items.Clear();
            foreach(var zbozi in zbozi)
            {
                listViewZbozi.Items.Add(zbozi.GetViewItem());
            }
        }

        private void FormZbozi_Load(object sender, EventArgs e)
        {
            NactiData();
        }

        private void toolStripMenuItemPridat_Click(object sender, EventArgs e)
        {
            FormZboziPridat formZboziPridat = new FormZboziPridat(new Zbozi("", 0, ""));
            if(formZboziPridat.ShowDialog() == DialogResult.OK)
            {
                sqlrepository.PridatZbozi(formZboziPridat.Zbozi);
                listViewZbozi.Items.Clear();
                foreach(var zbozi in zbozi)
                {
                    listViewZbozi.Items.Add(zbozi.GetViewItem());
                }
            }
            NactiData();
        }

        private void toolStripMenuItemUpravit_Click(object sender, EventArgs e)
        {
            if (listViewZbozi.SelectedIndices.Count > 0)
            {
                FormZboziUpravit formZboziUpravit = new FormZboziUpravit(zbozi[listViewZbozi.SelectedIndices[0]]);
                if(formZboziUpravit.ShowDialog() == DialogResult.OK)
                {
                    sqlrepository.UpravitZbozi(formZboziUpravit.Zbozi);
                    listViewZbozi.Items.Clear();
                    foreach (var zbozi in zbozi)
                    {
                        listViewZbozi.Items.Add(zbozi.GetViewItem());
                    }
                }
            }
            else
            {
                MessageBox.Show("Vyberte zboží k úpravě");
            }
            NactiData();
        }

        private void toolStripMenuItemSmazat_Click(object sender, EventArgs e)
        {
            if (listViewZbozi.SelectedIndices.Count > 0)
            {
                sqlrepository.SmazZbozi(zbozi[listViewZbozi.SelectedIndices[0]]);
                NactiData();
            }
            else
            {
                MessageBox.Show("Vyberte zboží, které chcete smazat");
            }
        }
    }
}
