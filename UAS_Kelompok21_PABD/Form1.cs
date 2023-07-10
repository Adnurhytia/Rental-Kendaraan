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
            Data_Peminjam dpe = new Data_Peminjam();
            dpe.Show();
            this.Hide();
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {

        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            Data_Pegawai dpg = new Data_Pegawai();
            dpg.Show();
            this.Hide();
        }

        private void buttonKendaraan_Click(object sender, EventArgs e)
        {
            Data_Kendaraan dk = new Data_Kendaraan();
            dk.Show();
            this.Hide();
        }

        private void buttonPersyaratan_Click(object sender, EventArgs e)
        {
            Data_Persyaratan dpr = new Data_Persyaratan();
            dpr.Show();
            this.Hide();
        }

        private void buttonRental_Click(object sender, EventArgs e)
        {
            Data_Rental dr = new Data_Rental();
            dr.Show();
            this.Hide();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            Data_Transaksi dtr = new Data_Transaksi();
            dtr.Show();
            this.Hide();
        }
    }
}
