
namespace SistemaDeComandas.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            //cria uma variavel do formConta
            var frmCardapio = new FrmCardapio();
            //exibe a tela form contra
            frmCardapio.Show();
            //incrementar o valor da variavel contador
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.Show();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            var frmPedidoCozinha = new FrmPedidoCozinha();
            frmPedidoCozinha.Show();
        }
    }
}
