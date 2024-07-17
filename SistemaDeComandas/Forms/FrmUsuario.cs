
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
        bool isFirstId = true;
        private bool ehNovoUsuario;

        public FrmUsuario()
        {
            InitializeComponent();
            CarregarUsuario();
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaContexto())
            {
                //buscar o usuario pelo ID
                var usuario = banco.Usuarios.First(usuario =>
                    usuario.idUsuario == int.Parse(txtId.Text));

                // SELECT * FROM usuarios where id = **txtId**

                //atualizar as propriedades
                usuario.nomeUsuario = txtNome.Text;
                usuario.emailUsuario = txtEmail.Text;
                usuario.senhaUsuario = txtSenha.Text;

                //salvar as alterações
                banco.SaveChanges();
                MessageBox.Show("Usuario atualizado com sucesso");
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
                MessageBox.Show("Usuario criado com sucesso");
            }
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

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                txtId.Text = "#";
                isFirstId = true;
            }
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (isFirstId)
            {
                txtId.Text = string.Empty;
                isFirstId = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovoUsuario)
                CriarUsuario();
            else
                AtualizarUsuario();

            LimparCampos();
            DesabilitarCampos();
            CarregarUsuario();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void CarregarUsuario()
        {
            using (var banco = new ComandaContexto())
            {
                //consulta todos os usuarios do banco(SELECT * FROM Usuarios)
                var usuarios = banco.Usuarios.ToList();
                dgvUsuario.DataSource = null;
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

            // informa que esta cadastrando um novo usuario
            ehNovoUsuario = true;
            // limpa os campos
            LimparCampos();

            HabilitaCampos();
        }

        private void HabilitaCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ehNovoUsuario = false;

            HabilitaCampos();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // variavel e é o evento de clique da celula
            // RowIndex é a pos das linhas, linha 0 nao existe
            // verificar se a linha foi selecionada
            if(e.RowIndex >= 0)
            {  
                // obter a linha
                var linha = dgvUsuario.Rows[e.RowIndex];

                // popular os campos da tela de acordo com a linha
                txtId.Text = linha.Cells["idUsuario"].Value.ToString();
                txtNome.Text = linha.Cells["nomeUsuario"].Value.ToString();
                txtEmail.Text = linha.Cells["emailUsuario"].Value.ToString();
                txtSenha.Text = linha.Cells["senhaUsuario"].Value.ToString();
            }


        }
    }
}
