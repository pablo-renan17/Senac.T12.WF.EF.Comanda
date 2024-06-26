
using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
            CriarUsuarioAdmin();
        }

        private void CriarUsuarioAdmin()
        {
            //acessa o banco de dados
            using(var banco = new ComandaContexto())
            {
                //cria um novo usuario
                var novoUsuario = new Usuario();
                novoUsuario.nomeUsuario = "admin";
                novoUsuario.emailUsuario = "admin@example.com";
                novoUsuario.senhaUsuario = "admin";

                //'banco, adicione na colecao usuario um novo usuario, por favor'
                banco.Usuarios.Add(novoUsuario);

                //confirmar a adição
                banco.SaveChanges();
            }
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
