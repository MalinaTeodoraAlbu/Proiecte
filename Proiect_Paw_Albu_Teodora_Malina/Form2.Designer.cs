
namespace Proiect_Paw_Albu_Teodora_Malina
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaCosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaContracteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocumentCosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvMateriale = new System.Windows.Forms.ListView();
            this.Furnizor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Consola = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lvLivrate = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.inseturiBazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.raportToolStripMenuItem,
            this.printToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandaToolStripMenuItem,
            this.inseturiBazaDeDateToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comandaToolStripMenuItem.Text = "Comanda";
            this.comandaToolStripMenuItem.Click += new System.EventHandler(this.comandaToolStripMenuItem_Click);
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiseazaCosToolStripMenuItem,
            this.afiseazaContracteToolStripMenuItem});
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.raportToolStripMenuItem.Text = "Raport";
            // 
            // afiseazaCosToolStripMenuItem
            // 
            this.afiseazaCosToolStripMenuItem.Name = "afiseazaCosToolStripMenuItem";
            this.afiseazaCosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afiseazaCosToolStripMenuItem.Text = "Afiseaza cos";
            this.afiseazaCosToolStripMenuItem.Click += new System.EventHandler(this.afiseazaCosToolStripMenuItem_Click);
            // 
            // afiseazaContracteToolStripMenuItem
            // 
            this.afiseazaContracteToolStripMenuItem.Name = "afiseazaContracteToolStripMenuItem";
            this.afiseazaContracteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afiseazaContracteToolStripMenuItem.Text = "Afiseaza grafic ";
            this.afiseazaContracteToolStripMenuItem.Click += new System.EventHandler(this.afiseazaContracteToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printDocumentCosToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printDocumentCosToolStripMenuItem
            // 
            this.printDocumentCosToolStripMenuItem.Name = "printDocumentCosToolStripMenuItem";
            this.printDocumentCosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printDocumentCosToolStripMenuItem.Text = "Print Document Cos";
            this.printDocumentCosToolStripMenuItem.Click += new System.EventHandler(this.printDocumentCosToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 53);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lvMateriale
            // 
            this.lvMateriale.AllowDrop = true;
            this.lvMateriale.CheckBoxes = true;
            this.lvMateriale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Furnizor,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMateriale.FullRowSelect = true;
            this.lvMateriale.GridLines = true;
            this.lvMateriale.HideSelection = false;
            this.lvMateriale.Location = new System.Drawing.Point(27, 144);
            this.lvMateriale.Name = "lvMateriale";
            this.lvMateriale.Size = new System.Drawing.Size(481, 241);
            this.lvMateriale.TabIndex = 31;
            this.lvMateriale.UseCompatibleStateImageBehavior = false;
            this.lvMateriale.View = System.Windows.Forms.View.Details;
            this.lvMateriale.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvMateriale_ItemDrag);
            // 
            // Furnizor
            // 
            this.Furnizor.Text = "Furnizor";
            this.Furnizor.Width = 108;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Material";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantitate";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pret";
            this.columnHeader3.Width = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Produse Comandate";
            // 
            // Consola
            // 
            this.Consola.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Consola.Location = new System.Drawing.Point(0, 433);
            this.Consola.Multiline = true;
            this.Consola.Name = "Consola";
            this.Consola.ReadOnly = true;
            this.Consola.Size = new System.Drawing.Size(1047, 108);
            this.Consola.TabIndex = 33;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lvLivrate
            // 
            this.lvLivrate.AllowDrop = true;
            this.lvLivrate.CheckBoxes = true;
            this.lvLivrate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvLivrate.FullRowSelect = true;
            this.lvLivrate.GridLines = true;
            this.lvLivrate.HideSelection = false;
            this.lvLivrate.Location = new System.Drawing.Point(536, 144);
            this.lvLivrate.Name = "lvLivrate";
            this.lvLivrate.Size = new System.Drawing.Size(481, 241);
            this.lvLivrate.TabIndex = 34;
            this.lvLivrate.UseCompatibleStateImageBehavior = false;
            this.lvLivrate.View = System.Windows.Forms.View.Details;
            this.lvLivrate.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvLivrate_DragDrop);
            this.lvLivrate.DragOver += new System.Windows.Forms.DragEventHandler(this.lvLivrate_DragOver);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Furnizor";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Material";
            this.columnHeader5.Width = 136;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cantitate";
            this.columnHeader6.Width = 109;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pret";
            this.columnHeader7.Width = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Produse Livrate";
            // 
            // inseturiBazaDeDateToolStripMenuItem
            // 
            this.inseturiBazaDeDateToolStripMenuItem.Name = "inseturiBazaDeDateToolStripMenuItem";
            this.inseturiBazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inseturiBazaDeDateToolStripMenuItem.Text = "Baza de date";
            this.inseturiBazaDeDateToolStripMenuItem.Click += new System.EventHandler(this.inseturiBazaDeDateToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvLivrate);
            this.Controls.Add(this.Consola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMateriale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvMateriale;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Consola;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaCosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaContracteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Furnizor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDocumentCosToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListView lvLivrate;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inseturiBazaDeDateToolStripMenuItem;
    }
}