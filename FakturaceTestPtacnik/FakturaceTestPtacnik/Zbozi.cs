using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaceTestPtacnik
{
    public class Zbozi
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int CenaBezDPH { get; set; }
        public string NaSklade { get; set; }

        public Zbozi(int id, string nazev, int cenaBezDPH, string naSklade)
        {
            Id = id;
            Nazev = nazev;
            CenaBezDPH = cenaBezDPH;
            NaSklade = naSklade;
        }

        public Zbozi(string nazev, int cenaBezDPH, string naSklade)
        {
            Nazev = nazev;
            CenaBezDPH = cenaBezDPH;
            NaSklade = naSklade;
        }

        public ListViewItem GetViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), Nazev, CenaBezDPH.ToString(), NaSklade });
        }
    }
}
