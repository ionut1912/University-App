using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultateUI
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareCursuri adaugare = new AdaugareCursuri();
            adaugare.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareNote note = new AdaugareNote();
            note.ShowDialog();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareProfesori profesori = new AdaugareProfesori();
            profesori.ShowDialog();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareStudenti studenti = new AdaugareStudenti();
            studenti.ShowDialog();
        }

      

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            this.Hide();
            StergereConturi conturi = new StergereConturi();
            conturi.ShowDialog();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificareConturi cont = new ModificareConturi();
             cont.ShowDialog();
        }
    }
}
