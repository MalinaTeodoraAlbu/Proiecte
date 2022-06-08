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
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }
        DataSet dsComanda = new DataSet();

        private void DataBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlDataAdapter1.Update(dsComanda);
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dsComanda);
            dataGridView1.DataSource = dsComanda;
            dataGridView1.DataMember = dsComanda.Tables[0].TableName;
        }
    }
}
