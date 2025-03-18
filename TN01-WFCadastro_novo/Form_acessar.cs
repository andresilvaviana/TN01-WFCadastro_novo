using System.Reflection.Metadata.Ecma335;
using static TN01_WFCadastro_novo.Usuario;

namespace TN01_WFCadastro_novo
{
    public partial class Form_acessar : Form
    {
        public Form_acessar()
        {
            InitializeComponent();

        }

        private void Form_acessar_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Codigo = 1000;
            usuario.Login = "user";
            usuario.Senha = "123456";
            usuario.DataCadastro = Convert.ToDateTime("10/01/2025 18:30");
            //us.DataCadastro = DateTime.Parse("01/01/2000");
            Usuario.ListaUsuarios.Add(usuario);

        }

        public void Erro (string mensagem)

        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK,
            MessageBoxIcon.Error);

            return;
        }
            

        private void btn_acessar_Click(object sender, EventArgs e)
        {

        if (string.IsNullOrEmpty(txt_login.Text))
        {
            Erro("O campo LOGIN não pode estar vazio!");
            return;
        }
        if (string.IsNullOrEmpty(txt_senha.Text))
        {
            Erro("O campo SENHA não pode estar vazio!");
            return;
        }

            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txt_login.Text)
                {
                    if (user.Senha == txt_senha.Text)
                    {
                        MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        

                        FormMain form = new FormMain();
                        form.ShowDialog();
                        
                        return;
                        
                    }
                }

            }

            MessageBox.Show("Usuario Não Autenticado!",
                        "Erro!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);


            txt_login.Clear();
            txt_senha.Clear();

            return;

        }
        
        private void txt_login_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
