namespace SistemaDeComandas.Forms
{
    partial class FrmPrincipal
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
            btnUsuarios = new ReaLTaiizor.Forms.NightForm();
            btnUsuario = new ReaLTaiizor.Controls.NightButton();
            btnPedidoCozinha = new ReaLTaiizor.Controls.NightButton();
            btnComanda = new ReaLTaiizor.Controls.NightButton();
            btnCardapio = new ReaLTaiizor.Controls.NightButton();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            nightTextBox1 = new ReaLTaiizor.Controls.NightTextBox();
            btnUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(40, 48, 51);
            btnUsuarios.Controls.Add(btnUsuario);
            btnUsuarios.Controls.Add(btnPedidoCozinha);
            btnUsuarios.Controls.Add(btnComanda);
            btnUsuarios.Controls.Add(btnCardapio);
            btnUsuarios.Controls.Add(nightControlBox1);
            btnUsuarios.Controls.Add(nightTextBox1);
            btnUsuarios.Dock = DockStyle.Fill;
            btnUsuarios.DrawIcon = false;
            btnUsuarios.Font = new Font("Segoe UI", 9F);
            btnUsuarios.HeadColor = Color.FromArgb(50, 58, 61);
            btnUsuarios.Location = new Point(0, 0);
            btnUsuarios.MinimumSize = new Size(100, 42);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(0, 31, 0, 0);
            btnUsuarios.RightToLeft = RightToLeft.Yes;
            btnUsuarios.Size = new Size(800, 450);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.TabStop = false;
            btnUsuarios.Text = "FrmPrincipal";
            btnUsuarios.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            btnUsuarios.TitleBarTextColor = Color.Gainsboro;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.Transparent;
            btnUsuario.DialogResult = DialogResult.None;
            btnUsuario.Font = new Font("Segoe UI", 10F);
            btnUsuario.ForeColor = Color.FromArgb(242, 93, 89);
            btnUsuario.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnUsuario.HoverForeColor = Color.White;
            btnUsuario.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnUsuario.Location = new Point(397, 273);
            btnUsuario.MinimumSize = new Size(144, 47);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnUsuario.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnUsuario.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnUsuario.PressedForeColor = Color.White;
            btnUsuario.Radius = 20;
            btnUsuario.Size = new Size(299, 89);
            btnUsuario.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnUsuario.TabIndex = 5;
            btnUsuario.Text = "Usuários";
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.BackColor = Color.Transparent;
            btnPedidoCozinha.DialogResult = DialogResult.None;
            btnPedidoCozinha.Font = new Font("Segoe UI", 10F);
            btnPedidoCozinha.ForeColor = Color.FromArgb(242, 93, 89);
            btnPedidoCozinha.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnPedidoCozinha.HoverForeColor = Color.White;
            btnPedidoCozinha.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnPedidoCozinha.Location = new Point(87, 273);
            btnPedidoCozinha.MinimumSize = new Size(144, 47);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnPedidoCozinha.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnPedidoCozinha.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnPedidoCozinha.PressedForeColor = Color.White;
            btnPedidoCozinha.Radius = 20;
            btnPedidoCozinha.Size = new Size(284, 89);
            btnPedidoCozinha.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnPedidoCozinha.TabIndex = 4;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.Transparent;
            btnComanda.DialogResult = DialogResult.None;
            btnComanda.Font = new Font("Segoe UI", 10F);
            btnComanda.ForeColor = Color.FromArgb(242, 93, 89);
            btnComanda.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnComanda.HoverForeColor = Color.White;
            btnComanda.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnComanda.Location = new Point(397, 183);
            btnComanda.MinimumSize = new Size(144, 47);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnComanda.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnComanda.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnComanda.PressedForeColor = Color.White;
            btnComanda.Radius = 20;
            btnComanda.Size = new Size(299, 85);
            btnComanda.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnComanda.TabIndex = 3;
            btnComanda.Text = "Comanda";
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.Transparent;
            btnCardapio.DialogResult = DialogResult.None;
            btnCardapio.Font = new Font("Segoe UI", 10F);
            btnCardapio.ForeColor = Color.FromArgb(242, 93, 89);
            btnCardapio.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnCardapio.HoverForeColor = Color.White;
            btnCardapio.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnCardapio.Location = new Point(87, 183);
            btnCardapio.MinimumSize = new Size(144, 47);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnCardapio.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnCardapio.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnCardapio.PressedForeColor = Color.White;
            btnCardapio.Radius = 20;
            btnCardapio.Size = new Size(284, 85);
            btnCardapio.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnCardapio.TabIndex = 2;
            btnCardapio.Text = "Cardápio";
            btnCardapio.Click += btnCardapio_Click;
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
            nightControlBox1.TabIndex = 1;
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
            nightTextBox1.Location = new Point(52, 79);
            nightTextBox1.MaxLength = 32767;
            nightTextBox1.Multiline = false;
            nightTextBox1.Name = "nightTextBox1";
            nightTextBox1.ReadOnly = false;
            nightTextBox1.ShortcutsEnabled = true;
            nightTextBox1.ShowBottomBorder = true;
            nightTextBox1.ShowTopBorder = true;
            nightTextBox1.Size = new Size(681, 50);
            nightTextBox1.TabIndex = 0;
            nightTextBox1.Text = "🔍";
            nightTextBox1.TextAlignment = HorizontalAlignment.Left;
            nightTextBox1.UseSystemPasswordChar = false;
            nightTextBox1.Watermark = "";
            nightTextBox1.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 860);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            TransparencyKey = Color.Fuchsia;
            btnUsuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm btnUsuarios;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.NightTextBox nightTextBox1;
        private ReaLTaiizor.Controls.NightButton btnUsuario;
        private ReaLTaiizor.Controls.NightButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.NightButton btnComanda;
        private ReaLTaiizor.Controls.NightButton btnCardapio;
    }
}