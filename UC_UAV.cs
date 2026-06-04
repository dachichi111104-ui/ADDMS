using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADDMS2
{
    public partial class UC_UAV : UserControl
    {
        private class DroneInfo
        {
            public string Ma { get; set; } = "";
            public string Ten { get; set; } = "";
            public double TaiTrong { get; set; }
            public string TrangThai { get; set; } = "";
        }

        private List<DroneInfo> dsDrone = new()
        {
            new DroneInfo { Ma = "UAV001", Ten = "DJI Matrice 300", TaiTrong = 20, TrangThai = "san_sang" },
            new DroneInfo { Ma = "UAV002", Ten = "DJI Mavic 3",     TaiTrong = 10, TrangThai = "dang_bay" },
            new DroneInfo { Ma = "UAV003", Ten = "Autel EVO II",    TaiTrong = 15, TrangThai = "bao_tri"  },
            new DroneInfo { Ma = "UAV004", Ten = "Parrot Anafi",    TaiTrong = 8,  TrangThai = "san_sang" },
        };

        public UC_UAV()
        {
            InitializeComponent();
            this.Load += UC_UAV_Load;
        }

        private void UC_UAV_Load(object? sender, EventArgs e)
        {
            // Filter combobox
            cboFilter.Items.Clear();
            cboFilter.Items.Add("Tất cả");
            cboFilter.Items.Add("Sẵn sàng");
            cboFilter.Items.Add("Đang bay");
            cboFilter.Items.Add("Đang bảo trì");
            cboFilter.SelectedIndex = 0;

            StyleTable();
            RefreshTable(dsDrone);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => Filter();
        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e) => Filter();

        private void Filter()
        {
            string kw = txtSearch.Text.Trim().ToLower();
            string trangThai = cboFilter.SelectedIndex switch
            {
                1 => "san_sang",
                2 => "dang_bay",
                3 => "bao_tri",
                _ => ""
            };

            var result = dsDrone.Where(d =>
            {
                bool matchKw = string.IsNullOrEmpty(kw) ||
                               d.Ma.ToLower().Contains(kw) ||
                               d.Ten.ToLower().Contains(kw);
                bool matchTT = string.IsNullOrEmpty(trangThai) ||
                               d.TrangThai == trangThai;
                return matchKw && matchTT;
            }).ToList();

            RefreshTable(result);
        }

        private void StyleTable()
        {
            dgvUAV.BorderStyle = BorderStyle.None;
            dgvUAV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUAV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUAV.GridColor = Color.FromArgb(230, 230, 238);
            dgvUAV.BackgroundColor = Color.White;
            dgvUAV.RowHeadersVisible = false;
            dgvUAV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUAV.AllowUserToAddRows = false;
            dgvUAV.AllowUserToResizeRows = false;
            dgvUAV.ReadOnly = true;
            dgvUAV.Font = new Font("Segoe UI", 10f);
            dgvUAV.EnableHeadersVisualStyles = false;
            dgvUAV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvUAV.ScrollBars = ScrollBars.None;

            // Header
            dgvUAV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 248);
            dgvUAV.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 90);
            dgvUAV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvUAV.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 0, 0, 0);
            dgvUAV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 248);
            dgvUAV.ColumnHeadersHeight = 48;

            // Row
            dgvUAV.DefaultCellStyle.BackColor = Color.White;
            dgvUAV.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 60);
            dgvUAV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 240, 255);
            dgvUAV.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 60);
            dgvUAV.DefaultCellStyle.Padding = new Padding(12, 0, 0, 0);
            dgvUAV.RowTemplate.Height = 52;
            dgvUAV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 254);

            // Cột thao tác
            dgvUAV.Columns["colThaoTac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Độ rộng
            dgvUAV.Columns["colMa"].Width = 110;
            dgvUAV.Columns["colTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUAV.Columns["colTen"].MinimumWidth = 150;
            dgvUAV.Columns["colTaiTrong"].Width = 180;
            dgvUAV.Columns["colTrangThai"].Width = 160;
            dgvUAV.Columns["colThaoTac"].Width = 100;
        }

        private void RefreshTable(List<DroneInfo> data)
        {
            dgvUAV.Rows.Clear();
            foreach (var d in data)
            {
                int idx = dgvUAV.Rows.Add(d.Ma, d.Ten, d.TaiTrong, "", "✏  🗑");

                // Badge màu trạng thái
                var cell = dgvUAV.Rows[idx].Cells["colTrangThai"];
                switch (d.TrangThai)
                {
                    case "san_sang":
                        cell.Value = "Sẵn sàng";
                        cell.Style.BackColor = Color.FromArgb(220, 245, 220);
                        cell.Style.ForeColor = Color.FromArgb(20, 120, 60);
                        cell.Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "dang_bay":
                        cell.Value = "Đang bay";
                        cell.Style.BackColor = Color.FromArgb(255, 243, 205);
                        cell.Style.ForeColor = Color.FromArgb(160, 100, 0);
                        cell.Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "bao_tri":
                        cell.Value = "Đang bảo trì";
                        cell.Style.BackColor = Color.FromArgb(255, 220, 220);
                        cell.Style.ForeColor = Color.FromArgb(180, 30, 30);
                        cell.Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                }
            }
            ResizeTable();
        }

        private void ResizeTable()
        {
            int headerH = dgvUAV.ColumnHeadersHeight;
            int rowH = dgvUAV.RowTemplate.Height;
            dgvUAV.Height = headerH + (rowH * dgvUAV.Rows.Count) + 2;
        }

        private void dgvUAV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 4) return;

            string ma = dgvUAV.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            int idx = dsDrone.FindIndex(d => d.Ma == ma);
            if (idx < 0) return;

            var cellRect = dgvUAV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            var mousePos = dgvUAV.PointToClient(MousePosition);
            bool isEdit = mousePos.X < cellRect.Left + cellRect.Width / 2;

            if (isEdit)
                ShowEditDialog(idx);
            else
                DeleteDrone(idx);
        }

        private void ShowEditDialog(int idx)
        {
            var d = dsDrone[idx];
            var form = new Form
            {
                Text = "Sửa UAV",
                Size = new Size(420, 320),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                Font = new Font("Segoe UI", 10f)
            };

            var lblTen = new Label { Text = "Tên UAV:", Left = 20, Top = 20, Width = 140, AutoSize = false, Height = 25 };
            var lblTL = new Label { Text = "Tải trọng (kg):", Left = 20, Top = 70, Width = 140, AutoSize = false, Height = 25 };
            var lblTT = new Label { Text = "Trạng thái:", Left = 20, Top = 120, Width = 140, AutoSize = false, Height = 25 };

            var txtTen = new TextBox { Left = 170, Top = 17, Width = 210, Text = d.Ten };
            var txtTL = new TextBox { Left = 170, Top = 67, Width = 210, Text = d.TaiTrong.ToString() };
            var cboTT = new ComboBox
            {
                Left = 170,
                Top = 117,
                Width = 210,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboTT.Items.AddRange(new[] { "Sẵn sàng", "Đang bay", "Đang bảo trì" });
            cboTT.SelectedIndex = d.TrangThai switch
            {
                "san_sang" => 0,
                "dang_bay" => 1,
                "bao_tri" => 2,
                _ => 0
            };

            var btnLuu = new Button
            {
                Text = "Lưu",
                Left = 170,
                Top = 175,
                Width = 100,
                Height = 36,
                BackColor = Color.FromArgb(13, 27, 62),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            var btnHuy = new Button
            {
                Text = "Hủy",
                Left = 280,
                Top = 175,
                Width = 100,
                Height = 36,
                FlatStyle = FlatStyle.Flat
            };

            btnLuu.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text)) { MessageBox.Show("Tên không được để trống!"); return; }
                if (!double.TryParse(txtTL.Text, out double tl) || tl <= 0) { MessageBox.Show("Tải trọng không hợp lệ!"); return; }
                dsDrone[idx].Ten = txtTen.Text.Trim();
                dsDrone[idx].TaiTrong = tl;
                dsDrone[idx].TrangThai = cboTT.SelectedIndex switch
                {
                    0 => "san_sang",
                    1 => "dang_bay",
                    2 => "bao_tri",
                    _ => "san_sang"
                };
                form.DialogResult = DialogResult.OK;
            };
            btnHuy.Click += (s, ev) => form.Close();
            form.Controls.AddRange(new Control[] { lblTen, lblTL, lblTT, txtTen, txtTL, cboTT, btnLuu, btnHuy });

            if (form.ShowDialog() == DialogResult.OK) Filter();
        }

        private void DeleteDrone(int idx)
        {
            if (MessageBox.Show($"Xóa UAV '{dsDrone[idx].Ten}'?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dsDrone.RemoveAt(idx);
                Filter();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            var form = new Form
            {
                Text = "Thêm UAV mới",
                Size = new Size(420, 360),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                Font = new Font("Segoe UI", 10f)
            };

            var lblMa = new Label { Text = "Mã UAV:", Left = 20, Top = 20, Width = 140, AutoSize = false, Height = 25 };
            var lblTen = new Label { Text = "Tên UAV:", Left = 20, Top = 70, Width = 140, AutoSize = false, Height = 25 };
            var lblTL = new Label { Text = "Tải trọng (kg):", Left = 20, Top = 120, Width = 140, AutoSize = false, Height = 25 };
            var lblTT = new Label { Text = "Trạng thái:", Left = 20, Top = 170, Width = 140, AutoSize = false, Height = 25 };

            var txtMa = new TextBox { Left = 170, Top = 17, Width = 210 };
            var txtTen = new TextBox { Left = 170, Top = 67, Width = 210 };
            var txtTL = new TextBox { Left = 170, Top = 117, Width = 210 };
            var cboTT = new ComboBox
            {
                Left = 170,
                Top = 167,
                Width = 210,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboTT.Items.AddRange(new[] { "Sẵn sàng", "Đang bay", "Đang bảo trì" });
            cboTT.SelectedIndex = 0;

            var btnLuu = new Button
            {
                Text = "Thêm",
                Left = 170,
                Top = 225,
                Width = 100,
                Height = 36,
                BackColor = Color.FromArgb(13, 27, 62),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            var btnHuy = new Button
            {
                Text = "Hủy",
                Left = 280,
                Top = 225,
                Width = 100,
                Height = 36,
                FlatStyle = FlatStyle.Flat
            };

            btnLuu.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtMa.Text)) { MessageBox.Show("Mã không được để trống!"); return; }
                if (dsDrone.Any(d => d.Ma == txtMa.Text.Trim())) { MessageBox.Show("Mã đã tồn tại!"); return; }
                if (string.IsNullOrWhiteSpace(txtTen.Text)) { MessageBox.Show("Tên không được để trống!"); return; }
                if (!double.TryParse(txtTL.Text, out double tl) || tl <= 0) { MessageBox.Show("Tải trọng không hợp lệ!"); return; }

                dsDrone.Add(new DroneInfo
                {
                    Ma = txtMa.Text.Trim(),
                    Ten = txtTen.Text.Trim(),
                    TaiTrong = tl,
                    TrangThai = cboTT.SelectedIndex switch
                    {
                        0 => "san_sang",
                        1 => "dang_bay",
                        2 => "bao_tri",
                        _ => "san_sang"
                    }
                });
                form.DialogResult = DialogResult.OK;
            };
            btnHuy.Click += (s, ev) => form.Close();
            form.Controls.AddRange(new Control[] { lblMa, lblTen, lblTL, lblTT, txtMa, txtTen, txtTL, cboTT, btnLuu, btnHuy });

            if (form.ShowDialog() == DialogResult.OK) Filter();
        }
    }
}