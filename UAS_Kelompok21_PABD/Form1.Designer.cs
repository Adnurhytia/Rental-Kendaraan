namespace UAS_Kelompok21_PABD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataPeminjamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKendaraanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPeminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPersyaratanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toko Rental Semua Ada";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPeminjamToolStripMenuItem,
            this.dataPegawaiToolStripMenuItem,
            this.dataRentalToolStripMenuItem,
            this.dataKendaraanToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem,
            this.dataPeminjamanToolStripMenuItem,
            this.dataPersyaratanToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Thistle;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(75, 29);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // dataPeminjamToolStripMenuItem
            // 
            this.dataPeminjamToolStripMenuItem.Name = "dataPeminjamToolStripMenuItem";
            this.dataPeminjamToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataPeminjamToolStripMenuItem.Text = "Data Peminjam";
            this.dataPeminjamToolStripMenuItem.Click += new System.EventHandler(this.dataPeminjamToolStripMenuItem_Click);
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            // 
            // dataRentalToolStripMenuItem
            // 
            this.dataRentalToolStripMenuItem.Name = "dataRentalToolStripMenuItem";
            this.dataRentalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataRentalToolStripMenuItem.Text = "Data Rental";
            // 
            // dataKendaraanToolStripMenuItem
            // 
            this.dataKendaraanToolStripMenuItem.Name = "dataKendaraanToolStripMenuItem";
            this.dataKendaraanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataKendaraanToolStripMenuItem.Text = "Data Kendaraan";
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            // 
            // dataPeminjamanToolStripMenuItem
            // 
            this.dataPeminjamanToolStripMenuItem.Name = "dataPeminjamanToolStripMenuItem";
            this.dataPeminjamanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataPeminjamanToolStripMenuItem.Text = "Data Peminjaman";
            // 
            // dataPersyaratanToolStripMenuItem
            // 
            this.dataPersyaratanToolStripMenuItem.Name = "dataPersyaratanToolStripMenuItem";
            this.dataPersyaratanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataPersyaratanToolStripMenuItem.Text = "Data Persyaratan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataPeminjamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKendaraanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPeminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPersyaratanToolStripMenuItem;
    }
}

