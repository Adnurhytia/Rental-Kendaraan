namespace UAS_Kelompok21_PABD
{
    partial class Data_Rental
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxIDRental = new System.Windows.Forms.TextBox();
            this.tbxNamaRental = new System.Windows.Forms.TextBox();
            this.jalanRental = new System.Windows.Forms.TextBox();
            this.kotaRental = new System.Windows.Forms.TextBox();
            this.provinsiRental = new System.Windows.Forms.TextBox();
            this.cbxIDPegawai = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(732, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Rental";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Rental";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Pegawai";
            // 
            // tbxIDRental
            // 
            this.tbxIDRental.Location = new System.Drawing.Point(379, 316);
            this.tbxIDRental.Name = "tbxIDRental";
            this.tbxIDRental.Size = new System.Drawing.Size(141, 26);
            this.tbxIDRental.TabIndex = 6;
            // 
            // tbxNamaRental
            // 
            this.tbxNamaRental.Location = new System.Drawing.Point(380, 361);
            this.tbxNamaRental.Name = "tbxNamaRental";
            this.tbxNamaRental.Size = new System.Drawing.Size(211, 26);
            this.tbxNamaRental.TabIndex = 7;
            // 
            // jalanRental
            // 
            this.jalanRental.Location = new System.Drawing.Point(380, 401);
            this.jalanRental.Name = "jalanRental";
            this.jalanRental.Size = new System.Drawing.Size(127, 26);
            this.jalanRental.TabIndex = 8;
            // 
            // kotaRental
            // 
            this.kotaRental.Location = new System.Drawing.Point(513, 401);
            this.kotaRental.Name = "kotaRental";
            this.kotaRental.Size = new System.Drawing.Size(127, 26);
            this.kotaRental.TabIndex = 9;
            // 
            // provinsiRental
            // 
            this.provinsiRental.Location = new System.Drawing.Point(646, 401);
            this.provinsiRental.Name = "provinsiRental";
            this.provinsiRental.Size = new System.Drawing.Size(127, 26);
            this.provinsiRental.TabIndex = 10;
            // 
            // cbxIDPegawai
            // 
            this.cbxIDPegawai.FormattingEnabled = true;
            this.cbxIDPegawai.Location = new System.Drawing.Point(380, 445);
            this.cbxIDPegawai.Name = "cbxIDPegawai";
            this.cbxIDPegawai.Size = new System.Drawing.Size(140, 28);
            this.cbxIDPegawai.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(810, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 43);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(810, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 31);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Data_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(919, 499);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxIDPegawai);
            this.Controls.Add(this.provinsiRental);
            this.Controls.Add(this.kotaRental);
            this.Controls.Add(this.jalanRental);
            this.Controls.Add(this.tbxNamaRental);
            this.Controls.Add(this.tbxIDRental);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data_Rental";
            this.Text = "Data_Rental";
            this.Load += new System.EventHandler(this.Data_Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxIDRental;
        private System.Windows.Forms.TextBox tbxNamaRental;
        private System.Windows.Forms.TextBox jalanRental;
        private System.Windows.Forms.TextBox kotaRental;
        private System.Windows.Forms.TextBox provinsiRental;
        private System.Windows.Forms.ComboBox cbxIDPegawai;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}