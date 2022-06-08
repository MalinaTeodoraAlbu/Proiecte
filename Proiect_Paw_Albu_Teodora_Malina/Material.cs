using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Paw_Albu_Teodora_Malina
{
    public class Material
    {

        private int cantitate;
        public int Cantitate
        {
            get => cantitate;
            set
            {
                if (value > 0)
                {
                    this.cantitate = value;
                }
                else
                {
                    this.cantitate = 0;
                }
            }
        }
        public double Valoare
        {
            get => Cantitate * Pret;
        }

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

        private float pret;
        public float Pret
        {
            get => pret;
            set
            {
                if (value > 0)
                {
                    this.pret = value;
                }
                else
                {
                    this.pret = 0.0f;
                }
            }
        }


        public Material(string denumire = "Necunoscuta")
        {
            this.denumire = denumire;

        }
        public Material(string denumire = "Necunoscuta", float pret = 0)
        {
            this.denumire = denumire;
            this.pret = pret;
        }

        public Material(int cantitate, string denumire, float pret)
        {
            this.cantitate = cantitate;
            this.denumire = denumire;
            this.pret = pret;
        }

        public override string ToString()
        {
            string mesaj = "Denumire " + denumire + " cantitate " + cantitate + " pret " + pret + " valoare " + Valoare + Environment.NewLine;
            return mesaj;
        }
    }
}

