namespace SistemaDeComandas.Forms
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            nightButton3 = new ReaLTaiizor.Controls.NightButton();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            nightTextBox2 = new ReaLTaiizor.Controls.NightTextBox();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            nightTextBox1 = new ReaLTaiizor.Controls.NightTextBox();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            nightForm1.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(nightButton3);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(800, 385);
            nightForm1.TabIndex = 0;
            nightForm1.Text = "FrmLogin";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // nightButton3
            // 
            nightButton3.BackColor = Color.Transparent;
            nightButton3.DialogResult = DialogResult.None;
            nightButton3.Font = new Font("Segoe UI", 10F);
            nightButton3.ForeColor = Color.FromArgb(128, 255, 128);
            nightButton3.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton3.HoverForeColor = Color.White;
            nightButton3.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton3.Location = new Point(615, 293);
            nightButton3.MinimumSize = new Size(144, 47);
            nightButton3.Name = "nightButton3";
            nightButton3.NormalBackColor = Color.FromArgb(128, 255, 128);
            nightButton3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton3.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton3.PressedForeColor = Color.White;
            nightButton3.Radius = 20;
            nightButton3.Size = new Size(144, 47);
            nightButton3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton3.TabIndex = 12;
            nightButton3.Text = "> Entrar";
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 10;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 2F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(nightTextBox2);
            cyberGroupBox1.Controls.Add(nightLabel2);
            cyberGroupBox1.Controls.Add(nightTextBox1);
            cyberGroupBox1.Controls.Add(nightLabel1);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(41, 52);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 20;
            cyberGroupBox1.Size = new Size(718, 209);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 1;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // nightTextBox2
            // 
            nightTextBox2.ActiveBorderColor = Color.FromArgb(242, 93, 89);
            nightTextBox2.BackColor = Color.FromArgb(43, 48, 67);
            nightTextBox2.BaseBackColor = Color.FromArgb(43, 48, 67);
            nightTextBox2.ColorBordersOnEnter = true;
            nightTextBox2.DisableBorderColor = Color.FromArgb(60, 63, 80);
            nightTextBox2.Font = new Font("Segoe UI", 10F);
            nightTextBox2.ForeColor = Color.FromArgb(127, 131, 140);
            nightTextBox2.Image = null;
            nightTextBox2.Location = new Point(29, 140);
            nightTextBox2.MaxLength = 32767;
            nightTextBox2.Multiline = false;
            nightTextBox2.Name = "nightTextBox2";
            nightTextBox2.ReadOnly = false;
            nightTextBox2.ShortcutsEnabled = true;
            nightTextBox2.ShowBottomBorder = true;
            nightTextBox2.ShowTopBorder = true;
            nightTextBox2.Size = new Size(651, 50);
            nightTextBox2.TabIndex = 5;
            nightTextBox2.Text = "ㅤ";
            nightTextBox2.TextAlignment = HorizontalAlignment.Left;
            nightTextBox2.UseSystemPasswordChar = false;
            nightTextBox2.Watermark = "";
            nightTextBox2.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI", 9F);
            nightLabel2.ForeColor = Color.White;
            nightLabel2.Location = new Point(29, 112);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(39, 15);
            nightLabel2.TabIndex = 4;
            nightLabel2.Text = "Senha";
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
            nightTextBox1.Location = new Point(29, 45);
            nightTextBox1.MaxLength = 32767;
            nightTextBox1.Multiline = false;
            nightTextBox1.Name = "nightTextBox1";
            nightTextBox1.ReadOnly = false;
            nightTextBox1.ShortcutsEnabled = true;
            nightTextBox1.ShowBottomBorder = true;
            nightTextBox1.ShowTopBorder = true;
            nightTextBox1.Size = new Size(651, 50);
            nightTextBox1.TabIndex = 3;
            nightTextBox1.Text = "ㅤ";
            nightTextBox1.TextAlignment = HorizontalAlignment.Left;
            nightTextBox1.UseSystemPasswordChar = false;
            nightTextBox1.Watermark = "";
            nightTextBox1.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 9F);
            nightLabel1.ForeColor = Color.White;
            nightLabel1.Location = new Point(29, 18);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(40, 15);
            nightLabel1.TabIndex = 2;
            nightLabel1.Text = "Nome";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 385);
            Controls.Add(cyberGroupBox1);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 860);
            MinimumSize = new Size(261, 61);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.NightTextBox nightTextBox2;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.NightTextBox nightTextBox1;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.NightButton nightButton3;
    }
}
