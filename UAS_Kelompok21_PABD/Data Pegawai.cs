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
    public partial class Data_Pegawai : Form
    {
        private string stringConnection = "Data Source=DESKTOP-4IT269M\\ADINDANURHAYATI;Initial Catalog=Peminjaman_Kendaraan;User ID=sa;Password=3007dinda";
        private SqlConnection koneksi;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public Data_Pegawai()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
            LoadRentalData();
        }
        private void refreshform()
        {
            tbxNama.Text = "";
            tbxID.Text = "";
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Hide();
        }

        private void Data_Pegawai_Load(object sender, EventArgs e)
        {

        }

        private void tbxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Pegawai";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxID.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = "UPDATE Pegawai SET id_pegawai= @id_pegawai,nama_pegawai = @nama_pegawai WHERE id_rental= @id_rental";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pegawai", tbxID.Text);
                    cmd.Parameters.AddWithValue("@nama_pegawai", tbxNama.Text);
                    cmd.Parameters.AddWithValue("@id_rental", cbxIdRental.Text);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idPegawai = tbxID.Text;
            string nmPegawai = tbxNama.Text;
            string idRental = cbxIdRental.Text;

            if (idPegawai == "")
            {
                MessageBox.Show("Masukkan ID Pegawai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Pegawai(id_pegawai,nama_pegawai,id_rental)" + "values(@id_pegawai,@nama_pegawai,@id_rental)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_pegawai", idPegawai));
                cmd.Parameters.Add(new SqlParameter("nama_pegawai", nmPegawai));
                cmd.Parameters.Add(new SqlParameter("id_rental", idRental));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void cbxIdRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

                cbxIdRental.DisplayMember = "id_rental";
                cbxIdRental.ValueMember = "id_rental";

                cbxIdRental.DataSource = rentalTable;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Pegawai WHERE id_pegawai = @id_pegawai";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pegawai", tbxDelete.Text);

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
    }
}
