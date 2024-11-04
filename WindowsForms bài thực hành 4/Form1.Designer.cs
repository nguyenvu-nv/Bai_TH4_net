namespace WindowsForms_bài_thực_hành_4
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
            this.data_KH = new System.Windows.Forms.DataGridView();
            this.dt_makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_DV = new System.Windows.Forms.DataGridView();
            this.db_madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_giadv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_KH = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sodt = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_DV)).BeginInit();
            this.panel_KH.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // data_KH
            // 
            this.data_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_makh,
            this.dt_tenkh,
            this.dt_sodt,
            this.dt_diachi});
            this.data_KH.Location = new System.Drawing.Point(56, 49);
            this.data_KH.Name = "data_KH";
            this.data_KH.Size = new System.Drawing.Size(445, 255);
            this.data_KH.TabIndex = 1;
            // 
            // dt_makh
            // 
            this.dt_makh.DataPropertyName = "CustomerId";
            this.dt_makh.HeaderText = "mã khách hàng";
            this.dt_makh.Name = "dt_makh";
            // 
            // dt_tenkh
            // 
            this.dt_tenkh.DataPropertyName = "Name";
            this.dt_tenkh.HeaderText = "Tên khách hàng";
            this.dt_tenkh.Name = "dt_tenkh";
            // 
            // dt_sodt
            // 
            this.dt_sodt.DataPropertyName = "Phone";
            this.dt_sodt.HeaderText = "Số điện thoại";
            this.dt_sodt.Name = "dt_sodt";
            // 
            // dt_diachi
            // 
            this.dt_diachi.DataPropertyName = "Address";
            this.dt_diachi.HeaderText = "Địa chỉ";
            this.dt_diachi.Name = "dt_diachi";
            // 
            // data_DV
            // 
            this.data_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.db_madv,
            this.db_tendv,
            this.db_giadv});
            this.data_DV.Location = new System.Drawing.Point(532, 49);
            this.data_DV.Name = "data_DV";
            this.data_DV.Size = new System.Drawing.Size(344, 255);
            this.data_DV.TabIndex = 2;
            // 
            // db_madv
            // 
            this.db_madv.DataPropertyName = "ServiceId";
            this.db_madv.HeaderText = "Mã dịch vụ";
            this.db_madv.Name = "db_madv";
            this.db_madv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // db_tendv
            // 
            this.db_tendv.DataPropertyName = "ServiceName";
            this.db_tendv.HeaderText = "Tên dịch vụ";
            this.db_tendv.Name = "db_tendv";
            // 
            // db_giadv
            // 
            this.db_giadv.DataPropertyName = "Serviceprice";
            this.db_giadv.HeaderText = "Giá tiền";
            this.db_giadv.Name = "db_giadv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thông tin dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã khách hàng";
            // 
            // panel_KH
            // 
            this.panel_KH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_KH.Controls.Add(this.btn_xoa);
            this.panel_KH.Controls.Add(this.btn_sua);
            this.panel_KH.Controls.Add(this.btn_them);
            this.panel_KH.Controls.Add(this.label12);
            this.panel_KH.Controls.Add(this.label11);
            this.panel_KH.Controls.Add(this.label10);
            this.panel_KH.Controls.Add(this.txt_diachi);
            this.panel_KH.Controls.Add(this.txt_sodt);
            this.panel_KH.Controls.Add(this.txt_tenkh);
            this.panel_KH.Location = new System.Drawing.Point(933, 1);
            this.panel_KH.Name = "panel_KH";
            this.panel_KH.Size = new System.Drawing.Size(519, 633);
            this.panel_KH.TabIndex = 6;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(303, 212);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 35);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(166, 212);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(83, 35);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(42, 212);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(86, 35);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên khách hàng";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(137, 135);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(284, 20);
            this.txt_diachi.TabIndex = 3;
            // 
            // txt_sodt
            // 
            this.txt_sodt.Location = new System.Drawing.Point(137, 91);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.Size = new System.Drawing.Size(156, 20);
            this.txt_sodt.TabIndex = 2;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(137, 51);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(284, 20);
            this.txt_tenkh.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(59, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 253);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(97, 100);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dịch vụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "tạo hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(532, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 242);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn đã tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dịch vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tổng tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "label9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "label15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_DV);
            this.Controls.Add(this.panel_KH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data_KH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_DV)).EndInit();
            this.panel_KH.ResumeLayout(false);
            this.panel_KH.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_KH;
        private System.Windows.Forms.DataGridView data_DV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_KH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sodt;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_giadv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
    }
}

