using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaceTestPtacnik
{
    public class Zakaznik
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string TypZakaznika { get; set; }
        public string Adresa { get; set; }
        public int ICO { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }

        public Zakaznik(int id, string jmeno, string typZakaznika, string adresa, int iCO, string email, int telefon)
        {
            Id = id;
            Jmeno = jmeno;
            TypZakaznika = typZakaznika;
            Adresa = adresa;
            ICO = iCO;
            Email = email;
            Telefon = telefon;
        }

        public Zakaznik(string jmeno, string typZakaznika, string adresa, int iCO, string email, int telefon)
        {
            Jmeno = jmeno;
            TypZakaznika = typZakaznika;
            Adresa = adresa;
            ICO = iCO;
            Email = email;
            Telefon = telefon;
        }

        public ListViewItem GetListViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), Jmeno, TypZakaznika, Adresa, ICO.ToString(), Email, Telefon.ToString() });
        }

    }
}
