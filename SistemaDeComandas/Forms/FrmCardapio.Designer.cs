namespace SistemaDeComandas.Forms
{
    partial class FrmCardapio
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
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            nightTextBox1 = new ReaLTaiizor.Controls.NightTextBox();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            nightButton1 = new ReaLTaiizor.Controls.NightButton();
            nightButton2 = new ReaLTaiizor.Controls.NightButton();
            nightButton3 = new ReaLTaiizor.Controls.NightButton();
            nightForm1.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(nightButton3);
            nightForm1.Controls.Add(nightButton2);
            nightForm1.Controls.Add(nightButton1);
            nightForm1.Controls.Add(nightPanel1);
            nightForm1.Controls.Add(nightTextBox1);
            nightForm1.Controls.Add(nightControlBox1);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(800, 510);
            nightForm1.TabIndex = 0;
            nightForm1.Text = "FrmCardapio";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(661, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // nightTextBox1
            // 
            nightTextBox1.ActiveBorderColor = Color.FromArgb(242, 93, 89);
            nightTextBox1.BackColor = Color.FromArgb(43, 48, 67);
            nightTextBox1.BaseBackColor = Color.FromArgb(43, 48, 67);
            nightTextBox1.ColorBordersOnEnter = true;
            nightTextBox1.DisableBorderColor = Color.FromArgb(60, 63, 80);
            nightTextBox1.Font = new Font("Segoe UI", 10F);
            nightTextBox1.ForeColor = Color.FromArgb(127, 131, 140);
            nightTextBox1.Image = null;
            nightTextBox1.Location = new Point(58, 62);
            nightTextBox1.MaxLength = 32767;
            nightTextBox1.Multiline = false;
            nightTextBox1.Name = "nightTextBox1";
            nightTextBox1.ReadOnly = false;
            nightTextBox1.ShortcutsEnabled = true;
            nightTextBox1.ShowBottomBorder = true;
            nightTextBox1.ShowTopBorder = true;
            nightTextBox1.Size = new Size(692, 50);
            nightTextBox1.TabIndex = 1;
            nightTextBox1.Text = "Pesquisar 🔍";
            nightTextBox1.TextAlignment = HorizontalAlignment.Left;
            nightTextBox1.UseSystemPasswordChar = false;
            nightTextBox1.Watermark = "";
            nightTextBox1.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // nightPanel1
            // 
            nightPanel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel1.LeftSideColor = Color.FromArgb(242, 93, 89);
            nightPanel1.Location = new Point(58, 203);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel1.Size = new Size(692, 222);
            nightPanel1.TabIndex = 2;
            // 
            // nightButton1
            // 
            nightButton1.BackColor = Color.Transparent;
            nightButton1.DialogResult = DialogResult.None;
            nightButton1.Font = new Font("Segoe UI", 10F);
            nightButton1.ForeColor = Color.FromArgb(128, 255, 128);
            nightButton1.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton1.HoverForeColor = Color.White;
            nightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton1.Location = new Point(58, 135);
            nightButton1.MinimumSize = new Size(144, 47);
            nightButton1.Name = "nightButton1";
            nightButton1.NormalBackColor = Color.Lime;
            nightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton1.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton1.PressedForeColor = Color.White;
            nightButton1.Radius = 20;
            nightButton1.Size = new Size(144, 47);
            nightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton1.TabIndex = 3;
            nightButton1.Text = "+ Item Cardápio";
            // 
            // nightButton2
            // 
            nightButton2.BackColor = Color.Transparent;
            nightButton2.DialogResult = DialogResult.None;
            nightButton2.Font = new Font("Segoe UI", 10F);
            nightButton2.ForeColor = Color.FromArgb(242, 93, 89);
            nightButton2.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton2.HoverForeColor = Color.White;
            nightButton2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton2.Location = new Point(446, 451);
            nightButton2.MinimumSize = new Size(144, 47);
            nightButton2.Name = "nightButton2";
            nightButton2.NormalBackColor = Color.FromArgb(242, 93, 89);
            nightButton2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton2.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton2.PressedForeColor = Color.White;
            nightButton2.Radius = 20;
            nightButton2.Size = new Size(144, 47);
            nightButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton2.TabIndex = 4;
            nightButton2.Text = "X Excluir";
            // 
            // nightButton3
            // 
            nightButton3.BackColor = Color.Transparent;
            nightButton3.DialogResult = DialogResult.None;
            nightButton3.Font = new Font("Segoe UI", 10F);
            nightButton3.ForeColor = Color.FromArgb(128, 128, 255);
            nightButton3.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton3.HoverForeColor = Color.White;
            nightButton3.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton3.Location = new Point(606, 451);
            nightButton3.MinimumSize = new Size(144, 47);
            nightButton3.Name = "nightButton3";
            nightButton3.NormalBackColor = Color.FromArgb(128, 128, 255);
            nightButton3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton3.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton3.PressedForeColor = Color.White;
            nightButton3.Radius = 20;
            nightButton3.Size = new Size(144, 47);
            nightButton3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton3.TabIndex = 5;
            nightButton3.Text = "# Editar";
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 860);
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapio";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightTextBox nightTextBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.NightButton nightButton1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.NightButton nightButton3;
        private ReaLTaiizor.Controls.NightButton nightButton2;
    }
}