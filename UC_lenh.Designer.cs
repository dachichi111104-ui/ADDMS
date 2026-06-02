namespace ADDMS2
{
    partial class UC_lenh
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
            label15 = new Label();
            label16 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            panelMap = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(0, 0, 64);
            label15.Location = new Point(23, 19);
            label15.Name = "label15";
            label15.Size = new Size(448, 38);
            label15.TabIndex = 14;
            label15.Text = "LẬP LỆNH GIAO HÀNG CỨU TRỢ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(23, 66);
            label16.Name = "label16";
            label16.Size = new Size(336, 25);
            label16.TabIndex = 15;
            label16.Text = "Tạo và quản lý Drone giao hàng tự động";
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoRoundedCorners = true;
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.White;
            guna2Panel1.BorderRadius = 170;
            guna2Panel1.Controls.Add(panelMap);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(comboBox1);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(23, 113);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(512, 342);
            guna2Panel1.TabIndex = 16;
            // 
            // panelMap
            // 
            panelMap.Location = new Point(21, 167);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(465, 150);
            panelMap.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 139);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 3;
            label1.Text = "Chọn điểm đến";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Drone001 - DJI Matrice 300", "Drone002 - Parrot Anafi" });
            comboBox1.Location = new Point(21, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "--Chọn Drone--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 62);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 1;
            label5.Text = "Chọn Drone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 22);
            label3.Name = "label3";
            label3.Size = new Size(225, 28);
            label3.TabIndex = 0;
            label3.Text = "THÔNG TIN LỆNH BAY";
            // 
            // UC_lenh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(guna2Panel1);
            Controls.Add(label16);
            Controls.Add(label15);
            Name = "UC_lenh";
            Size = new Size(1159, 578);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Label label16;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label5;
        private Label label3;
        private ComboBox comboBox1;
        private Panel panelMap;
        private Label label1;
    }
}
