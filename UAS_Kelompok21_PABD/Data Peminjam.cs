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
        public Data_Peminjam()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridView();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Peminjam";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM Peminjam WHERE nama_peminjam= @nama_peminjam";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_peminjam", tbxID.Text);

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
