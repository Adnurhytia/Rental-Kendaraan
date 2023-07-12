﻿using System;
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
    public partial class Persyaratan : Form
    {
        private string stringConnection = "Data Source=DESKTOP-4IT269M\\ADINDANURHAYATI;Initial Catalog=Peminjaman_Kendaraan;User ID=sa;Password=3007dinda";
        private SqlConnection koneksi;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public Persyaratan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridView();
            LoadRentalData();
        }

        private void Persyaratan_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Persyaratan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void LoadRentalData()
        {
            try
            {
                koneksi.Open();

                string str = "SELECT id_peminjam FROM Peminjam";
                command = new SqlCommand(str, koneksi);
                DataTable rentalTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(rentalTable);

                cbxIdPeminjam.DisplayMember = "id_peminjam";
                cbxIdPeminjam.ValueMember = "id_peminjam";

                cbxIdPeminjam.DataSource = rentalTable;
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            string idPersyaratan = tbxIDPersyaratan.Text;
            string jenis = cbxJenis.Text;
            string idPeminjam = cbxIdPeminjam.Text;

            if (idPersyaratan == "")
            {
                MessageBox.Show("Masukkan ID Persyaratan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Persyaratan(id_persyaratan,jenis_persyaratan,id_peminjam)" + "values(@id_persyaratan,@jenis_persyaratan,@id_peminjam)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_persyaratan", idPersyaratan));
                cmd.Parameters.Add(new SqlParameter("jenis_persyaratan", jenis));
                cmd.Parameters.Add(new SqlParameter("id_peminjam", idPeminjam));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxIdPeminjam.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}
