namespace ADDMS2
{
    partial class UC_UAV
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvUAV = new DataGridView();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnThemMoi = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Label();
            cboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            colMa = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colTaiTrong = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colThaoTac = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUAV).BeginInit();
            SuspendLayout();
            // 
            // dgvUAV
            // 
            dgvUAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUAV.Columns.AddRange(new DataGridViewColumn[] { colMa, colTen, colTaiTrong, colTrangThai, colThaoTac });
            dgvUAV.Location = new Point(25, 190);
            dgvUAV.Name = "dgvUAV";
            dgvUAV.RowHeadersWidth = 62;
            dgvUAV.ScrollBars = ScrollBars.None;
            dgvUAV.Size = new Size(1125, 438);
            dgvUAV.TabIndex = 22;
            dgvUAV.CellClick += dgvUAV_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 20;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(25, 100);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm theo mã hoặc tên Drone...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(677, 62);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Transparent;
            btnThemMoi.BorderColor = Color.Transparent;
            btnThemMoi.BorderRadius = 20;
            btnThemMoi.CustomizableEdges = customizableEdges3;
            btnThemMoi.DisabledState.BorderColor = Color.DarkGray;
            btnThemMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThemMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemMoi.FillColor = Color.FromArgb(0, 0, 64);
            btnThemMoi.Font = new Font("Segoe UI", 9F);
            btnThemMoi.ForeColor = Color.White;
            btnThemMoi.Location = new Point(767, 24);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThemMoi.Size = new Size(374, 51);
            btnThemMoi.TabIndex = 20;
            btnThemMoi.Text = "+ Thêm Drone mới";
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 0, 64);
            lblTitle.Location = new Point(25, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 38);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "QUẢN LÝ DRONE ";
            // 
            // cboFilter
            // 
            cboFilter.BackColor = Color.Transparent;
            cboFilter.BorderRadius = 20;
            cboFilter.CustomizableEdges = customizableEdges5;
            cboFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cboFilter.DropDownHeight = 150;
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.FocusedColor = Color.FromArgb(94, 148, 255);
            cboFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboFilter.Font = new Font("Segoe UI", 10F);
            cboFilter.ForeColor = Color.FromArgb(68, 88, 112);
            cboFilter.IntegralHeight = false;
            cboFilter.ItemHeight = 56;
            cboFilter.Location = new Point(767, 100);
            cboFilter.Name = "cboFilter";
            cboFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboFilter.Size = new Size(374, 62);
            cboFilter.TabIndex = 23;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            cboFilter.Click += cboFilter_SelectedIndexChanged;
            // 
            // colMa
            // 
            colMa.HeaderText = "Mã Drone";
            colMa.MinimumWidth = 8;
            colMa.Name = "colMa";
            colMa.Width = 150;
            // 
            // colTen
            // 
            colTen.HeaderText = "Tên Drone";
            colTen.MinimumWidth = 8;
            colTen.Name = "colTen";
            colTen.Width = 150;
            // 
            // colTaiTrong
            // 
            colTaiTrong.HeaderText = "Tải trọng tối đa (kg)";
            colTaiTrong.MinimumWidth = 8;
            colTaiTrong.Name = "colTaiTrong";
            colTaiTrong.Width = 150;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 8;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.Width = 150;
            // 
            // colThaoTac
            // 
            colThaoTac.HeaderText = "Thao tác";
            colThaoTac.MinimumWidth = 8;
            colThaoTac.Name = "colThaoTac";
            colThaoTac.Width = 150;
            // 
            // UC_UAV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(cboFilter);
            Controls.Add(dgvUAV);
            Controls.Add(txtSearch);
            Controls.Add(btnThemMoi);
            Controls.Add(lblTitle);
            Name = "UC_UAV";
            Size = new Size(1133, 552);
            ((System.ComponentModel.ISupportInitialize)dgvUAV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUAV;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnThemMoi;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilter;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colTaiTrong;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colThaoTac;
    }
}
