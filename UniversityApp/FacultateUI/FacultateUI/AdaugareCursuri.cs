using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace FacultateUI
{
    public partial class AdaugareCursuri : Form
    {
        public AdaugareCursuri()
        {
            InitializeComponent();
        }
        private void AdaugareCursuri_Load(object sender, EventArgs e)
        {
            
                Global.connection = new SqlConnection(Global.strConectare);
                Global.dataSet = new DataSet();

                string strSelect = "select * from tCursuri";
                Global.dataAdapter= new SqlDataAdapter(strSelect, Global.connection);
                Global.dataAdapter.Fill(Global.dataSet, "tCursuri");
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private bool ExistaNumeCurs()
        {
            foreach (DataRow dataRow in Global.dataSet.Tables["tCursuri"].Rows)
            {
                if (dataRow["NumeCurs"].Equals(txtNumeCurs.Text))
                    return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodCurs.Text))
                MessageBox.Show("Introduceti codul cursului");
            else if (string.IsNullOrEmpty(txtNumeCurs.Text) || ExistaNumeCurs())
                MessageBox.Show("Nume Curs neintrodus sau existent");
            else if (String.IsNullOrEmpty(txtNrCredite.Text)||!IsDigits(txtNrCredite.Text))
                MessageBox.Show("Introduceti nr de credite al cursului sau format incorect");
            else
            {
                DataTable table = Global.dataSet.Tables["tCursuri"];

                DataRow row = table.NewRow();
                row["CodCurs"] = txtCodCurs.Text;
                row["NumeCurs"] = txtNumeCurs.Text;
                row["NrCredite"] = txtNrCredite.Text;

                table.Rows.Add(row);

                string strInsert = "insert into tCursuri values ('" +
                    txtCodCurs.Text + "','" + txtNumeCurs.Text + "','" + txtNrCredite.Text + "')";

                SqlCommand cmd = new SqlCommand(strInsert, Global.connection);

                //folosire SqlDataAdapter
                Global.dataAdapter.InsertCommand = cmd;
                Global.dataAdapter.Update(table);
                Global.dataSet.AcceptChanges();


                //Global.con.Open();
                //cmd.ExecuteNonQuery();
                //Global.con.Close();


                txtCodCurs.Text = "";
                txtNumeCurs.Text = "";
                txtNrCredite.Text = "";
                this.Hide();
            
                MessageBox.Show("Curs adaugat cu succes!");
                DashboardAdmin admin = new DashboardAdmin();
                admin.ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Global.dataSet.Tables["tCursuri"].WriteXml(ConfigurationManager.AppSettings["Path"]);
            MessageBox.Show("Xml creat cu succes!");
        }
    }


    
}
