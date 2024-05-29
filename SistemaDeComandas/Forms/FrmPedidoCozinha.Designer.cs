namespace SistemaDeComandas.Forms
{
    partial class FrmPedidoCozinha
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
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            btnVoltar = new ReaLTaiizor.Controls.NightButton();
            nightForm1.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(btnVoltar);
            nightForm1.Controls.Add(nightLabel1);
            nightForm1.Controls.Add(nightPanel1);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(800, 512);
            nightForm1.TabIndex = 0;
            nightForm1.Text = "FrmPedidoCozinha";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 9F);
            nightLabel1.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel1.Location = new Point(37, 46);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(49, 15);
            nightLabel1.TabIndex = 18;
            nightLabel1.Text = "Pedidos";
            // 
            // nightPanel1
            // 
            nightPanel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel1.LeftSideColor = Color.FromArgb(242, 93, 89);
            nightPanel1.Location = new Point(37, 64);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel1.Size = new Size(731, 386);
            nightPanel1.TabIndex = 17;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.DialogResult = DialogResult.None;
            btnVoltar.Font = new Font("Segoe UI", 10F);
            btnVoltar.ForeColor = Color.FromArgb(242, 93, 89);
            btnVoltar.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnVoltar.HoverForeColor = Color.White;
            btnVoltar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnVoltar.Location = new Point(37, 456);
            btnVoltar.MinimumSize = new Size(144, 47);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnVoltar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnVoltar.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnVoltar.PressedForeColor = Color.White;
            btnVoltar.Radius = 20;
            btnVoltar.Size = new Size(144, 47);
            btnVoltar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "< Voltar";
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmPedidoCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 860);
            Name = "FrmPedidoCozinha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPedidoCozinha";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            nightForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.NightButton btnVoltar;
    }
}