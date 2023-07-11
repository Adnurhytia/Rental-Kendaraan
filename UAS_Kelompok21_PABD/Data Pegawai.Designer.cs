namespace UAS_Kelompok21_PABD
{
    partial class Data_Pegawai
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
            this.tbxNama = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxIdRental = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 22F);
            this.label1.Location = new System.Drawing.Point(671, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pegawai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Pegawai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Pegawai";
            // 
            // tbxNama
            // 
            this.tbxNama.Location = new System.Drawing.Point(966, 178);
            this.tbxNama.Name = "tbxNama";
            this.tbxNama.Size = new System.Drawing.Size(279, 26);
            this.tbxNama.TabIndex = 3;
            this.tbxNama.TextChanged += new System.EventHandler(this.tbxNama_TextChanged);
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(966, 224);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(279, 26);
            this.tbxID.TabIndex = 4;
            this.tbxID.TextChanged += new System.EventHandler(this.tbxID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Moccasin;
            this.btnAdd.Location = new System.Drawing.Point(966, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(189, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(460, 251);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OldLace;
            this.btnSave.Location = new System.Drawing.Point(1083, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.Location = new System.Drawing.Point(966, 312);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 38);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCyan;
            this.btnClear.Location = new System.Drawing.Point(1083, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxIdRental
            // 
            this.cbxIdRental.FormattingEnabled = true;
            this.cbxIdRental.Location = new System.Drawing.Point(966, 131);
            this.cbxIdRental.Name = "cbxIdRental";
            this.cbxIdRental.Size = new System.Drawing.Size(140, 28);
            this.cbxIdRental.TabIndex = 14;
            this.cbxIdRental.SelectedIndexChanged += new System.EventHandler(this.cbxIdRental_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID Rental";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Location = new System.Drawing.Point(1222, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 57);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "DeletebyIDPegawai";
            // 
            // tbxDelete
            // 
            this.tbxDelete.Location = new System.Drawing.Point(966, 364);
            this.tbxDelete.Name = "tbxDelete";
            this.tbxDelete.Size = new System.Drawing.Size(111, 26);
            this.tbxDelete.TabIndex = 17;
            // 
            // Data_Pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1517, 520);
            this.Controls.Add(this.tbxDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxIdRental);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.tbxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Data_Pegawai";
            this.Text = "Data_Pegawai";
            this.Load += new System.EventHandler(this.Data_Pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNama;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbxIdRental;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDelete;
    }
}