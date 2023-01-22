namespace LerafSchoolManage.UserControls
{
    partial class UC_Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Students));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HapusBtn = new System.Windows.Forms.Button();
            this.UbahBtn = new System.Windows.Forms.Button();
            this.TambahBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StJurCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StJkCb = new System.Windows.Forms.ComboBox();
            this.StPhoneTb = new System.Windows.Forms.TextBox();
            this.StNamaTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MuridList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MuridList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mengelola Murid";
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
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.HapusBtn);
            this.panel1.Controls.Add(this.UbahBtn);
            this.panel1.Controls.Add(this.TambahBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.StJurCb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.StJkCb);
            this.panel1.Controls.Add(this.StPhoneTb);
            this.panel1.Controls.Add(this.StNamaTb);
            this.panel1.Location = new System.Drawing.Point(34, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 632);
            this.panel1.TabIndex = 7;
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
            this.HapusBtn.TabIndex = 19;
            this.HapusBtn.Text = "Hapus";
            this.HapusBtn.UseVisualStyleBackColor = false;
            this.HapusBtn.Click += new System.EventHandler(this.HapusBtn_Click);
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
            this.UbahBtn.TabIndex = 18;
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
            this.TambahBtn.TabIndex = 17;
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
            this.label6.Size = new System.Drawing.Size(189, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tambah/Ubah/Hapus Murid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jurusan";
            // 
            // StJurCb
            // 
            this.StJurCb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StJurCb.FormattingEnabled = true;
            this.StJurCb.Location = new System.Drawing.Point(34, 335);
            this.StJurCb.Name = "StJurCb";
            this.StJurCb.Size = new System.Drawing.Size(235, 28);
            this.StJurCb.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "No. Telp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jenis kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama";
            // 
            // StJkCb
            // 
            this.StJkCb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StJkCb.FormattingEnabled = true;
            this.StJkCb.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.StJkCb.Location = new System.Drawing.Point(34, 200);
            this.StJkCb.Name = "StJkCb";
            this.StJkCb.Size = new System.Drawing.Size(235, 28);
            this.StJkCb.TabIndex = 2;
            // 
            // StPhoneTb
            // 
            this.StPhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StPhoneTb.Location = new System.Drawing.Point(34, 268);
            this.StPhoneTb.Name = "StPhoneTb";
            this.StPhoneTb.Size = new System.Drawing.Size(235, 27);
            this.StPhoneTb.TabIndex = 1;
            // 
            // StNamaTb
            // 
            this.StNamaTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StNamaTb.Location = new System.Drawing.Point(34, 133);
            this.StNamaTb.Name = "StNamaTb";
            this.StNamaTb.Size = new System.Drawing.Size(235, 27);
            this.StNamaTb.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.MuridList);
            this.panel2.Location = new System.Drawing.Point(361, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 632);
            this.panel2.TabIndex = 8;
            // 
            // MuridList
            // 
            this.MuridList.AllowUserToAddRows = false;
            this.MuridList.AllowUserToDeleteRows = false;
            this.MuridList.AllowUserToOrderColumns = true;
            this.MuridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MuridList.BackgroundColor = System.Drawing.Color.White;
            this.MuridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MuridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MuridList.Location = new System.Drawing.Point(0, 0);
            this.MuridList.Name = "MuridList";
            this.MuridList.ReadOnly = true;
            this.MuridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MuridList.Size = new System.Drawing.Size(775, 632);
            this.MuridList.TabIndex = 1;
            this.MuridList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MuridList_CellContentClick);
            // 
            // UC_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Students";
            this.Size = new System.Drawing.Size(1173, 800);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MuridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox StJkCb;
        private System.Windows.Forms.TextBox StPhoneTb;
        private System.Windows.Forms.TextBox StNamaTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StJurCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HapusBtn;
        private System.Windows.Forms.Button UbahBtn;
        private System.Windows.Forms.Button TambahBtn;
        private System.Windows.Forms.DataGridView MuridList;
    }
}
