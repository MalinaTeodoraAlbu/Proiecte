using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Paw_Albu_Teodora_Malina
{

   
    public partial class Form2 : Form
    {
      
        private List<Material> Cos = new List<Material>();
        private List<Furnizor> ListaFurnizori = new List<Furnizor>();
        Form3 f3 = new Form3();
        public Form2(List<Material> cos, List<Furnizor> furnizori)
        {
            Cos = cos;
            ListaFurnizori = furnizori;
            InitializeComponent();
          


        }

        public Form2()
        {
            InitializeComponent();
        }

        private void jTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void comandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 macheta = new Form3();
            macheta.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                Cos.ForEach(m => sw.WriteLine(m.ToString()));
                sw.Close();
                Consola.Clear();
                Consola.Text = "Cosul de cumparaturi a fost salvat intr-un fisier text!";
                Cos.Clear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                Consola.Clear();
                Consola.Text += sr.ReadToEnd();
                sr.Close();
            }

        }

        private void afiseazaCosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lvMateriale.Items.Clear();
            ListViewItem item;
            string denumire ="-";
            foreach (Material m in Cos)
            {
                foreach(Furnizor f in ListaFurnizori)
                {
                    foreach(Material mf in f.Stoc)
                    {
                        if (mf.Denumire == m.Denumire)
                        {
                            denumire = f.Denumire;
                        }

                    }
                }
                item = new ListViewItem(denumire);
                item.SubItems.Add(m.Denumire);
                item.SubItems.Add(m.Cantitate.ToString());
                item.SubItems.Add(m.Pret.ToString());
                lvMateriale.Items.Add(item);
            }
            Consola.Clear();
            Consola.Text = "Cosul dvs. de cumparaturi!";
          
        }

        private void afiseazaContracteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 grafic = new Form4(Cos);
            grafic.ShowDialog();
        }

        private void printDocumentCosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consola.Text = "Lista materiale comandate: \n";
            foreach (var c in Cos)
            {
                Consola.Text += $"\r\n{c} ";
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Lista materiale comandate: \n", new Font("Arial", 15), Brushes.Red, 10, 10);
            int linia = 1;
            foreach (var c in Cos)
            {
                g.DrawString($"\r\n{c}", new Font("Arial", 15), Brushes.Red, 10, 10 + linia * 20);
                linia++;
            }
        }

        private void afiseazaContracteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void lvMateriale_ItemDrag(object sender, ItemDragEventArgs e)
        {

            List<ListViewItem> items = new List<ListViewItem>();
            items.Add((ListViewItem)e.Item);
            
            foreach (ListViewItem lvi in lvMateriale.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
          
            lvMateriale.DoDragDrop(items, DragDropEffects.Move);
        }

     

        private void lvLivrate_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lvLivrate_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                List<ListViewItem> items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                
                foreach (ListViewItem lvi in items)
                {
                   
                    lvi.ListView.Items.Remove(lvi);
                    lvLivrate.Items.Add(lvi);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Login fl = new Login();
                fl.Show();
          
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void inseturiBazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.Show();
        }
    }
}
