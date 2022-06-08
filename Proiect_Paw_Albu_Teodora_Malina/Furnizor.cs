using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Paw_Albu_Teodora_Malina
{
    public class Furnizor
    {
        private List<Material> stoc = new List<Material>();

        public static explicit operator Furnizor(string v)
        {
            throw new NotImplementedException();
        }

        public List<Material> Stoc { get { return stoc; } set { stoc = value; } }

        private string denumire;
        public string Denumire
        {
            get => denumire;
            set
            {
                if (value.Length > 0)
                {
                    this.denumire = value;
                }
                else
                {
                    this.denumire = "Necunoscuta";
                }
            }
        }
        private string adresa;
        public string Adresa
        {
            get => adresa;
            set
            {
                if (value.Length > 0)
                {
                    this.adresa = value;
                }
                else
                {
                    this.adresa = "Necunoscuta";
                }
            }
        }

        public Furnizor(string denumire = "N/A")
        {
            this.denumire = denumire;
        }

        public Furnizor(string denumire = "N/A", string adresa = "N/A")
        {
            Denumire = denumire;
            Adresa = adresa;

        }


        public void adaugaMaterial(Material m)
        {
            stoc.Add(m);
        }


    }
}
