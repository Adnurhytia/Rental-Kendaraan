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
    public partial class Data_Rental : Form
    {
        private string stringConnection = "Data Source=DESKTOP-4IT269M\\ADINDANURHAYATI;Initial Catalog=Peminjaman_Kendaraan;User ID=sa;Password=3007dinda";
        private SqlConnection koneksi;
        public Data_Rental()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
        }
        
        private void refreshform()
        {
            tbxIDRental.Text = "";
            tbxNamaRental.Text = "";
            tbxProvinsiRental.Text = "";
            tbxKotaRental.Text = "";
            tbxJalanRental.Text = "";
            tbxIDRental.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Rental";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string idRental = tbxIDRental.Text;
            string nmRental = tbxNamaRental.Text;
            string jlRental = tbxJalanRental.Text;
            string ktRental = tbxKotaRental.Text;
            string prRental = tbxProvinsiRental.Text;

            if (idRental == "")
            {
                MessageBox.Show("Masukkan ID Rental", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Rental (id_rental,nama_rental,jalan_rental,kota_rental,provinsi_rental)" + "values(@id_rental,@nama_rental,@jalan_rental,@kota_rental,@provinsi_rental)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_rental", idRental));
                cmd.Parameters.Add(new SqlParameter("nama_rental", nmRental));
                cmd.Parameters.Add(new SqlParameter("jalan_rental", jlRental));
                cmd.Parameters.Add(new SqlParameter("kota_rental", ktRental));
                cmd.Parameters.Add(new SqlParameter("provinsi_rental", prRental));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void Data_Rental_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxIDRental.Enabled = true;
            tbxNamaRental.Enabled = true;
            tbxJalanRental.Enabled=true;
            tbxKotaRental.Enabled=true;
            tbxProvinsiRental.Enabled=true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Rental WHERE id_rental = @id_rental";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@id_rental", tbxDelete.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        dataGridView();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void tbxDelete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
