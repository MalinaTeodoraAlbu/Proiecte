using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Paw_Albu_Teodora_Malina
{
    public partial class Form4 : Form
    {
        private List<Material> materiale = new List<Material>();
        private const int margine = 10;
        Color culoareBari = Color.DarkBlue;
        Color culoareText = Color.Black;
        Font fontText = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        public Form4(List<Material> Cos)
        {
            materiale = Cos;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (materiale.Any())
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + 2* margine,
                    panel1.ClientRectangle.Y + 2 * margine, panel1.ClientRectangle.Width - 2 * margine,
                    panel1.ClientRectangle.Height - 2 * margine);
                Pen pen = new Pen(Color.Black, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / materiale.Count / 3;
                double distanta = (rectangle.Width - materiale.Count * latime) / (materiale.Count + 1);
                double vMax = materiale.Max(max => max.Valoare);

                Brush brBari = new SolidBrush(culoareBari);
                Brush brText = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[materiale.Count];
                for (int i = 0; i < materiale.Count; i++)
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - materiale[i].Valoare / vMax * rectangle.Height),
                        (int)(latime),
                        (int)(materiale[i].Valoare / vMax * rectangle.Height));
                    g.DrawString(materiale[i].Denumire, fontText, brText, new Point(
                        rectangles[i].Location.X, rectangles[i].Location.Y - fontText.Height));
                }

                g.FillRectangles(brBari, rectangles);

                for (int i = 0; i < materiale.Count - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2),
                        rectangles[i].Location.Y), new Point((int)(rectangles[i + 1].Location.X + latime / 2),
                        rectangles[i + 1].Location.Y));
                }
            }
        }
    }
}
