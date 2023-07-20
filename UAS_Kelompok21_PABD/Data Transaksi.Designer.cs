namespace UAS_Kelompok21_PABD
{
    partial class Data_Transaksi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbxCustomer = new System.Windows.Forms.TextBox();
            this.txbJalan = new System.Windows.Forms.TextBox();
            this.cbxMetode = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxKendaraan = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbProvinsi = new System.Windows.Forms.TextBox();
            this.txbKota = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxPersyaratan = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_platNomer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.lbl_jalan = new System.Windows.Forms.Label();
            this.lbl_kota = new System.Windows.Forms.Label();
            this.lbl_provinsi = new System.Windows.Forms.Label();
            this.lbl_kendaraan = new System.Windows.Forms.Label();
            this.lbl_platnmr = new System.Windows.Forms.Label();
            this.lbl_persyaratan = new System.Windows.Forms.Label();
            this.lbl_metode = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Metode Pembayaran";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kendaraan";
            // 
            // txbxCustomer
            // 
            this.txbxCustomer.Location = new System.Drawing.Point(354, 25);
            this.txbxCustomer.Name = "txbxCustomer";
            this.txbxCustomer.Size = new System.Drawing.Size(247, 26);
            this.txbxCustomer.TabIndex = 7;
            this.txbxCustomer.TextChanged += new System.EventHandler(this.txbxCustomer_TextChanged);
            // 
            // txbJalan
            // 
            this.txbJalan.Location = new System.Drawing.Point(486, 70);
            this.txbJalan.Name = "txbJalan";
            this.txbJalan.Size = new System.Drawing.Size(115, 26);
            this.txbJalan.TabIndex = 8;
            this.txbJalan.TextChanged += new System.EventHandler(this.txbxAlamat_TextChanged);
            // 
            // cbxMetode
            // 
            this.cbxMetode.FormattingEnabled = true;
            this.cbxMetode.Items.AddRange(new object[] {
            "Cash",
            "Debit",
            "E-money"});
            this.cbxMetode.Location = new System.Drawing.Point(354, 247);
            this.cbxMetode.Name = "cbxMetode";
            this.cbxMetode.Size = new System.Drawing.Size(249, 28);
            this.cbxMetode.TabIndex = 9;
            this.cbxMetode.SelectedIndexChanged += new System.EventHandler(this.cbxMetode_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(526, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(408, 463);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 43);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxKendaraan
            // 
            this.cbxKendaraan.FormattingEnabled = true;
            this.cbxKendaraan.Items.AddRange(new object[] {
            "Mobil",
            "Motor"});
            this.cbxKendaraan.Location = new System.Drawing.Point(354, 113);
            this.cbxKendaraan.Name = "cbxKendaraan";
            this.cbxKendaraan.Size = new System.Drawing.Size(247, 28);
            this.cbxKendaraan.TabIndex = 17;
            this.cbxKendaraan.SelectedIndexChanged += new System.EventHandler(this.cbxKendaraan_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(410, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 43);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rage Italic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 61);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data Transaksi";
            // 
            // txbProvinsi
            // 
            this.txbProvinsi.Location = new System.Drawing.Point(615, 70);
            this.txbProvinsi.Name = "txbProvinsi";
            this.txbProvinsi.Size = new System.Drawing.Size(108, 26);
            this.txbProvinsi.TabIndex = 37;
            // 
            // txbKota
            // 
            this.txbKota.Location = new System.Drawing.Point(354, 70);
            this.txbKota.Name = "txbKota";
            this.txbKota.Size = new System.Drawing.Size(115, 26);
            this.txbKota.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 31);
            this.label14.TabIndex = 39;
            this.label14.Text = "Total Harga";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(354, 293);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(249, 26);
            this.txbTotal.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1131, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 37);
            this.label16.TabIndex = 46;
            this.label16.Text = "Invoice";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.cbxPersyaratan);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbx_platNomer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbxCustomer);
            this.panel2.Controls.Add(this.txbJalan);
            this.panel2.Controls.Add(this.cbxMetode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbTotal);
            this.panel2.Controls.Add(this.cbxKendaraan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txbProvinsi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txbKota);
            this.panel2.Location = new System.Drawing.Point(56, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 365);
            this.panel2.TabIndex = 47;
            // 
            // cbxPersyaratan
            // 
            this.cbxPersyaratan.FormattingEnabled = true;
            this.cbxPersyaratan.Location = new System.Drawing.Point(352, 197);
            this.cbxPersyaratan.Name = "cbxPersyaratan";
            this.cbxPersyaratan.Size = new System.Drawing.Size(252, 28);
            this.cbxPersyaratan.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 31);
            this.label17.TabIndex = 43;
            this.label17.Text = "Persyaratan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 42;
            this.label6.Text = "Plat Nomor";
            // 
            // txbx_platNomer
            // 
            this.txbx_platNomer.Location = new System.Drawing.Point(352, 156);
            this.txbx_platNomer.Name = "txbx_platNomer";
            this.txbx_platNomer.Size = new System.Drawing.Size(247, 26);
            this.txbx_platNomer.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.lbl_metode);
            this.panel1.Controls.Add(this.lbl_persyaratan);
            this.panel1.Controls.Add(this.lbl_platnmr);
            this.panel1.Controls.Add(this.lbl_kendaraan);
            this.panel1.Controls.Add(this.lbl_provinsi);
            this.panel1.Controls.Add(this.lbl_kota);
            this.panel1.Controls.Add(this.lbl_jalan);
            this.panel1.Controls.Add(this.lbl_customer);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(964, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 418);
            this.panel1.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Alamat :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 31);
            this.label9.TabIndex = 4;
            this.label9.Text = "Kendaraan :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "Plat Nomor  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 31);
            this.label11.TabIndex = 6;
            this.label11.Text = "Persyaratan  :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(266, 31);
            this.label12.TabIndex = 7;
            this.label12.Text = "Metode Pembayaran :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 31);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Harga :";
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.Location = new System.Drawing.Point(144, 15);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(117, 24);
            this.lbl_customer.TabIndex = 9;
            this.lbl_customer.Text = "txtCustomer";
            // 
            // lbl_jalan
            // 
            this.lbl_jalan.AutoSize = true;
            this.lbl_jalan.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_jalan.Location = new System.Drawing.Point(117, 63);
            this.lbl_jalan.Name = "lbl_jalan";
            this.lbl_jalan.Size = new System.Drawing.Size(76, 24);
            this.lbl_jalan.TabIndex = 10;
            this.lbl_jalan.Text = "txtJalan";
            // 
            // lbl_kota
            // 
            this.lbl_kota.AutoSize = true;
            this.lbl_kota.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_kota.Location = new System.Drawing.Point(117, 102);
            this.lbl_kota.Name = "lbl_kota";
            this.lbl_kota.Size = new System.Drawing.Size(74, 24);
            this.lbl_kota.TabIndex = 11;
            this.lbl_kota.Text = "txtKota";
            // 
            // lbl_provinsi
            // 
            this.lbl_provinsi.AutoSize = true;
            this.lbl_provinsi.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_provinsi.Location = new System.Drawing.Point(117, 140);
            this.lbl_provinsi.Name = "lbl_provinsi";
            this.lbl_provinsi.Size = new System.Drawing.Size(102, 24);
            this.lbl_provinsi.TabIndex = 12;
            this.lbl_provinsi.Text = "txtProvinsi";
            // 
            // lbl_kendaraan
            // 
            this.lbl_kendaraan.AutoSize = true;
            this.lbl_kendaraan.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_kendaraan.Location = new System.Drawing.Point(155, 194);
            this.lbl_kendaraan.Name = "lbl_kendaraan";
            this.lbl_kendaraan.Size = new System.Drawing.Size(126, 24);
            this.lbl_kendaraan.TabIndex = 13;
            this.lbl_kendaraan.Text = "txtKendaraan";
            // 
            // lbl_platnmr
            // 
            this.lbl_platnmr.AutoSize = true;
            this.lbl_platnmr.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_platnmr.Location = new System.Drawing.Point(173, 242);
            this.lbl_platnmr.Name = "lbl_platnmr";
            this.lbl_platnmr.Size = new System.Drawing.Size(101, 24);
            this.lbl_platnmr.TabIndex = 14;
            this.lbl_platnmr.Text = "txtPlatnmr";
            // 
            // lbl_persyaratan
            // 
            this.lbl_persyaratan.AutoSize = true;
            this.lbl_persyaratan.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_persyaratan.Location = new System.Drawing.Point(178, 288);
            this.lbl_persyaratan.Name = "lbl_persyaratan";
            this.lbl_persyaratan.Size = new System.Drawing.Size(134, 24);
            this.lbl_persyaratan.TabIndex = 15;
            this.lbl_persyaratan.Text = "txtPersyaratan";
            // 
            // lbl_metode
            // 
            this.lbl_metode.AutoSize = true;
            this.lbl_metode.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_metode.Location = new System.Drawing.Point(275, 329);
            this.lbl_metode.Name = "lbl_metode";
            this.lbl_metode.Size = new System.Drawing.Size(102, 24);
            this.lbl_metode.TabIndex = 16;
            this.lbl_metode.Text = "txtMetode";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_total.Location = new System.Drawing.Point(168, 372);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(77, 24);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "txtTotal";
            // 
            // Data_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1450, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Name = "Data_Transaksi";
            this.Text = "Data_Transaksi";
            this.Load += new System.EventHandler(this.Data_Transaksi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbxCustomer;
        private System.Windows.Forms.TextBox txbJalan;
        private System.Windows.Forms.ComboBox cbxMetode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbxKendaraan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbProvinsi;
        private System.Windows.Forms.TextBox txbKota;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_platNomer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxPersyaratan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_jalan;
        private System.Windows.Forms.Label lbl_metode;
        private System.Windows.Forms.Label lbl_persyaratan;
        private System.Windows.Forms.Label lbl_platnmr;
        private System.Windows.Forms.Label lbl_kendaraan;
        private System.Windows.Forms.Label lbl_provinsi;
        private System.Windows.Forms.Label lbl_kota;
        private System.Windows.Forms.Label lbl_total;
    }
}