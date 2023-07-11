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
            Plat_Nomor();
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
            txbDenda.Text = "";
            cbxPlatNomor.Text = "";
            txbxCustomer.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txbxCustomer.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idTransaksi = txbxCustomer.Text;
            string tHarga = txbTotal.Text;
            string mPembayaran = cbxMetode.Text;
            string idPeminjam = Guid.NewGuid().ToString().Substring(0, 5);
            string denda = txbDenda.Text;
            string pltNmr = cbxPlatNomor.Text;
            string nama = txbxCustomer.Text;
            string jalan = txbJalan.Text;
            string kota = txbKota.Text;
            string provinsi = txbProvinsi.Text;
            string kendaraan = cbxKendaraan.Text;

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

                string sti = "insert into dbo.Transaksi (id_transaksi, total_harga, metode_pembayaran, denda, id_peminjam, plat_nmr)" +
                             "values (@id_transaksi, @total_harga, @metode_pembayaran, @denda, @id_peminjam, @plat_nmr)";
                SqlCommand cm = new SqlCommand(sti, koneksi);
                cm.CommandType = CommandType.Text;
                cm.Parameters.Add(new SqlParameter("id_transaksi", idTransaksi));
                cm.Parameters.Add(new SqlParameter("total_harga", tHarga));
                cm.Parameters.Add(new SqlParameter("metode_pembayaran", mPembayaran));
                cm.Parameters.Add(new SqlParameter("denda", denda)); // Use 'denda' instead of 'kota'
                cm.Parameters.Add(new SqlParameter("id_peminjam", idPeminjam));
                cm.Parameters.Add(new SqlParameter("plat_nmr", pltNmr));
                cm.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshform();
            }

            data1.Text = nama;
            data2.Text = jalan;
            data3.Text = kendaraan;
            data4.Text = pltNmr;
            data5.Text = mPembayaran;
            data6.Text = denda;
            data7.Text = tHarga;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void Plat_Nomor()
        {
            try
            {
                koneksi.Open();

                string str = "SELECT plat_nmr FROM Kendaraan";
                command = new SqlCommand(str, koneksi);
                DataTable nomorTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(nomorTable);

                cbxPlatNomor.DisplayMember = "plat_nmr";
                cbxPlatNomor.ValueMember = "plat_nmr";

                cbxPlatNomor.DataSource = nomorTable;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
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

        }

        private void cbxPlatNomor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
