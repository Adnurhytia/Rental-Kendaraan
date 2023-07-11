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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbxCustomer = new System.Windows.Forms.TextBox();
            this.txbJalan = new System.Windows.Forms.TextBox();
            this.cbxMetode = new System.Windows.Forms.ComboBox();
            this.txbDenda = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxKendaraan = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPlatNomor = new System.Windows.Forms.ComboBox();
            this.data2 = new System.Windows.Forms.TextBox();
            this.data1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.data3 = new System.Windows.Forms.TextBox();
            this.data4 = new System.Windows.Forms.TextBox();
            this.data5 = new System.Windows.Forms.TextBox();
            this.data6 = new System.Windows.Forms.TextBox();
            this.txbProvinsi = new System.Windows.Forms.TextBox();
            this.txbKota = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.data7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Metode Pembayaran";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Denda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kendaraan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Plat Nmr";
            // 
            // txbxCustomer
            // 
            this.txbxCustomer.Location = new System.Drawing.Point(349, 82);
            this.txbxCustomer.Name = "txbxCustomer";
            this.txbxCustomer.Size = new System.Drawing.Size(224, 26);
            this.txbxCustomer.TabIndex = 7;
            this.txbxCustomer.TextChanged += new System.EventHandler(this.txbxCustomer_TextChanged);
            // 
            // txbJalan
            // 
            this.txbJalan.Location = new System.Drawing.Point(349, 127);
            this.txbJalan.Name = "txbJalan";
            this.txbJalan.Size = new System.Drawing.Size(93, 26);
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
            this.cbxMetode.Location = new System.Drawing.Point(347, 265);
            this.cbxMetode.Name = "cbxMetode";
            this.cbxMetode.Size = new System.Drawing.Size(156, 28);
            this.cbxMetode.TabIndex = 9;
            this.cbxMetode.SelectedIndexChanged += new System.EventHandler(this.cbxMetode_SelectedIndexChanged);
            // 
            // txbDenda
            // 
            this.txbDenda.Location = new System.Drawing.Point(347, 309);
            this.txbDenda.Name = "txbDenda";
            this.txbDenda.Size = new System.Drawing.Size(156, 26);
            this.txbDenda.TabIndex = 12;
            this.txbDenda.TextChanged += new System.EventHandler(this.txbDenda_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(347, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(347, 449);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxKendaraan
            // 
            this.cbxKendaraan.FormattingEnabled = true;
            this.cbxKendaraan.Items.AddRange(new object[] {
            "Mobil",
            "Motor"});
            this.cbxKendaraan.Location = new System.Drawing.Point(349, 170);
            this.cbxKendaraan.Name = "cbxKendaraan";
            this.cbxKendaraan.Size = new System.Drawing.Size(156, 28);
            this.cbxKendaraan.TabIndex = 17;
            this.cbxKendaraan.SelectedIndexChanged += new System.EventHandler(this.cbxKendaraan_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(622, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(14, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 28);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rage Italic", 22F);
            this.label8.Location = new System.Drawing.Point(486, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 55);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data Transaksi";
            // 
            // cbxPlatNomor
            // 
            this.cbxPlatNomor.FormattingEnabled = true;
            this.cbxPlatNomor.Location = new System.Drawing.Point(349, 217);
            this.cbxPlatNomor.Name = "cbxPlatNomor";
            this.cbxPlatNomor.Size = new System.Drawing.Size(156, 28);
            this.cbxPlatNomor.TabIndex = 24;
            this.cbxPlatNomor.SelectedIndexChanged += new System.EventHandler(this.cbxPlatNomor_SelectedIndexChanged);
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(1014, 127);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(224, 26);
            this.data2.TabIndex = 32;
            // 
            // data1
            // 
            this.data1.Location = new System.Drawing.Point(1014, 82);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(224, 26);
            this.data1.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(700, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "Plat Nmr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(701, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 31);
            this.label9.TabIndex = 29;
            this.label9.Text = "Kendaraan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(698, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 31);
            this.label10.TabIndex = 28;
            this.label10.Text = "Denda";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(698, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 31);
            this.label11.TabIndex = 27;
            this.label11.Text = "Metode Pembayaran";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(700, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 31);
            this.label12.TabIndex = 26;
            this.label12.Text = "Alamat";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(700, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 31);
            this.label13.TabIndex = 25;
            this.label13.Text = "Customer";
            // 
            // data3
            // 
            this.data3.Location = new System.Drawing.Point(1014, 172);
            this.data3.Name = "data3";
            this.data3.Size = new System.Drawing.Size(224, 26);
            this.data3.TabIndex = 33;
            // 
            // data4
            // 
            this.data4.Location = new System.Drawing.Point(1014, 217);
            this.data4.Name = "data4";
            this.data4.Size = new System.Drawing.Size(224, 26);
            this.data4.TabIndex = 34;
            // 
            // data5
            // 
            this.data5.Location = new System.Drawing.Point(1014, 267);
            this.data5.Name = "data5";
            this.data5.Size = new System.Drawing.Size(224, 26);
            this.data5.TabIndex = 35;
            // 
            // data6
            // 
            this.data6.Location = new System.Drawing.Point(1014, 309);
            this.data6.Name = "data6";
            this.data6.Size = new System.Drawing.Size(224, 26);
            this.data6.TabIndex = 36;
            // 
            // txbProvinsi
            // 
            this.txbProvinsi.Location = new System.Drawing.Point(579, 127);
            this.txbProvinsi.Name = "txbProvinsi";
            this.txbProvinsi.Size = new System.Drawing.Size(100, 26);
            this.txbProvinsi.TabIndex = 37;
            // 
            // txbKota
            // 
            this.txbKota.Location = new System.Drawing.Point(458, 127);
            this.txbKota.Name = "txbKota";
            this.txbKota.Size = new System.Drawing.Size(115, 26);
            this.txbKota.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 31);
            this.label14.TabIndex = 39;
            this.label14.Text = "Total Harga";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(347, 352);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(156, 26);
            this.txbTotal.TabIndex = 40;
            // 
            // data7
            // 
            this.data7.Location = new System.Drawing.Point(1014, 353);
            this.data7.Name = "data7";
            this.data7.Size = new System.Drawing.Size(224, 26);
            this.data7.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(702, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 31);
            this.label15.TabIndex = 41;
            this.label15.Text = "Total Harga";
            // 
            // Data_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1470, 535);
            this.Controls.Add(this.data7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbKota);
            this.Controls.Add(this.txbProvinsi);
            this.Controls.Add(this.data6);
            this.Controls.Add(this.data5);
            this.Controls.Add(this.data4);
            this.Controls.Add(this.data3);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxPlatNomor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxKendaraan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbDenda);
            this.Controls.Add(this.cbxMetode);
            this.Controls.Add(this.txbJalan);
            this.Controls.Add(this.txbxCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Data_Transaksi";
            this.Text = "Data_Transaksi";
            this.Load += new System.EventHandler(this.Data_Transaksi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbxCustomer;
        private System.Windows.Forms.TextBox txbJalan;
        private System.Windows.Forms.ComboBox cbxMetode;
        private System.Windows.Forms.TextBox txbDenda;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbxKendaraan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxPlatNomor;
        private System.Windows.Forms.TextBox data2;
        private System.Windows.Forms.TextBox data1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox data3;
        private System.Windows.Forms.TextBox data4;
        private System.Windows.Forms.TextBox data5;
        private System.Windows.Forms.TextBox data6;
        private System.Windows.Forms.TextBox txbProvinsi;
        private System.Windows.Forms.TextBox txbKota;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox data7;
        private System.Windows.Forms.Label label15;
    }
}