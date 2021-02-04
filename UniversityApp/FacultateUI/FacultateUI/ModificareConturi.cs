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
namespace FacultateUI
{
    public partial class ModificareConturi : Form
    {
        public ModificareConturi()
        {
            InitializeComponent();
        }
        private void ModificareConturi_Load(object sender, EventArgs e)
        {
            Global.connection = new SqlConnection(Global.strConectare);
            Global.dataSet = new DataSet();

            string strSelect = "select * from tConturi";
            Global.dataAdapter = new SqlDataAdapter(strSelect, Global.connection);
            Global.dataAdapter.Fill(Global.dataSet, "tConturi");
            dataGridView1.DataSource = Global.dataSet;
            dataGridView1.DataMember = "tConturi";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(Global.dataAdapter);
            DataSet dsChange = Global.dataSet.GetChanges();
            if (dsChange != null)
            {
                Global.dataAdapter.Update(dsChange, "tConturi");
                Global.dataSet.AcceptChanges();
            }
        
            MessageBox.Show("Modificare efectuata cu succes!");
            this.Hide();
            DashboardAdmin admin = new DashboardAdmin();
            admin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.dataSet.RejectChanges();
            MessageBox.Show("Anulare realizata cu succes!");
            this.Hide();
            DashboardAdmin admin = new DashboardAdmin();
            admin.ShowDialog();
        }
    }
}
