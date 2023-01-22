namespace LerafSchoolManage.UserControls
{
    partial class UC_Jurusan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Jurusan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HapusBtn = new System.Windows.Forms.Button();
            this.UbahBtn = new System.Windows.Forms.Button();
            this.TambahBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KetTb = new System.Windows.Forms.TextBox();
            this.JurNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.JurusanList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JurusanList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.HapusBtn);
            this.panel1.Controls.Add(this.UbahBtn);
            this.panel1.Controls.Add(this.TambahBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.KetTb);
            this.panel1.Controls.Add(this.JurNameTb);
            this.panel1.Location = new System.Drawing.Point(34, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 632);
            this.panel1.TabIndex = 10;
            // 
            // HapusBtn
            // 
            this.HapusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HapusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HapusBtn.FlatAppearance.BorderSize = 0;
            this.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HapusBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HapusBtn.ForeColor = System.Drawing.Color.White;
            this.HapusBtn.Location = new System.Drawing.Point(34, 583);
            this.HapusBtn.Name = "HapusBtn";
            this.HapusBtn.Size = new System.Drawing.Size(235, 27);
            this.HapusBtn.TabIndex = 16;
            this.HapusBtn.Text = "Hapus";
            this.HapusBtn.UseVisualStyleBackColor = false;
            // 
            // UbahBtn
            // 
            this.UbahBtn.BackColor = System.Drawing.Color.DimGray;
            this.UbahBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UbahBtn.FlatAppearance.BorderSize = 0;
            this.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UbahBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UbahBtn.ForeColor = System.Drawing.Color.White;
            this.UbahBtn.Location = new System.Drawing.Point(158, 540);
            this.UbahBtn.Name = "UbahBtn";
            this.UbahBtn.Size = new System.Drawing.Size(111, 27);
            this.UbahBtn.TabIndex = 15;
            this.UbahBtn.Text = "Ubah";
            this.UbahBtn.UseVisualStyleBackColor = false;
            this.UbahBtn.Click += new System.EventHandler(this.UbahBtn_Click);
            // 
            // TambahBtn
            // 
            this.TambahBtn.BackColor = System.Drawing.Color.Silver;
            this.TambahBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TambahBtn.FlatAppearance.BorderSize = 0;
            this.TambahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TambahBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahBtn.ForeColor = System.Drawing.Color.White;
            this.TambahBtn.Location = new System.Drawing.Point(34, 540);
            this.TambahBtn.Name = "TambahBtn";
            this.TambahBtn.Size = new System.Drawing.Size(111, 27);
            this.TambahBtn.TabIndex = 14;
            this.TambahBtn.Text = "Tambah";
            this.TambahBtn.UseVisualStyleBackColor = false;
            this.TambahBtn.Click += new System.EventHandler(this.TambahBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tambah/Ubah/Hapus Jurusan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Keterangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama jurusan";
            // 
            // KetTb
            // 
            this.KetTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetTb.Location = new System.Drawing.Point(34, 201);
            this.KetTb.Name = "KetTb";
            this.KetTb.Size = new System.Drawing.Size(235, 27);
            this.KetTb.TabIndex = 1;
            // 
            // JurNameTb
            // 
            this.JurNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JurNameTb.Location = new System.Drawing.Point(34, 133);
            this.JurNameTb.Name = "JurNameTb";
            this.JurNameTb.Size = new System.Drawing.Size(235, 27);
            this.JurNameTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mengelola Jurusan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1137, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // JurusanList
            // 
            this.JurusanList.AllowUserToAddRows = false;
            this.JurusanList.AllowUserToDeleteRows = false;
            this.JurusanList.AllowUserToOrderColumns = true;
            this.JurusanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JurusanList.BackgroundColor = System.Drawing.Color.White;
            this.JurusanList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JurusanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JurusanList.Location = new System.Drawing.Point(0, 0);
            this.JurusanList.Name = "JurusanList";
            this.JurusanList.ReadOnly = true;
            this.JurusanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.JurusanList.Size = new System.Drawing.Size(775, 632);
            this.JurusanList.TabIndex = 0;
            this.JurusanList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JurusanList_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.JurusanList);
            this.panel2.Location = new System.Drawing.Point(361, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 632);
            this.panel2.TabIndex = 11;
            // 
            // UC_Jurusan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Jurusan";
            this.Size = new System.Drawing.Size(1173, 800);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JurusanList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HapusBtn;
        private System.Windows.Forms.Button UbahBtn;
        private System.Windows.Forms.Button TambahBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox JurNameTb;
        private System.Windows.Forms.TextBox KetTb;
        private System.Windows.Forms.DataGridView JurusanList;
        private System.Windows.Forms.Panel panel2;
    }
}
