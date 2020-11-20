
namespace GUI_QLChiTieu
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.tabCtrlTKe = new System.Windows.Forms.TabControl();
            this.tabPageNgay = new System.Windows.Forms.TabPage();
            this.tabPageThang = new System.Windows.Forms.TabPage();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblThuNgay = new System.Windows.Forms.Label();
            this.lblChiNgay = new System.Windows.Forms.Label();
            this.lblSoDuNgay = new System.Windows.Forms.Label();
            this.lblCTKTNgay = new System.Windows.Forms.Label();
            this.lblCTKCNgay = new System.Windows.Forms.Label();
            this.dgvThuNgay = new System.Windows.Forms.DataGridView();
            this.dgvChiNgay = new System.Windows.Forms.DataGridView();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtThuNgay = new System.Windows.Forms.TextBox();
            this.txtChiNgay = new System.Windows.Forms.TextBox();
            this.txtSoDuNgay = new System.Windows.Forms.TextBox();
            this.txtSoDuThang = new System.Windows.Forms.TextBox();
            this.txtChiThang = new System.Windows.Forms.TextBox();
            this.txtThuThang = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgvChiThang = new System.Windows.Forms.DataGridView();
            this.dgvThuThang = new System.Windows.Forms.DataGridView();
            this.lblCTKCThang = new System.Windows.Forms.Label();
            this.lblCTKTThang = new System.Windows.Forms.Label();
            this.llblSoDuThang = new System.Windows.Forms.Label();
            this.lblChiThang = new System.Windows.Forms.Label();
            this.lblThuThang = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.tabCtrlTKe.SuspendLayout();
            this.tabPageNgay.SuspendLayout();
            this.tabPageThang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlTKe
            // 
            this.tabCtrlTKe.Controls.Add(this.tabPageNgay);
            this.tabCtrlTKe.Controls.Add(this.tabPageThang);
            this.tabCtrlTKe.Location = new System.Drawing.Point(15, 44);
            this.tabCtrlTKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCtrlTKe.Name = "tabCtrlTKe";
            this.tabCtrlTKe.SelectedIndex = 0;
            this.tabCtrlTKe.Size = new System.Drawing.Size(941, 559);
            this.tabCtrlTKe.TabIndex = 0;
            // 
            // tabPageNgay
            // 
            this.tabPageNgay.Controls.Add(this.txtSoDuNgay);
            this.tabPageNgay.Controls.Add(this.txtChiNgay);
            this.tabPageNgay.Controls.Add(this.txtThuNgay);
            this.tabPageNgay.Controls.Add(this.dtpNgay);
            this.tabPageNgay.Controls.Add(this.dgvChiNgay);
            this.tabPageNgay.Controls.Add(this.dgvThuNgay);
            this.tabPageNgay.Controls.Add(this.lblCTKCNgay);
            this.tabPageNgay.Controls.Add(this.lblCTKTNgay);
            this.tabPageNgay.Controls.Add(this.lblSoDuNgay);
            this.tabPageNgay.Controls.Add(this.lblChiNgay);
            this.tabPageNgay.Controls.Add(this.lblThuNgay);
            this.tabPageNgay.Controls.Add(this.lblNgay);
            this.tabPageNgay.Location = new System.Drawing.Point(4, 28);
            this.tabPageNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageNgay.Name = "tabPageNgay";
            this.tabPageNgay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageNgay.Size = new System.Drawing.Size(933, 527);
            this.tabPageNgay.TabIndex = 0;
            this.tabPageNgay.Text = "Theo Ngày";
            this.tabPageNgay.UseVisualStyleBackColor = true;
            // 
            // tabPageThang
            // 
            this.tabPageThang.Controls.Add(this.txtSoDuThang);
            this.tabPageThang.Controls.Add(this.txtChiThang);
            this.tabPageThang.Controls.Add(this.txtThuThang);
            this.tabPageThang.Controls.Add(this.dateTimePicker2);
            this.tabPageThang.Controls.Add(this.dgvChiThang);
            this.tabPageThang.Controls.Add(this.dgvThuThang);
            this.tabPageThang.Controls.Add(this.lblCTKCThang);
            this.tabPageThang.Controls.Add(this.lblCTKTThang);
            this.tabPageThang.Controls.Add(this.llblSoDuThang);
            this.tabPageThang.Controls.Add(this.lblChiThang);
            this.tabPageThang.Controls.Add(this.lblThuThang);
            this.tabPageThang.Controls.Add(this.lblThang);
            this.tabPageThang.Location = new System.Drawing.Point(4, 28);
            this.tabPageThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageThang.Name = "tabPageThang";
            this.tabPageThang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageThang.Size = new System.Drawing.Size(933, 527);
            this.tabPageThang.TabIndex = 1;
            this.tabPageThang.Text = "Theo Tháng";
            this.tabPageThang.UseVisualStyleBackColor = true;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(420, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(126, 31);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thống Kê";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(20, 17);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(84, 19);
            this.lblNgay.TabIndex = 1;
            this.lblNgay.Text = "Chọn Ngày";
            // 
            // lblThuNgay
            // 
            this.lblThuNgay.AutoSize = true;
            this.lblThuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuNgay.Location = new System.Drawing.Point(607, 17);
            this.lblThuNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThuNgay.Name = "lblThuNgay";
            this.lblThuNgay.Size = new System.Drawing.Size(73, 19);
            this.lblThuNgay.TabIndex = 2;
            this.lblThuNgay.Text = "Tổng Thu";
            // 
            // lblChiNgay
            // 
            this.lblChiNgay.AutoSize = true;
            this.lblChiNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNgay.Location = new System.Drawing.Point(607, 56);
            this.lblChiNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiNgay.Name = "lblChiNgay";
            this.lblChiNgay.Size = new System.Drawing.Size(70, 19);
            this.lblChiNgay.TabIndex = 3;
            this.lblChiNgay.Text = "Tổng Chi";
            // 
            // lblSoDuNgay
            // 
            this.lblSoDuNgay.AutoSize = true;
            this.lblSoDuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDuNgay.Location = new System.Drawing.Point(607, 103);
            this.lblSoDuNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDuNgay.Name = "lblSoDuNgay";
            this.lblSoDuNgay.Size = new System.Drawing.Size(52, 19);
            this.lblSoDuNgay.TabIndex = 4;
            this.lblSoDuNgay.Text = "Số Dư";
            // 
            // lblCTKTNgay
            // 
            this.lblCTKTNgay.AutoSize = true;
            this.lblCTKTNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTKTNgay.Location = new System.Drawing.Point(20, 129);
            this.lblCTKTNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTKTNgay.Name = "lblCTKTNgay";
            this.lblCTKTNgay.Size = new System.Drawing.Size(141, 19);
            this.lblCTKTNgay.TabIndex = 5;
            this.lblCTKTNgay.Text = "Chi Tiết Khoản Thu";
            // 
            // lblCTKCNgay
            // 
            this.lblCTKCNgay.AutoSize = true;
            this.lblCTKCNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTKCNgay.Location = new System.Drawing.Point(20, 327);
            this.lblCTKCNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTKCNgay.Name = "lblCTKCNgay";
            this.lblCTKCNgay.Size = new System.Drawing.Size(138, 19);
            this.lblCTKCNgay.TabIndex = 6;
            this.lblCTKCNgay.Text = "Chi Tiết Khoản Chi";
            // 
            // dgvThuNgay
            // 
            this.dgvThuNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuNgay.Location = new System.Drawing.Point(24, 152);
            this.dgvThuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThuNgay.Name = "dgvThuNgay";
            this.dgvThuNgay.Size = new System.Drawing.Size(890, 160);
            this.dgvThuNgay.TabIndex = 7;
            // 
            // dgvChiNgay
            // 
            this.dgvChiNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiNgay.Location = new System.Drawing.Point(24, 350);
            this.dgvChiNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChiNgay.Name = "dgvChiNgay";
            this.dgvChiNgay.Size = new System.Drawing.Size(890, 160);
            this.dgvChiNgay.TabIndex = 8;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(125, 17);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpNgay.TabIndex = 9;
            // 
            // txtThuNgay
            // 
            this.txtThuNgay.Location = new System.Drawing.Point(722, 14);
            this.txtThuNgay.Name = "txtThuNgay";
            this.txtThuNgay.ReadOnly = true;
            this.txtThuNgay.Size = new System.Drawing.Size(168, 26);
            this.txtThuNgay.TabIndex = 10;
            // 
            // txtChiNgay
            // 
            this.txtChiNgay.Location = new System.Drawing.Point(722, 56);
            this.txtChiNgay.Name = "txtChiNgay";
            this.txtChiNgay.ReadOnly = true;
            this.txtChiNgay.Size = new System.Drawing.Size(168, 26);
            this.txtChiNgay.TabIndex = 11;
            // 
            // txtSoDuNgay
            // 
            this.txtSoDuNgay.Location = new System.Drawing.Point(722, 100);
            this.txtSoDuNgay.Name = "txtSoDuNgay";
            this.txtSoDuNgay.ReadOnly = true;
            this.txtSoDuNgay.Size = new System.Drawing.Size(168, 26);
            this.txtSoDuNgay.TabIndex = 12;
            // 
            // txtSoDuThang
            // 
            this.txtSoDuThang.Location = new System.Drawing.Point(721, 103);
            this.txtSoDuThang.Name = "txtSoDuThang";
            this.txtSoDuThang.ReadOnly = true;
            this.txtSoDuThang.Size = new System.Drawing.Size(168, 26);
            this.txtSoDuThang.TabIndex = 24;
            // 
            // txtChiThang
            // 
            this.txtChiThang.Location = new System.Drawing.Point(721, 59);
            this.txtChiThang.Name = "txtChiThang";
            this.txtChiThang.ReadOnly = true;
            this.txtChiThang.Size = new System.Drawing.Size(168, 26);
            this.txtChiThang.TabIndex = 23;
            // 
            // txtThuThang
            // 
            this.txtThuThang.Location = new System.Drawing.Point(721, 17);
            this.txtThuThang.Name = "txtThuThang";
            this.txtThuThang.ReadOnly = true;
            this.txtThuThang.Size = new System.Drawing.Size(168, 26);
            this.txtThuThang.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // dgvChiThang
            // 
            this.dgvChiThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiThang.Location = new System.Drawing.Point(23, 353);
            this.dgvChiThang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiThang.Name = "dgvChiThang";
            this.dgvChiThang.Size = new System.Drawing.Size(890, 160);
            this.dgvChiThang.TabIndex = 20;
            // 
            // dgvThuThang
            // 
            this.dgvThuThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuThang.Location = new System.Drawing.Point(23, 155);
            this.dgvThuThang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuThang.Name = "dgvThuThang";
            this.dgvThuThang.Size = new System.Drawing.Size(890, 160);
            this.dgvThuThang.TabIndex = 19;
            // 
            // lblCTKCThang
            // 
            this.lblCTKCThang.AutoSize = true;
            this.lblCTKCThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTKCThang.Location = new System.Drawing.Point(19, 330);
            this.lblCTKCThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTKCThang.Name = "lblCTKCThang";
            this.lblCTKCThang.Size = new System.Drawing.Size(138, 19);
            this.lblCTKCThang.TabIndex = 18;
            this.lblCTKCThang.Text = "Chi Tiết Khoản Chi";
            // 
            // lblCTKTThang
            // 
            this.lblCTKTThang.AutoSize = true;
            this.lblCTKTThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTKTThang.Location = new System.Drawing.Point(19, 132);
            this.lblCTKTThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTKTThang.Name = "lblCTKTThang";
            this.lblCTKTThang.Size = new System.Drawing.Size(141, 19);
            this.lblCTKTThang.TabIndex = 17;
            this.lblCTKTThang.Text = "Chi Tiết Khoản Thu";
            // 
            // llblSoDuThang
            // 
            this.llblSoDuThang.AutoSize = true;
            this.llblSoDuThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSoDuThang.Location = new System.Drawing.Point(606, 106);
            this.llblSoDuThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblSoDuThang.Name = "llblSoDuThang";
            this.llblSoDuThang.Size = new System.Drawing.Size(52, 19);
            this.llblSoDuThang.TabIndex = 16;
            this.llblSoDuThang.Text = "Số Dư";
            // 
            // lblChiThang
            // 
            this.lblChiThang.AutoSize = true;
            this.lblChiThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiThang.Location = new System.Drawing.Point(606, 59);
            this.lblChiThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiThang.Name = "lblChiThang";
            this.lblChiThang.Size = new System.Drawing.Size(70, 19);
            this.lblChiThang.TabIndex = 15;
            this.lblChiThang.Text = "Tổng Chi";
            // 
            // lblThuThang
            // 
            this.lblThuThang.AutoSize = true;
            this.lblThuThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuThang.Location = new System.Drawing.Point(606, 20);
            this.lblThuThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThuThang.Name = "lblThuThang";
            this.lblThuThang.Size = new System.Drawing.Size(73, 19);
            this.lblThuThang.TabIndex = 14;
            this.lblThuThang.Text = "Tổng Thu";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(19, 20);
            this.lblThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(90, 19);
            this.lblThang.TabIndex = 13;
            this.lblThang.Text = "Chọn Tháng";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 616);
            this.Controls.Add(this.tabCtrlTKe);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            this.tabCtrlTKe.ResumeLayout(false);
            this.tabPageNgay.ResumeLayout(false);
            this.tabPageNgay.PerformLayout();
            this.tabPageThang.ResumeLayout(false);
            this.tabPageThang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlTKe;
        private System.Windows.Forms.TabPage tabPageNgay;
        private System.Windows.Forms.TabPage tabPageThang;
        private System.Windows.Forms.Label lblCTKCNgay;
        private System.Windows.Forms.Label lblCTKTNgay;
        private System.Windows.Forms.Label lblSoDuNgay;
        private System.Windows.Forms.Label lblChiNgay;
        private System.Windows.Forms.Label lblThuNgay;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DataGridView dgvChiNgay;
        private System.Windows.Forms.DataGridView dgvThuNgay;
        private System.Windows.Forms.TextBox txtSoDuNgay;
        private System.Windows.Forms.TextBox txtChiNgay;
        private System.Windows.Forms.TextBox txtThuNgay;
        private System.Windows.Forms.TextBox txtSoDuThang;
        private System.Windows.Forms.TextBox txtChiThang;
        private System.Windows.Forms.TextBox txtThuThang;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dgvChiThang;
        private System.Windows.Forms.DataGridView dgvThuThang;
        private System.Windows.Forms.Label lblCTKCThang;
        private System.Windows.Forms.Label lblCTKTThang;
        private System.Windows.Forms.Label llblSoDuThang;
        private System.Windows.Forms.Label lblChiThang;
        private System.Windows.Forms.Label lblThuThang;
        private System.Windows.Forms.Label lblThang;
    }
}