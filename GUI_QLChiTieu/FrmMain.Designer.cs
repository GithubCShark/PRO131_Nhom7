
namespace GUI_QLChiTieu
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTuyChon = new System.Windows.Forms.Button();
            this.btnMucTieu = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnChiTieu = new System.Windows.Forms.Button();
            this.btnThuNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnDangXuat);
            this.panelMain.Controls.Add(this.btnTuyChon);
            this.panelMain.Controls.Add(this.btnMucTieu);
            this.panelMain.Controls.Add(this.btnThongKe);
            this.panelMain.Controls.Add(this.btnChiTieu);
            this.panelMain.Controls.Add(this.btnThuNhap);
            this.panelMain.Location = new System.Drawing.Point(12, 93);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 620);
            this.panelMain.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::GUI_QLChiTieu.Properties.Resources.logout;
            this.btnDangXuat.Location = new System.Drawing.Point(738, 320);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(174, 123);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuyChon.Image = global::GUI_QLChiTieu.Properties.Resources.options;
            this.btnTuyChon.Location = new System.Drawing.Point(409, 320);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Size = new System.Drawing.Size(174, 123);
            this.btnTuyChon.TabIndex = 5;
            this.btnTuyChon.Text = "Tùy Chọn";
            this.btnTuyChon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTuyChon.UseVisualStyleBackColor = true;
            // 
            // btnMucTieu
            // 
            this.btnMucTieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMucTieu.Image = global::GUI_QLChiTieu.Properties.Resources.target;
            this.btnMucTieu.Location = new System.Drawing.Point(79, 320);
            this.btnMucTieu.Name = "btnMucTieu";
            this.btnMucTieu.Size = new System.Drawing.Size(174, 123);
            this.btnMucTieu.TabIndex = 4;
            this.btnMucTieu.Text = "Đặt Mục TIêu";
            this.btnMucTieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMucTieu.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::GUI_QLChiTieu.Properties.Resources.thongKe;
            this.btnThongKe.Location = new System.Drawing.Point(738, 123);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(174, 123);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnChiTieu
            // 
            this.btnChiTieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTieu.Image = global::GUI_QLChiTieu.Properties.Resources.pay;
            this.btnChiTieu.Location = new System.Drawing.Point(409, 123);
            this.btnChiTieu.Name = "btnChiTieu";
            this.btnChiTieu.Size = new System.Drawing.Size(174, 123);
            this.btnChiTieu.TabIndex = 2;
            this.btnChiTieu.Text = "Chi Tiêu";
            this.btnChiTieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChiTieu.UseVisualStyleBackColor = true;
            // 
            // btnThuNhap
            // 
            this.btnThuNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThuNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuNhap.Image = global::GUI_QLChiTieu.Properties.Resources.collection;
            this.btnThuNhap.Location = new System.Drawing.Point(79, 123);
            this.btnThuNhap.Name = "btnThuNhap";
            this.btnThuNhap.Size = new System.Drawing.Size(174, 123);
            this.btnThuNhap.TabIndex = 1;
            this.btnThuNhap.Text = "Thu Nhập";
            this.btnThuNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThuNhap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(347, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Chi Tiêu Cá Nhân";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::GUI_QLChiTieu.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 53);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CHI TIÊU CÁ NHÂN";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTuyChon;
        private System.Windows.Forms.Button btnMucTieu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnChiTieu;
        private System.Windows.Forms.Button btnThuNhap;
        private System.Windows.Forms.Button btnBack;
    }
}

