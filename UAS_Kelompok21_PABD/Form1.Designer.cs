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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPeminjam = new System.Windows.Forms.Button();
            this.buttonKendaraan = new System.Windows.Forms.Button();
            this.buttonRental = new System.Windows.Forms.Button();
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.buttonPegawai = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toko Rental Kendaraan Semua Ada";
            // 
            // buttonPeminjam
            // 
            this.buttonPeminjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonPeminjam.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPeminjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPeminjam.Location = new System.Drawing.Point(35, 105);
            this.buttonPeminjam.Name = "buttonPeminjam";
            this.buttonPeminjam.Size = new System.Drawing.Size(174, 100);
            this.buttonPeminjam.TabIndex = 2;
            this.buttonPeminjam.Text = "Data Peminjam";
            this.buttonPeminjam.UseVisualStyleBackColor = false;
            this.buttonPeminjam.Click += new System.EventHandler(this.buttonPeminjam_Click);
            // 
            // buttonKendaraan
            // 
            this.buttonKendaraan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonKendaraan.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.buttonKendaraan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKendaraan.Location = new System.Drawing.Point(317, 211);
            this.buttonKendaraan.Name = "buttonKendaraan";
            this.buttonKendaraan.Size = new System.Drawing.Size(174, 97);
            this.buttonKendaraan.TabIndex = 4;
            this.buttonKendaraan.Text = "Data Kendaraan";
            this.buttonKendaraan.UseVisualStyleBackColor = false;
            this.buttonKendaraan.Click += new System.EventHandler(this.buttonKendaraan_Click);
            // 
            // buttonRental
            // 
            this.buttonRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRental.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.buttonRental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRental.Location = new System.Drawing.Point(582, 108);
            this.buttonRental.Name = "buttonRental";
            this.buttonRental.Size = new System.Drawing.Size(174, 97);
            this.buttonRental.TabIndex = 6;
            this.buttonRental.Text = "Data Rental";
            this.buttonRental.UseVisualStyleBackColor = false;
            this.buttonRental.Click += new System.EventHandler(this.buttonRental_Click);
            // 
            // buttonTransaksi
            // 
            this.buttonTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonTransaksi.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.buttonTransaksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTransaksi.Location = new System.Drawing.Point(35, 208);
            this.buttonTransaksi.Name = "buttonTransaksi";
            this.buttonTransaksi.Size = new System.Drawing.Size(174, 93);
            this.buttonTransaksi.TabIndex = 7;
            this.buttonTransaksi.Text = "Data Transaksi";
            this.buttonTransaksi.UseVisualStyleBackColor = false;
            this.buttonTransaksi.Click += new System.EventHandler(this.buttonTransaksi_Click);
            // 
            // buttonPegawai
            // 
            this.buttonPegawai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonPegawai.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.buttonPegawai.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPegawai.Location = new System.Drawing.Point(317, 105);
            this.buttonPegawai.Name = "buttonPegawai";
            this.buttonPegawai.Size = new System.Drawing.Size(174, 97);
            this.buttonPegawai.TabIndex = 8;
            this.buttonPegawai.Text = "Data Pegawai";
            this.buttonPegawai.UseVisualStyleBackColor = false;
            this.buttonPegawai.Click += new System.EventHandler(this.buttonPegawai_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistory.Location = new System.Drawing.Point(582, 211);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(174, 97);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Text = "History Transaksi";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.buttonPegawai);
            this.Controls.Add(this.buttonTransaksi);
            this.Controls.Add(this.buttonRental);
            this.Controls.Add(this.buttonKendaraan);
            this.Controls.Add(this.buttonPeminjam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPeminjam;
        private System.Windows.Forms.Button buttonKendaraan;
        private System.Windows.Forms.Button buttonRental;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Button buttonPegawai;
        private System.Windows.Forms.Button btnHistory;
    }
}

