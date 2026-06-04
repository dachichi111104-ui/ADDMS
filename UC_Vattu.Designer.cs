namespace ADDMS2
{
    partial class UC_Vattu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitle = new Label();
            btnThemMoi = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            dgvVatTu = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colTL = new DataGridViewTextBoxColumn();
            colTonKho = new DataGridViewTextBoxColumn();
            colThaoTac = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVatTu).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 0, 64);
            lblTitle.Location = new Point(34, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(378, 38);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "QUẢN LÝ VẬT TƯ CỨU TRỢ";
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Transparent;
            btnThemMoi.BorderColor = Color.Transparent;
            btnThemMoi.BorderRadius = 20;
            btnThemMoi.CustomizableEdges = customizableEdges1;
            btnThemMoi.DisabledState.BorderColor = Color.DarkGray;
            btnThemMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThemMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemMoi.FillColor = Color.FromArgb(0, 0, 64);
            btnThemMoi.Font = new Font("Segoe UI", 9F);
            btnThemMoi.ForeColor = Color.White;
            btnThemMoi.Location = new Point(776, 29);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnThemMoi.Size = new Size(374, 51);
            btnThemMoi.TabIndex = 16;
            btnThemMoi.Text = "+ Thêm vật tư mới";
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 20;
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(34, 105);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm theo mã hoặc tên vật tư...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(1125, 62);
            txtSearch.TabIndex = 17;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // dgvVatTu
            // 
            dgvVatTu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVatTu.Columns.AddRange(new DataGridViewColumn[] { colMa, colTen, colTL, colTonKho, colThaoTac });
            dgvVatTu.Location = new Point(34, 195);
            dgvVatTu.Name = "dgvVatTu";
            dgvVatTu.RowHeadersWidth = 62;
            dgvVatTu.ScrollBars = ScrollBars.None;
            dgvVatTu.Size = new Size(1125, 438);
            dgvVatTu.TabIndex = 18;
            dgvVatTu.CellClick += dgvVatTu_CellClick;
            dgvVatTu.CellContentClick += dgvVatTu_CellContentClick;
            // 
            // colMa
            // 
            colMa.HeaderText = "Mã vật tư";
            colMa.MinimumWidth = 8;
            colMa.Name = "colMa";
            colMa.Width = 150;
            // 
            // colTen
            // 
            colTen.HeaderText = "Tên vật tư";
            colTen.MinimumWidth = 8;
            colTen.Name = "colTen";
            colTen.Width = 150;
            // 
            // colTL
            // 
            colTL.HeaderText = "Trọng lượng/Đơn vị (kg)";
            colTL.MinimumWidth = 8;
            colTL.Name = "colTL";
            colTL.Width = 150;
            // 
            // colTonKho
            // 
            colTonKho.HeaderText = "Số lượng tồn kho";
            colTonKho.MinimumWidth = 8;
            colTonKho.Name = "colTonKho";
            colTonKho.Width = 150;
            // 
            // colThaoTac
            // 
            colThaoTac.HeaderText = "Thao tác";
            colThaoTac.MinimumWidth = 8;
            colThaoTac.Name = "colThaoTac";
            colThaoTac.Width = 150;
            // 
            // UC_Vattu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(dgvVatTu);
            Controls.Add(txtSearch);
            Controls.Add(btnThemMoi);
            Controls.Add(lblTitle);
            Name = "UC_Vattu";
            Size = new Size(1133, 552);
            ((System.ComponentModel.ISupportInitialize)dgvVatTu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnThemMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DataGridView dgvVatTu;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colTL;
        private DataGridViewTextBoxColumn colTonKho;
        private DataGridViewTextBoxColumn colThaoTac;
    }
}
