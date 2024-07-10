
using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas.Forms
{
    public partial class FrmUsuario : Form
    {

        /// <summary>
        /// 
        /// </summary>
        /// 

        bool isFirstNome = true;
        bool isFirstEmail = true;
        bool isFirstSenha = true;
        private bool ehNovoUsuario;

        public FrmUsuario()
        {
            InitializeComponent();
            CarregarUsuario();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (isFirstNome)
            {
                txtNome.Text = string.Empty;
                isFirstNome = false;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (isFirstEmail)
            {
                txtEmail.Text = string.Empty;
                isFirstEmail = false;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (isFirstSenha)
            {
                txtSenha.Text = string.Empty;
                isFirstSenha = false;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                txtNome.Text = "John Doe";
                isFirstNome = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "johndoe@example.com";
                isFirstEmail = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == string.Empty)
            {
                txtSenha.Text = "********";
                isFirstSenha = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ehNovoUsuario)
                CriarUsuario();
            else
                AtualizarUsuario();
        }

        private void AtualizarUsuario()
        {
            using(var banco = new ComandaContexto())
            {
                //buscar o usuario pelo ID
                var usuario = banco.Usuarios.First( usuario =>
                    usuario.idUsuario == 1);

                //atualizar as propriedades
                usuario.nomeUsuario = txtNome.Text;
                usuario.emailUsuario = txtEmail.Text;
                usuario.senhaUsuario = txtSenha.Text;

                //salvar as alterações
                banco.SaveChanges();
            }

        }

        private void CriarUsuario()
        {
            using (var banco = new ComandaContexto())
            {
                if (txtNome.Text == string.Empty || txtNome.Text == "John Doe")
                {
                    MessageBox.Show("Preencha o Nome");
                    return;
                }
                if (txtEmail.Text == string.Empty || txtEmail.Text == "johndoe@example.com")
                {
                    MessageBox.Show("Preencha o Email");
                    return;
                }
                if (txtSenha.Text == string.Empty || txtSenha.Text == "********")
                {
                    MessageBox.Show("Preencha a Senha");
                    return;
                }
                //criar objeto usuario
                var novoUsuario = new Usuario();

                novoUsuario.nomeUsuario = txtNome.Text;
                novoUsuario.emailUsuario = txtEmail.Text;
                novoUsuario.senhaUsuario = txtSenha.Text;

                //adicionar esse objeto no contexto do banco
                banco.Usuarios.Add(novoUsuario);

                //salvar as alterações
                banco.SaveChanges();
            }
        }

        private void CarregarUsuario()
        {
            using (var banco = new ComandaContexto())
            {
                //consulta todos os usuarios do banco(SELECT * FROM Usuarios)
                var usuarios = banco.Usuarios.ToList();
                //origem dos dados do data grid view sao os usuarios
                dgvUsuario.DataSource = usuarios;
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovoUsuario = true;

            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ehNovoUsuario = false;
        }
    }
}
