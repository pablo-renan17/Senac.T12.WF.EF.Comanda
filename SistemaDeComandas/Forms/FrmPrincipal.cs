
using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.BancoDeDados;

namespace SistemaDeComandas.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        //metodo para criar o banco de dados
        void CriarBancoDeDados()
        {
            //criando um novo contexto do banco
            using (var banco = new ComandaContexto())
            {
                //criar as tabelas do banco
                banco.Database.Migrate();
            }
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            //cria uma variavel do formConta
            var frmCardapio = new FrmCardapio();
            //exibe a tela form contra
            frmCardapio.ShowDialog();
            //incrementar o valor da variavel contador
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            var frmPedidoCozinha = new FrmPedidoCozinha();
            frmPedidoCozinha.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
        }
    }
}
