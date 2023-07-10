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
    public partial class Data_Peminjaman : Form
    {
        private string stringConnection = "Data Source=DESKTOP-4IT269M\\ADINDANURHAYATI;Initial Catalog=Peminjaman_Kendaraan;User ID=sa;Password=3007dinda";
        private SqlConnection koneksi;
        public Data_Peminjaman()
        {
            InitializeComponent();
        }
        private void refreshform()
        {

        }
        private void cbIdPeminjam()
        {
            koneksi.Open();
            string str = "SELECT id_peminjam FROM Peminjam";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxIdPeminjam.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();
        }

        private void Data_Peminjaman_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxIdPeminjam.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxIdPeminjam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedID = cbxIdPeminjam.SelectedItem.ToString();


            koneksi.Open();
            string str = "SELECT id_rental FROM Rental WHERE id_peminjam = @id_peminjam";
            SqlCommand cm = new SqlCommand(str, koneksi);
            cm.Parameters.AddWithValue("@id_peminjam", selectedID);
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                string id_rental = dr.GetString(0);
                txtIdRental.Text = id_rental;
            }
            else
            {
                txtIdRental.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }
    }
}
