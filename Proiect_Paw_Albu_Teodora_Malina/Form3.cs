using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_Paw_Albu_Teodora_Malina
{
    public partial class Form3 : Form
    {
        public List<Furnizor> ListaFurnizori = new List<Furnizor>();
        private List<Contract> ListaContracte = new List<Contract>();
        private List<Material> Cos = new List<Material>();
        Control[] vector1;
        Control[] vector2;
        Form2 f2;

        string conexiuneString;
        public Form3()
        {
            InitializeComponent();
            ListaFurnizori.Add(new Furnizor("Dedeman"));//0
            ListaFurnizori.Add(new Furnizor("Max"));
            conexiuneString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD.accdb";
            foreach (Furnizor f in ListaFurnizori)
            {
                comboFurnizor.Items.Add(f.Denumire);
            }
            ListaFurnizori[0].adaugaMaterial(new Material("Ciment", 25));
            ListaFurnizori[0].adaugaMaterial(new Material("Adeziv poliuretanic", 25));
            ListaFurnizori[0].adaugaMaterial(new Material("Glet Baumit FinoGrande", 28));
            ListaFurnizori[0].adaugaMaterial(new Material("Tencuiala decorativa", 25));

            ListaFurnizori[1].adaugaMaterial(new Material("Gresie 7383 SOREL BLUE", 25));
            ListaFurnizori[1].adaugaMaterial(new Material("Gresie 7401 FOREST BEIGE", 25));
            ListaFurnizori[1].adaugaMaterial(new Material("Parcht Laminat", 28));
            ListaFurnizori[1].adaugaMaterial(new Material("Tapet", 29));

        }


        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Proiect;Integrated Security=True;Pooling=False");
        
        public void GenerateId()
        {
            string comId;
            string query = "select id_comanda from comanda recod order by id_comanda desc";
            sc.Open();
            SqlCommand scmom = new SqlCommand(query,sc);
            SqlDataReader dr = scmom.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                comId = id.ToString("0000");
            }
            else if (Convert.IsDBNull(dr))
            {
                comId = ("0001");
            }
            else
            {
                comId = ("0001");

            }
            sc.Close();
            IDtb.Text = comId.ToString();
        }

        private void Anuleaza_Click(object sender, EventArgs e)
        {
            comboFurnizor.SelectedIndex = -1;
            comboMateriale.Items.Clear();
            numericCantitate.ResetText();
            tbPret.Clear();
            this.Close();
            this.Hide();
            f2 = new Form2();
           
            f2.Consola.Clear();
            f2.Consola.Text = "Ati anulat!" + Environment.NewLine;
            f2.ShowDialog();
        }

        private void Adauga_Click(object sender, EventArgs e)
        {
           
          
            string mesaj;
            string selectat = comboMateriale.GetItemText(comboMateriale.SelectedItem);
            int i, cantitate = int.Parse(numericCantitate.Text);
            if (String.IsNullOrEmpty(tbPret.Text))
            {
                MessageBox.Show("Nu ati selectat furnizorul/materialul!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                consola_add.Text = "ERR";
            }

            float pret = float.Parse(tbPret.Text);

            SqlCommand sm = new SqlCommand("insert into Comanda(id_comanda,furnizor,material,cantitate,pret) values("+IDtb.Text+",'" + comboFurnizor.Text + "','" + comboMateriale.Text + "'," + numericCantitate.Text + "," + tbPret.Text + ");", sc);
            IDtb.Text = (int.Parse(IDtb.Text) + 1).ToString();
            sc.Open();
            sm.ExecuteNonQuery();
            sc.Close();

            MessageBox.Show("Data saved");
            for (i = 0; i < Cos.Count; i++)
            {
                if (Cos[i].Denumire == selectat)
                {
                    Cos[i].Cantitate += cantitate;
                    break;
                }
            }
            if (i == Cos.Count)
            {
                Material aux = new Material(cantitate, selectat, pret);
                Cos.Add(aux);
                mesaj = "Materialul a fost adaugat! Detalii material comandat:" + Environment.NewLine;
                mesaj += aux.ToString();
            }
            else
            {
                mesaj = "Cantitatea pentru materialul " + selectat + " a fost modificata! Detalii material comandat:" + Environment.NewLine;
                mesaj += Cos[i].ToString();

            }

            
            consola_add.Clear();
            consola_add.Text += mesaj;
            
        }

        private void comboFurnizor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                if (comboFurnizor.SelectedIndex != -1)
                {
                    comboMateriale.Items.Clear();
                    List<Material> aux = ListaFurnizori[comboFurnizor.SelectedIndex].Stoc;
                    aux.ForEach(m => comboMateriale.Items.Add(m.Denumire));

                }
            
        }

        private void comboMateriale_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                if (comboMateriale.SelectedIndex != -1)
                {
                    tbPret.Text = ListaFurnizori[comboFurnizor.SelectedIndex].Stoc[comboMateriale.SelectedIndex].Pret.ToString();

                }
           
        }

        private void Finalizeaza_Click(object sender, EventArgs e)
        {

                float total = (float)Cos.Sum(m => m.Valoare);

            this.Close();
            this.Hide();
            f2 = new Form2(Cos,ListaFurnizori);

            f2.Consola.Clear();
            f2.Consola.Text = "Valoarea totala de plata este: " + total;
            f2.ShowDialog();

            

        }

        private void tbPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericCantitate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GenerateId();
        }
    }
}
