
namespace Proiect_Paw_Albu_Teodora_Malina
{
    partial class Form3
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
            this.tbPret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Anuleaza = new System.Windows.Forms.Button();
            this.comboMateriale = new System.Windows.Forms.ComboBox();
            this.comboFurnizor = new System.Windows.Forms.ComboBox();
            this.Adauga = new System.Windows.Forms.Button();
            this.Finalizeaza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericCantitate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consola_add = new System.Windows.Forms.TextBox();
            this.IDtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(24, 351);
            this.tbPret.Name = "tbPret";
            this.tbPret.ReadOnly = true;
            this.tbPret.Size = new System.Drawing.Size(66, 22);
            this.tbPret.TabIndex = 20;
            this.tbPret.TextChanged += new System.EventHandler(this.tbPret_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pret";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Anuleaza
            // 
            this.Anuleaza.BackColor = System.Drawing.Color.Thistle;
            this.Anuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Anuleaza.Location = new System.Drawing.Point(324, 375);
            this.Anuleaza.Name = "Anuleaza";
            this.Anuleaza.Size = new System.Drawing.Size(126, 47);
            this.Anuleaza.TabIndex = 23;
            this.Anuleaza.Text = "Anuleaza";
            this.Anuleaza.UseVisualStyleBackColor = false;
            this.Anuleaza.Click += new System.EventHandler(this.Anuleaza_Click);
            // 
            // comboMateriale
            // 
            this.comboMateriale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMateriale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboMateriale.FormattingEnabled = true;
            this.comboMateriale.Location = new System.Drawing.Point(24, 227);
            this.comboMateriale.Name = "comboMateriale";
            this.comboMateriale.Size = new System.Drawing.Size(126, 24);
            this.comboMateriale.TabIndex = 18;
            this.comboMateriale.SelectedIndexChanged += new System.EventHandler(this.comboMateriale_SelectedIndexChanged);
            // 
            // comboFurnizor
            // 
            this.comboFurnizor.BackColor = System.Drawing.Color.White;
            this.comboFurnizor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFurnizor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboFurnizor.ForeColor = System.Drawing.Color.Black;
            this.comboFurnizor.FormattingEnabled = true;
            this.comboFurnizor.Location = new System.Drawing.Point(24, 152);
            this.comboFurnizor.Name = "comboFurnizor";
            this.comboFurnizor.Size = new System.Drawing.Size(126, 24);
            this.comboFurnizor.TabIndex = 17;
            this.comboFurnizor.SelectedIndexChanged += new System.EventHandler(this.comboFurnizor_SelectedIndexChanged);
            // 
            // Adauga
            // 
            this.Adauga.BackColor = System.Drawing.Color.Thistle;
            this.Adauga.Location = new System.Drawing.Point(324, 266);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(126, 47);
            this.Adauga.TabIndex = 21;
            this.Adauga.Text = "Adauga Materiale";
            this.Adauga.UseVisualStyleBackColor = false;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // Finalizeaza
            // 
            this.Finalizeaza.BackColor = System.Drawing.Color.Thistle;
            this.Finalizeaza.Location = new System.Drawing.Point(489, 375);
            this.Finalizeaza.Name = "Finalizeaza";
            this.Finalizeaza.Size = new System.Drawing.Size(126, 47);
            this.Finalizeaza.TabIndex = 25;
            this.Finalizeaza.Text = "Finalizeaza";
            this.Finalizeaza.UseVisualStyleBackColor = false;
            this.Finalizeaza.Click += new System.EventHandler(this.Finalizeaza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cantitatea";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Alege Material";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Alege furnizor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericCantitate
            // 
            this.numericCantitate.Location = new System.Drawing.Point(24, 291);
            this.numericCantitate.Name = "numericCantitate";
            this.numericCantitate.Size = new System.Drawing.Size(78, 22);
            this.numericCantitate.TabIndex = 28;
            this.numericCantitate.TextChanged += new System.EventHandler(this.numericCantitate_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 50);
            this.panel1.TabIndex = 29;
            // 
            // consola_add
            // 
            this.consola_add.Location = new System.Drawing.Point(311, 87);
            this.consola_add.Multiline = true;
            this.consola_add.Name = "consola_add";
            this.consola_add.Size = new System.Drawing.Size(376, 129);
            this.consola_add.TabIndex = 30;
            // 
            // IDtb
            // 
            this.IDtb.Location = new System.Drawing.Point(46, 71);
            this.IDtb.Name = "IDtb";
            this.IDtb.Size = new System.Drawing.Size(47, 22);
            this.IDtb.TabIndex = 31;
            this.IDtb.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Id";
            this.label5.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDtb);
            this.Controls.Add(this.consola_add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericCantitate);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Anuleaza);
            this.Controls.Add(this.comboMateriale);
            this.Controls.Add(this.comboFurnizor);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.Finalizeaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbPret;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button Anuleaza;
        public System.Windows.Forms.ComboBox comboMateriale;
        public System.Windows.Forms.ComboBox comboFurnizor;
        public System.Windows.Forms.Button Adauga;
        public System.Windows.Forms.Button Finalizeaza;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox numericCantitate;
        private System.Windows.Forms.TextBox consola_add;
        public System.Windows.Forms.TextBox IDtb;
        public System.Windows.Forms.Label label5;
    }
}