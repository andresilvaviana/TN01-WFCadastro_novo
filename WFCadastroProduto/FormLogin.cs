namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

       public void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Login = "admin";
            us.Senha = "123456";
            us.DtCadastro = Convert.ToDateTime("18/03/2025 18:30");
            Usuario.ListaUsuarios.Add(us);
       }

        public void Erro(string mensagem)
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
                            "Bem Vindo Meu Caro!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


                        FormMenu form = new FormMenu();
                        form.ShowDialog();
                        
                        //lipa os dados dos componentes
                        txt_login.Clear();
                        txt_senha.Clear();

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

        private void chb_motrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_motrarsenha.Checked)
            {
                txt_senha.PasswordChar = '\0';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
        }
    }
}
