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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPeminjam_Click(object sender, EventArgs e)
        {
            Data_Peminjam peminjam = new Data_Peminjam();
            peminjam.TopLevel = false;
            peminjam.FormBorderStyle = FormBorderStyle.None;
            peminjam.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(peminjam);

            peminjam.Show();
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            Data_Pegawai pegawai = new Data_Pegawai();
            pegawai.TopLevel = false;
            pegawai.FormBorderStyle = FormBorderStyle.None;
            pegawai.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(pegawai);

            pegawai.Show();
        }

        private void buttonKendaraan_Click(object sender, EventArgs e)
        {
            Data_Kendaraan kendaraan = new Data_Kendaraan();
            kendaraan.TopLevel = false;
            kendaraan.FormBorderStyle = FormBorderStyle.None;
            kendaraan.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(kendaraan);

            kendaraan.Show();
        }

        private void buttonRental_Click(object sender, EventArgs e)
        {
            Data_Rental rental = new Data_Rental();
            rental.TopLevel = false;
            rental.FormBorderStyle = FormBorderStyle.None;
            rental.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(rental);

            rental.Show();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            Data_Transaksi transaksi = new Data_Transaksi();
            transaksi.TopLevel = false;
            transaksi.FormBorderStyle = FormBorderStyle.None;
            transaksi.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(transaksi);

            transaksi.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History_Transaksi history = new History_Transaksi();
            history.TopLevel = false;
            history.FormBorderStyle = FormBorderStyle.None;
            history.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(history);

            history.Show();
        }

        private void btnPersyaratan_Click(object sender, EventArgs e)
        {
            Persyaratan persyaratan = new Persyaratan();
            persyaratan.TopLevel = false;
            persyaratan.FormBorderStyle = FormBorderStyle.None;
            persyaratan.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(persyaratan);

            persyaratan.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
