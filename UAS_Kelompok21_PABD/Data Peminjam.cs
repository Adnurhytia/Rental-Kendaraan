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
            koneksi.Open();
            string str = "select Id_Peminjam from dbo.Peminjam";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void Data_Peminjam_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxBoxID.Enabled = true;
            btnSave.Enabled=true;
            btnDelete.Enabled=true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idPeminjam = tbxBoxID.Text;
            string nmPeminjam = tbxBoxNama.Text;
            string jlPeminjam = tbxJalan.Text;
            string ktPeminjam = tbxKota.Text;
            string prPeminjam = tbxProvinsi.Text;

            if (idPeminjam == "")
            {
                MessageBox.Show("Masukkan ID Peminjam", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Peminjam (id_peminjam,nama_peminjam,jalan_peminjam,kota_peminjam,provinsi_peminjam)" + "values(@id_peminjam,@nama_peminjam,@jalan_peminjam,@kota_peminjam,@provinsi_peminjam)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_peminjam", idPeminjam));
                cmd.Parameters.Add(new SqlParameter("nama_peminjam", nmPeminjam));
                cmd.Parameters.Add(new SqlParameter("jalan_peminjam", jlPeminjam));
                cmd.Parameters.Add(new SqlParameter("kota_peminjam", ktPeminjam));
                cmd.Parameters.Add(new SqlParameter("provinsi_peminjam", prPeminjam));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
        private void Data_Peminjam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fu = new Form1();
            fu.Show();
            this.Hide();
        }
    }
}
