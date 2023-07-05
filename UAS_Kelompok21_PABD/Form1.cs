using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_Kelompok21_PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataPeminjamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Peminjam dpe = new Data_Peminjam();
            dpe.Show();
            this.Hide();
        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Pegawai dpg = new Data_Pegawai();
            dpg.Show();
            this.Hide();
        }
    }
}
