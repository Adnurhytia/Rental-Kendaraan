namespace UAS_Kelompok21_PABD
{
    partial class Persyaratan
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
            this.cbxIdPeminjam = new System.Windows.Forms.ComboBox();
            this.cbxJenis = new System.Windows.Forms.ComboBox();
            this.tbxIDPersyaratan = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(413, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Persyaratan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Peminjam";
            // 
            // cbxIdPeminjam
            // 
            this.cbxIdPeminjam.FormattingEnabled = true;
            this.cbxIdPeminjam.Location = new System.Drawing.Point(667, 201);
            this.cbxIdPeminjam.Name = "cbxIdPeminjam";
            this.cbxIdPeminjam.Size = new System.Drawing.Size(89, 28);
            this.cbxIdPeminjam.TabIndex = 4;
            // 
            // cbxJenis
            // 
            this.cbxJenis.FormattingEnabled = true;
            this.cbxJenis.Items.AddRange(new object[] {
            "KTP",
            "Identitas Pribadi"});
            this.cbxJenis.Location = new System.Drawing.Point(667, 164);
            this.cbxJenis.Name = "cbxJenis";
            this.cbxJenis.Size = new System.Drawing.Size(89, 28);
            this.cbxJenis.TabIndex = 5;
            // 
            // tbxIDPersyaratan
            // 
            this.tbxIDPersyaratan.Location = new System.Drawing.Point(667, 124);
            this.tbxIDPersyaratan.Name = "tbxIDPersyaratan";
            this.tbxIDPersyaratan.Size = new System.Drawing.Size(130, 26);
            this.tbxIDPersyaratan.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(469, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(566, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Persyaratan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxIDPersyaratan);
            this.Controls.Add(this.cbxJenis);
            this.Controls.Add(this.cbxIdPeminjam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Persyaratan";
            this.Text = "Persyaratan";
            this.Load += new System.EventHandler(this.Persyaratan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxIdPeminjam;
        private System.Windows.Forms.ComboBox cbxJenis;
        private System.Windows.Forms.TextBox tbxIDPersyaratan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
    }
}