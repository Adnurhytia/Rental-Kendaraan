using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Windows.Input;

namespace UAS_Kelompok21_PABD
{
    public partial class Data_Peminjam : Form
    {
        private string stringConnection = "Data Source=DESKTOP-4IT269M\\ADINDANURHAYATI;Initial Catalog=Peminjaman_Kendaraan;User ID=sa;Password=3007dinda";
        private SqlConnection koneksi;

        private void refreshform()
        {
            tbxBoxID.Text = "";
            tbxBoxNama.Text = "";
            tbxBoxID.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        public Data_Peminjam()
        {
            
        }
        private void dataGridView()
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void Data_Peminjam_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
        }
        private void Data_Peminjam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fu = new Form1();
            fu.Show();
            this.Hide();
        }
    }
}
