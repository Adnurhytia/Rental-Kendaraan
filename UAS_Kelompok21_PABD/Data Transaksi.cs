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
    public partial class Data_Transaksi : Form
    {
        private string stringConnection = "Data Source=DESKTOP-4IT269M\\ADINDANURHAYATI;Initial Catalog=Peminjaman_Kendaraan;User ID=sa;Password=3007dinda";
        private SqlConnection koneksi;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public Data_Transaksi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
            LoadPeminjamData();
        }

        private void Data_Transaksi_Load(object sender, EventArgs e)
        {

        }
        private void refreshform()
        {
            tbxIdTransaksi.Text = "";
            tbxTotalHarga.Text = "";
            cbxMetode.Text = "";
            cbxIDPeminjam.Text = "";
            txbDenda.Text = "";
            cbxPlatNmr.Text = "";
            tbxIdTransaksi.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxIdTransaksi.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Transaksi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Transaksi WHERE id_transaksi = @id_transaksi";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@id_peminjam", tbxDelete.Text);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idTransaksi = tbxIdTransaksi.Text;
            string tHarga = tbxTotalHarga.Text;
            string mPembayaran = cbxMetode.Text;
            string idPeminjam = cbxIDPeminjam.Text;
            string denda = txbDenda.Text;
            string pltNmr = cbxPlatNmr.Text;

            if (idTransaksi == "")
            {
                MessageBox.Show("Masukkan ID Transaksi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Transaksi (id_transaksi,total_harga,metode_pembayaran,denda,id_peminjam,plat_nmr)" + "values(@id_transaksi,@total_harga,@metode_pembayaran,@denda,@id_peminjam,plat_nmr)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_transaksi", idTransaksi));
                cmd.Parameters.Add(new SqlParameter("total_harga", tHarga));
                cmd.Parameters.Add(new SqlParameter("metode_pembayaran", mPembayaran));
                cmd.Parameters.Add(new SqlParameter("id_peminjam", idPeminjam));
                cmd.Parameters.Add(new SqlParameter("denda", denda));
                cmd.Parameters.Add(new SqlParameter("plat_nmr", pltNmr));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = "UPDATE Transaksi SET id_transaksi = @id_transaksi,total_harga=  @total_harga,metode_pembayaran= @metode_pembayaran,denda= @denda,id_peminjam= @id_peminjam,plat_nmr= @plat_nmr WHERE id_transaksi = @id_transaksi";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@id_transaksi", tbxIdTransaksi.Text);
                    cmd.Parameters.AddWithValue("@total_harga", tbxTotalHarga.Text);
                    cmd.Parameters.AddWithValue("@metode_pembayaran", cbxMetode.Text);
                    cmd.Parameters.AddWithValue("@denda", txbDenda.Text);
                    cmd.Parameters.AddWithValue("@id_peminjam", cbxIDPeminjam.Text);
                    cmd.Parameters.AddWithValue("@plat_nmr", cbxPlatNmr.Text);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void LoadPeminjamData()
        {
            try
            {
                koneksi.Open();

                string str = "SELECT id_peminjam FROM Peminjam";
                command = new SqlCommand(str, koneksi);
                DataTable peminjamTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(peminjamTable);

                cbxIDPeminjam.DisplayMember = "id_peminjam";
                cbxIDPeminjam.ValueMember = "id_peminjam";

                cbxIDPeminjam.DataSource = peminjamTable;
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
    }
}
