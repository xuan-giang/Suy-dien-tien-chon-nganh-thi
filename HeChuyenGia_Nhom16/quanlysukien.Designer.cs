namespace HeChuyenGia_Nhom2
{
    partial class quanlysukien
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
            this.datasukien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmask = new System.Windows.Forms.TextBox();
            this.txtmotask = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiSK = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datasukien)).BeginInit();
            this.SuspendLayout();
            // 
            // datasukien
            // 
            this.datasukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasukien.Location = new System.Drawing.Point(589, 398);
            this.datasukien.Margin = new System.Windows.Forms.Padding(4);
            this.datasukien.Name = "datasukien";
            this.datasukien.RowHeadersWidth = 51;
            this.datasukien.Size = new System.Drawing.Size(608, 227);
            this.datasukien.TabIndex = 0;
            this.datasukien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasukien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(690, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sự kiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // txtmask
            // 
            this.txtmask.BackColor = System.Drawing.Color.White;
            this.txtmask.Location = new System.Drawing.Point(851, 58);
            this.txtmask.Margin = new System.Windows.Forms.Padding(4);
            this.txtmask.Name = "txtmask";
            this.txtmask.Size = new System.Drawing.Size(227, 22);
            this.txtmask.TabIndex = 3;
            // 
            // txtmotask
            // 
            this.txtmotask.BackColor = System.Drawing.Color.White;
            this.txtmotask.Location = new System.Drawing.Point(851, 103);
            this.txtmotask.Margin = new System.Windows.Forms.Padding(5);
            this.txtmotask.Multiline = true;
            this.txtmotask.Name = "txtmotask";
            this.txtmotask.Size = new System.Drawing.Size(227, 78);
            this.txtmotask.TabIndex = 4;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.White;
            this.btnthem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Location = new System.Drawing.Point(1006, 303);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 59);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.White;
            this.btnsua.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Location = new System.Drawing.Point(840, 302);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 60);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.White;
            this.btnxoa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(694, 302);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 58);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttimkiem.Location = new System.Drawing.Point(169, 18);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(394, 22);
            this.txttimkiem.TabIndex = 6;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.White;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.Location = new System.Drawing.Point(13, 9);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(133, 36);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(690, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại sự kiện";
            // 
            // cmbLoaiSK
            // 
            this.cmbLoaiSK.BackColor = System.Drawing.Color.White;
            this.cmbLoaiSK.FormattingEnabled = true;
            this.cmbLoaiSK.Location = new System.Drawing.Point(851, 207);
            this.cmbLoaiSK.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiSK.Name = "cmbLoaiSK";
            this.cmbLoaiSK.Size = new System.Drawing.Size(227, 24);
            this.cmbLoaiSK.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HeChuyenGia_Nhom2.Properties.Resources.header;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 570);
            this.panel1.TabIndex = 9;
            // 
            // quanlysukien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1210, 638);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.cmbLoaiSK);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmotask);
            this.Controls.Add(this.txtmask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datasukien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "quanlysukien";
            this.Text = "quanlysukien";
            this.Load += new System.EventHandler(this.quanlysukien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasukien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datasukien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmask;
        private System.Windows.Forms.TextBox txtmotask;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiSK;
        private System.Windows.Forms.Panel panel1;
    }
}