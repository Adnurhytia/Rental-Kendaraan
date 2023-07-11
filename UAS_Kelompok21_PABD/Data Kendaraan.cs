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
    public partial class Data_Kendaraan : Form
    {
        private string stringConnection = "Data Source=DESKTOP-4IT269M\\ADINDANURHAYATI;Initial Catalog=Peminjaman_Kendaraan;User ID=sa;Password=3007dinda";
        private SqlConnection koneksi;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        private void refreshform()
        {
            cbxIDRental.Text = "";
            tbxPlatNmr.Text = "";
            tbxJenis.Text = "";
            tbxHargaSewa.Text = "";
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }
        public Data_Kendaraan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
            LoadRentalData();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Kendaraan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Data_Kendaraan_Load(object sender, EventArgs e)
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
            cbxIDRental.Enabled = true;
            tbxPlatNmr.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = "UPDATE Kendaraan SET plat_nmr= @plat_nmr,jenis_kendaraan= @jenis_kendaraan,harga_sewa= @harga_sewa";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@plat_nmr", tbxPlatNmr.Text);
                    cmd.Parameters.AddWithValue("@jenis_kendaraan", tbxJenis.Text);
                    cmd.Parameters.AddWithValue("@harga_sewa", tbxHargaSewa.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil di Updated");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Kendaraan WHERE plat_nmr = @plat_nmr";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@plat_nmr", tbxDelete.Text);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string jnsKendaraan = tbxJenis.Text;
            string pltNomor = tbxPlatNmr.Text;
            string idRental = cbxIDRental.Text;
            string hrgSewa = tbxHargaSewa.Text;

            if (pltNomor == "")
            {
                MessageBox.Show("Masukkan Plat Nomor Kendaraan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Kendaraan(id_rental,plat_nmr,jenis_kendaraan,harga_sewa)" + "values(@id_rental,@plat_nmr,@jenis_kendaraan,@harga_sewa)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_rental", idRental));
                cmd.Parameters.Add(new SqlParameter("plat_nmr", pltNomor));
                cmd.Parameters.Add(new SqlParameter("jenis_kendaraan", jnsKendaraan));
                cmd.Parameters.Add(new SqlParameter("harga_sewa", hrgSewa));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
        private void LoadRentalData()
        {
            try
            {
                koneksi.Open();

                string str = "SELECT id_rental FROM Rental";
                command = new SqlCommand(str, koneksi);
                DataTable rentalTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(rentalTable);

                cbxIDRental.DisplayMember = "id_rental";
                cbxIDRental.ValueMember = "id_rental";

                cbxIDRental.DataSource = rentalTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void cbxJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
