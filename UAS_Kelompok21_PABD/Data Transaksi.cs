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
            Kendaraan();
            Persyaratan();
            cbxKendaraan.SelectedIndexChanged += cbxKendaraan_SelectedIndexChanged;
        }

        private void Data_Transaksi_Load(object sender, EventArgs e)
        {

        }
        private void refreshform()
        {
            txbxCustomer.Text = "";
            txbJalan.Text = "";
            cbxMetode.Text = "";
            cbxKendaraan.Text = "";
            txbxCustomer.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txbxCustomer.Enabled = true;
            btnSave.Enabled = true;
            txbx_platNomer.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idTransaksi = Guid.NewGuid().ToString().Substring(0, 5);
            string tHarga = txbTotal.Text;
            string mPembayaran = cbxMetode.Text;
            string idPeminjam = Guid.NewGuid().ToString().Substring(0, 5);
            string nama = txbxCustomer.Text;
            string jalan = txbJalan.Text;
            string kota = txbKota.Text;
            string provinsi = txbProvinsi.Text;
            string kendaraan = cbxKendaraan.Text;
            string pltnmr = txbx_platNomer.Text;

            string persyaratan = string.Empty;
            if (cbxPersyaratan.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cbxPersyaratan.SelectedItem;
                persyaratan = selectedRow["id_persyaratan"].ToString();
            }

            if (idPeminjam == "")
            {
                MessageBox.Show("Masukkan ID Peminjam", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Peminjam (id_peminjam, nama_peminjam, jalan_peminjam, kota_peminjam, provinsi_peminjam)" +
                             "values (@id_peminjam, @nama_peminjam, @jalan_peminjam, @kota_peminjam, @provinsi_peminjam)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_peminjam", idPeminjam));
                cmd.Parameters.Add(new SqlParameter("nama_peminjam", nama));
                cmd.Parameters.Add(new SqlParameter("jalan_peminjam", jalan));
                cmd.Parameters.Add(new SqlParameter("kota_peminjam", kota));
                cmd.Parameters.Add(new SqlParameter("provinsi_peminjam", provinsi));
                cmd.ExecuteNonQuery();

                string sti = "INSERT INTO dbo.Transaksi (id_transaksi, total_harga, metode_pembayaran, id_peminjam, plat_nmr, id_persyaratan)" +
                             "VALUES (@id_transaksi, @total_harga, @metode_pembayaran, @id_peminjam, @plat_nmr, @id_persyaratan)";
                SqlCommand cm = new SqlCommand(sti, koneksi);
                cm.CommandType = CommandType.Text;
                cm.Parameters.Add(new SqlParameter("id_transaksi", idTransaksi));
                cm.Parameters.Add(new SqlParameter("total_harga", tHarga));
                cm.Parameters.Add(new SqlParameter("metode_pembayaran", mPembayaran));
                cm.Parameters.Add(new SqlParameter("id_peminjam", idPeminjam));
                cm.Parameters.Add(new SqlParameter("plat_nmr", txbx_platNomer.Text));
                cm.Parameters.Add(new SqlParameter("id_persyaratan", persyaratan)); // Use SelectedValue to get the selected value
                cm.ExecuteNonQuery();

                // Update the status of the selected vehicle to "dipinjam"
                string updateStatusQuery = "UPDATE Kendaraan SET status = 'Dipinjam' WHERE plat_nmr = @plat_nmr";
                SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, koneksi);
                updateStatusCommand.Parameters.Add(new SqlParameter("plat_nmr", txbx_platNomer.Text));
                updateStatusCommand.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshform();
            }

            lbl_customer.Text = nama;
            lbl_jalan.Text = jalan;
            lbl_plat.Text = kota;
            lbl_provinsi.Text = provinsi;
            lbl_kendaraan.Text = kendaraan;
            lbl_plat.Text = pltnmr;
            lbl_bayar.Text = mPembayaran;
            lbl_total.Text = tHarga;
            lbl_persyaratan.Text = persyaratan;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void Persyaratan()
        {
            try
            {
                koneksi.Open();

                string str = "SELECT jenis_persyaratan, id_persyaratan FROM Persyaratan";
                command = new SqlCommand(str, koneksi);
                DataTable nomorTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(nomorTable);

                cbxPersyaratan.DisplayMember = "jenis_persyaratan";
                cbxPersyaratan.ValueMember = "id_persyaratan"; // Set the ValueMember to the appropriate column name

                cbxPersyaratan.DataSource = nomorTable;
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

        private void Kendaraan()
        {
            try
            {
                koneksi.Open();

                string str = "SELECT plat_nmr, jenis_kendaraan FROM Kendaraan WHERE status = 'tersedia'";
                command = new SqlCommand(str, koneksi);
                DataTable nomorTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(nomorTable);

                cbxKendaraan.DisplayMember = "jenis_kendaraan";
                cbxKendaraan.ValueMember = "plat_nmr"; // Set the ValueMember to the appropriate column name

                cbxKendaraan.DataSource = nomorTable;
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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxMetode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbDenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxKendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKendaraan.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cbxKendaraan.SelectedItem;
                string platNmr = selectedRow["plat_nmr"].ToString();
                txbx_platNomer.Text = platNmr;
            }
        }


        private void cbxPlatNomor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
