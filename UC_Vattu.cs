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
    public partial class UC_Vattu : UserControl
    {
        private class VatTuInfo
        {
            public string Ma { get; set; } = "";
            public string Ten { get; set; } = "";
            public double TrongLuong { get; set; }
            public int TonKho { get; set; }
        }

        private List<VatTuInfo> dsVatTu = new()
        {
            new VatTuInfo { Ma = "SUP001", Ten = "Nước suối",      TrongLuong = 0.5,   TonKho = 1000 },
            new VatTuInfo { Ma = "SUP002", Ten = "Mì tôm",         TrongLuong = 0.075, TonKho = 500  },
            new VatTuInfo { Ma = "SUP006", Ten = "Pin AA",         TrongLuong = 0.05,  TonKho = 400  },
            new VatTuInfo { Ma = "SUP004", Ten = "Thuốc men",      TrongLuong = 0.1,   TonKho = 300  },
            new VatTuInfo { Ma = "SUP003", Ten = "Bông băng y tế", TrongLuong = 0.2,   TonKho = 200  },
            new VatTuInfo { Ma = "SUP005", Ten = "Đèn pin",        TrongLuong = 0.3,   TonKho = 150  },
        };

        public UC_Vattu()
        {
            InitializeComponent();
            this.Load += UC_Vattu_Load;
        }

        private void UC_Vattu_Load(object? sender, EventArgs e)
        {
            StyleTable();
            RefreshTable(dsVatTu);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string kw = txtSearch.Text.Trim().ToLower();
            var result = string.IsNullOrEmpty(kw)
                ? dsVatTu
                : dsVatTu.Where(v =>
                    v.Ma.ToLower().Contains(kw) ||
                    v.Ten.ToLower().Contains(kw)).ToList();
            RefreshTable(result);
        }

        private void StyleTable()
        {
            dgvVatTu.BorderStyle = BorderStyle.None;
            dgvVatTu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVatTu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVatTu.GridColor = Color.FromArgb(230, 230, 238);
            dgvVatTu.BackgroundColor = Color.White;
            dgvVatTu.RowHeadersVisible = false;
            dgvVatTu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVatTu.AllowUserToAddRows = false;
            dgvVatTu.AllowUserToResizeRows = false;
            dgvVatTu.ReadOnly = true;
            dgvVatTu.Font = new Font("Segoe UI", 10f);
            dgvVatTu.EnableHeadersVisualStyles = false;
            dgvVatTu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvVatTu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 248);
            dgvVatTu.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 90);
            dgvVatTu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvVatTu.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 0, 0, 0);
            dgvVatTu.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 248);
            dgvVatTu.ColumnHeadersHeight = 48;

            dgvVatTu.DefaultCellStyle.BackColor = Color.White;
            dgvVatTu.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 60);
            dgvVatTu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 240, 255);
            dgvVatTu.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 60);
            dgvVatTu.DefaultCellStyle.Padding = new Padding(12, 0, 0, 0);
            dgvVatTu.RowTemplate.Height = 52;
            dgvVatTu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 254);

            dgvVatTu.Columns["colThaoTac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVatTu.Columns["colMa"].Width = 110;
            dgvVatTu.Columns["colTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvVatTu.Columns["colTen"].MinimumWidth = 150;
            dgvVatTu.Columns["colTL"].Width = 200;
            dgvVatTu.Columns["colTonKho"].Width = 180;
            dgvVatTu.Columns["colThaoTac"].Width = 100;
        }

        private void RefreshTable(List<VatTuInfo> data)
        {
            dgvVatTu.Rows.Clear();
            foreach (var v in data)
                dgvVatTu.Rows.Add(v.Ma, v.Ten, v.TrongLuong, v.TonKho, "✏  🗑");
        }

        private void dgvVatTu_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvVatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 4) return;

            string ma = dgvVatTu.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            int idx = dsVatTu.FindIndex(v => v.Ma == ma);
            if (idx < 0) return;

            var cellRect = dgvVatTu.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            var mousePos = dgvVatTu.PointToClient(MousePosition);
            bool isEdit = mousePos.X < cellRect.Left + cellRect.Width / 2;

            if (isEdit)
                ShowEditDialog(idx);
            else
                DeleteVatTu(idx);
        }

        private void ShowEditDialog(int idx)
        {
            var vt = dsVatTu[idx];
            var form = new Form
            {
                Text = "Sửa vật tư",
                Size = new Size(420, 300),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                Font = new Font("Segoe UI", 10f)
            };

            var lblTen = new Label { Text = "Tên vật tư:", Left = 20, Top = 20, Width = 140, AutoSize = false, Height = 25 };
            var lblTL = new Label { Text = "Trọng lượng/đv (kg):", Left = 20, Top = 70, Width = 140, AutoSize = false, Height = 25 };
            var lblTK = new Label { Text = "Số lượng tồn kho:", Left = 20, Top = 120, Width = 140, AutoSize = false, Height = 25 };

            var txtTen = new TextBox { Left = 170, Top = 17, Width = 210, Text = vt.Ten };
            var txtTL = new TextBox { Left = 170, Top = 67, Width = 210, Text = vt.TrongLuong.ToString() };
            var txtTK = new TextBox { Left = 170, Top = 117, Width = 210, Text = vt.TonKho.ToString() };

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
                if (!double.TryParse(txtTL.Text, out double tl) || tl <= 0) { MessageBox.Show("Trọng lượng không hợp lệ!"); return; }
                if (!int.TryParse(txtTK.Text, out int tk) || tk < 0) { MessageBox.Show("Số lượng không hợp lệ!"); return; }
                dsVatTu[idx].Ten = txtTen.Text.Trim();
                dsVatTu[idx].TrongLuong = tl;
                dsVatTu[idx].TonKho = tk;
                form.DialogResult = DialogResult.OK;
            };
            btnHuy.Click += (s, ev) => form.Close();
            form.Controls.AddRange(new Control[] { lblTen, lblTL, lblTK, txtTen, txtTL, txtTK, btnLuu, btnHuy });

            if (form.ShowDialog() == DialogResult.OK) Search();
        }

        private void DeleteVatTu(int idx)
        {
            if (MessageBox.Show($"Xóa vật tư '{dsVatTu[idx].Ten}'?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dsVatTu.RemoveAt(idx);
                Search();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            var form = new Form
            {
                Text = "Thêm vật tư mới",
                Size = new Size(420, 340),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                Font = new Font("Segoe UI", 10f)
            };

            var lblMa = new Label { Text = "Mã VT:", Left = 20, Top = 20, Width = 140, AutoSize = false, Height = 25 };
            var lblTen = new Label { Text = "Tên vật tư:", Left = 20, Top = 70, Width = 140, AutoSize = false, Height = 25 };
            var lblTL = new Label { Text = "Trọng lượng/đv (kg):", Left = 20, Top = 120, Width = 140, AutoSize = false, Height = 25 };
            var lblTK = new Label { Text = "Số lượng tồn kho:", Left = 20, Top = 170, Width = 140, AutoSize = false, Height = 25 };

            var txtMa = new TextBox { Left = 170, Top = 17, Width = 210 };
            var txtTen = new TextBox { Left = 170, Top = 67, Width = 210 };
            var txtTL = new TextBox { Left = 170, Top = 117, Width = 210 };
            var txtTK = new TextBox { Left = 170, Top = 167, Width = 210 };

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
                if (dsVatTu.Any(v => v.Ma == txtMa.Text.Trim())) { MessageBox.Show("Mã đã tồn tại!"); return; }
                if (string.IsNullOrWhiteSpace(txtTen.Text)) { MessageBox.Show("Tên không được để trống!"); return; }
                if (!double.TryParse(txtTL.Text, out double tl) || tl <= 0) { MessageBox.Show("Trọng lượng không hợp lệ!"); return; }
                if (!int.TryParse(txtTK.Text, out int tk) || tk < 0) { MessageBox.Show("Số lượng không hợp lệ!"); return; }

                dsVatTu.Add(new VatTuInfo { Ma = txtMa.Text.Trim(), Ten = txtTen.Text.Trim(), TrongLuong = tl, TonKho = tk });
                form.DialogResult = DialogResult.OK;
            };
            btnHuy.Click += (s, ev) => form.Close();
            form.Controls.AddRange(new Control[] { lblMa, lblTen, lblTL, lblTK, txtMa, txtTen, txtTL, txtTK, btnLuu, btnHuy });

            if (form.ShowDialog() == DialogResult.OK) Search();
        }
    }
}