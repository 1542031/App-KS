namespace KS
{
    partial class frmTinhTien
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
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.cbVIP = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhuThu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cbQD = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbLTime = new System.Windows.Forms.CheckBox();
            this.lbDeal = new System.Windows.Forms.Label();
            this.txtDeal = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Gotham Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(13, 13);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(106, 31);
            this.lblTenPhong.TabIndex = 0;
            this.lblTenPhong.Text = "Room 1";
            this.lblTenPhong.Click += new System.EventHandler(this.lblTenPhong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Check Out";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(88, 82);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(146, 20);
            this.txtCheckIn.TabIndex = 2;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(243, 80);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(88, 113);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(146, 20);
            this.txtCheckOut.TabIndex = 2;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(243, 111);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hours";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Enabled = false;
            this.txtThoiGian.Location = new System.Drawing.Point(88, 143);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(49, 20);
            this.txtThoiGian.TabIndex = 2;
            this.txtThoiGian.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room charge";
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(88, 175);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(146, 20);
            this.txtGia.TabIndex = 2;
            this.txtGia.Text = "0";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(242, 254);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "Charge";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // cbVIP
            // 
            this.cbVIP.AutoSize = true;
            this.cbVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVIP.Location = new System.Drawing.Point(244, 18);
            this.cbVIP.Name = "cbVIP";
            this.cbVIP.Size = new System.Drawing.Size(61, 28);
            this.cbVIP.TabIndex = 4;
            this.cbVIP.Text = "VIP";
            this.cbVIP.UseVisualStyleBackColor = true;
            this.cbVIP.CheckStateChanged += new System.EventHandler(this.cbVIP_CheckStateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Service";
            // 
            // txtPhuThu
            // 
            this.txtPhuThu.Location = new System.Drawing.Point(88, 201);
            this.txtPhuThu.Name = "txtPhuThu";
            this.txtPhuThu.Size = new System.Drawing.Size(146, 20);
            this.txtPhuThu.TabIndex = 2;
            this.txtPhuThu.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Notes";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(88, 228);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(146, 20);
            this.txtGhiChu.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(89, 256);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(146, 20);
            this.txtTongTien.TabIndex = 2;
            this.txtTongTien.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(89, 51);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(146, 20);
            this.txtTen.TabIndex = 2;
            // 
            // cbQD
            // 
            this.cbQD.AutoSize = true;
            this.cbQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQD.Location = new System.Drawing.Point(311, 18);
            this.cbQD.Name = "cbQD";
            this.cbQD.Size = new System.Drawing.Size(120, 28);
            this.cbQD.TabIndex = 5;
            this.cbQD.Text = "Overnight";
            this.cbQD.UseVisualStyleBackColor = true;
            this.cbQD.CheckStateChanged += new System.EventHandler(this.cbQD_CheckStateChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(337, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(337, 79);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(75, 23);
            this.btnDatPhong.TabIndex = 7;
            this.btnDatPhong.Text = "Book";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(337, 113);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbLTime
            // 
            this.cbLTime.AutoSize = true;
            this.cbLTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLTime.Location = new System.Drawing.Point(244, 48);
            this.cbLTime.Name = "cbLTime";
            this.cbLTime.Size = new System.Drawing.Size(124, 28);
            this.cbLTime.TabIndex = 9;
            this.cbLTime.Text = "Long-term";
            this.cbLTime.UseVisualStyleBackColor = true;
            this.cbLTime.Visible = false;
            this.cbLTime.CheckStateChanged += new System.EventHandler(this.cbLTime_CheckStateChanged);
            // 
            // lbDeal
            // 
            this.lbDeal.AutoSize = true;
            this.lbDeal.Location = new System.Drawing.Point(244, 156);
            this.lbDeal.Name = "lbDeal";
            this.lbDeal.Size = new System.Drawing.Size(88, 13);
            this.lbDeal.TabIndex = 10;
            this.lbDeal.Text = "Giá thương lượng";
            this.lbDeal.Visible = false;
            // 
            // txtDeal
            // 
            this.txtDeal.Location = new System.Drawing.Point(244, 175);
            this.txtDeal.Name = "txtDeal";
            this.txtDeal.Size = new System.Drawing.Size(168, 20);
            this.txtDeal.TabIndex = 11;
            this.txtDeal.Text = "0";
            this.txtDeal.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 306);
            this.Controls.Add(this.txtDeal);
            this.Controls.Add(this.lbDeal);
            this.Controls.Add(this.cbLTime);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbQD);
            this.Controls.Add(this.cbVIP);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtPhuThu);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenPhong);
            this.Name = "frmTinhTien";
            this.Text = "Room charge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTinhTien_FormClosed);
            this.Load += new System.EventHandler(this.frmTinhTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.CheckBox cbVIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhuThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.CheckBox cbQD;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox cbLTime;
        private System.Windows.Forms.Label lbDeal;
        private System.Windows.Forms.TextBox txtDeal;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

