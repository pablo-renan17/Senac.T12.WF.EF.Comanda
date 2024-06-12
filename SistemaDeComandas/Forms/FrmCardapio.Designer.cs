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
            btnVoltar = new ReaLTaiizor.Controls.NightButton();
            btnEditar = new ReaLTaiizor.Controls.NightButton();
            btnExcluir = new ReaLTaiizor.Controls.NightButton();
            btnAdicionarItem = new ReaLTaiizor.Controls.NightButton();
            dgvCardapio = new ReaLTaiizor.Controls.NightPanel();
            txtPesquisa = new ReaLTaiizor.Controls.NightTextBox();
            nightForm1.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(btnVoltar);
            nightForm1.Controls.Add(btnEditar);
            nightForm1.Controls.Add(btnExcluir);
            nightForm1.Controls.Add(btnAdicionarItem);
            nightForm1.Controls.Add(dgvCardapio);
            nightForm1.Controls.Add(txtPesquisa);
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
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.DialogResult = DialogResult.None;
            btnVoltar.Font = new Font("Segoe UI", 10F);
            btnVoltar.ForeColor = Color.FromArgb(242, 93, 89);
            btnVoltar.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnVoltar.HoverForeColor = Color.White;
            btnVoltar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnVoltar.Location = new Point(58, 451);
            btnVoltar.MinimumSize = new Size(144, 47);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnVoltar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnVoltar.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnVoltar.PressedForeColor = Color.White;
            btnVoltar.Radius = 20;
            btnVoltar.Size = new Size(144, 47);
            btnVoltar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "< Voltar";
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.DialogResult = DialogResult.None;
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ForeColor = Color.FromArgb(128, 128, 255);
            btnEditar.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnEditar.HoverForeColor = Color.White;
            btnEditar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnEditar.Location = new Point(606, 451);
            btnEditar.MinimumSize = new Size(144, 47);
            btnEditar.Name = "btnEditar";
            btnEditar.NormalBackColor = Color.FromArgb(128, 128, 255);
            btnEditar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnEditar.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnEditar.PressedForeColor = Color.White;
            btnEditar.Radius = 20;
            btnEditar.Size = new Size(144, 47);
            btnEditar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnEditar.TabIndex = 5;
            btnEditar.Text = "# Editar";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.DialogResult = DialogResult.None;
            btnExcluir.Font = new Font("Segoe UI", 10F);
            btnExcluir.ForeColor = Color.FromArgb(242, 93, 89);
            btnExcluir.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnExcluir.HoverForeColor = Color.White;
            btnExcluir.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnExcluir.Location = new Point(446, 451);
            btnExcluir.MinimumSize = new Size(144, 47);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NormalBackColor = Color.FromArgb(242, 93, 89);
            btnExcluir.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnExcluir.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnExcluir.PressedForeColor = Color.White;
            btnExcluir.Radius = 20;
            btnExcluir.Size = new Size(144, 47);
            btnExcluir.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "X Excluir";
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackColor = Color.Transparent;
            btnAdicionarItem.DialogResult = DialogResult.None;
            btnAdicionarItem.Font = new Font("Segoe UI", 10F);
            btnAdicionarItem.ForeColor = Color.FromArgb(128, 255, 128);
            btnAdicionarItem.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnAdicionarItem.HoverForeColor = Color.White;
            btnAdicionarItem.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnAdicionarItem.Location = new Point(58, 135);
            btnAdicionarItem.MinimumSize = new Size(144, 47);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.NormalBackColor = Color.Lime;
            btnAdicionarItem.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAdicionarItem.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAdicionarItem.PressedForeColor = Color.White;
            btnAdicionarItem.Radius = 20;
            btnAdicionarItem.Size = new Size(144, 47);
            btnAdicionarItem.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAdicionarItem.TabIndex = 3;
            btnAdicionarItem.Text = "+ Item Cardápio";
            // 
            // dgvCardapio
            // 
            dgvCardapio.ForeColor = Color.FromArgb(250, 250, 250);
            dgvCardapio.LeftSideColor = Color.FromArgb(242, 93, 89);
            dgvCardapio.Location = new Point(58, 203);
            dgvCardapio.Name = "dgvCardapio";
            dgvCardapio.RightSideColor = Color.FromArgb(41, 44, 61);
            dgvCardapio.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            dgvCardapio.Size = new Size(692, 222);
            dgvCardapio.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.ActiveBorderColor = Color.FromArgb(242, 93, 89);
            txtPesquisa.BackColor = Color.FromArgb(43, 48, 67);
            txtPesquisa.BaseBackColor = Color.FromArgb(43, 48, 67);
            txtPesquisa.ColorBordersOnEnter = true;
            txtPesquisa.DisableBorderColor = Color.FromArgb(60, 63, 80);
            txtPesquisa.Font = new Font("Segoe UI", 10F);
            txtPesquisa.ForeColor = Color.FromArgb(127, 131, 140);
            txtPesquisa.Image = null;
            txtPesquisa.Location = new Point(58, 62);
            txtPesquisa.MaxLength = 32767;
            txtPesquisa.Multiline = false;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.ReadOnly = false;
            txtPesquisa.ShortcutsEnabled = true;
            txtPesquisa.ShowBottomBorder = true;
            txtPesquisa.ShowTopBorder = true;
            txtPesquisa.Size = new Size(692, 50);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.Text = "Pesquisar 🔍";
            txtPesquisa.TextAlignment = HorizontalAlignment.Left;
            txtPesquisa.UseSystemPasswordChar = false;
            txtPesquisa.Watermark = "";
            txtPesquisa.WatermarkColor = Color.FromArgb(116, 120, 129);
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
        private ReaLTaiizor.Controls.NightTextBox txtPesquisa;
        private ReaLTaiizor.Controls.NightButton btnAdicionarItem;
        private ReaLTaiizor.Controls.NightPanel dgvCardapio;
        private ReaLTaiizor.Controls.NightButton btnEditar;
        private ReaLTaiizor.Controls.NightButton btnExcluir;
        private ReaLTaiizor.Controls.NightButton btnVoltar;
    }
}