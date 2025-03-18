using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastro_novo
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }


        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Login = txt_login.Text;
            usuario.Senha = txt_senha.Text;
            usuario.DataCadastro = DateTime.Now;
            usuario.Codigo = Usuario.ListaUsuarios.Count;

            if (txt_confirmasenha.Text == txt_senha.Text)
            {
                Usuario.ListaUsuarios.Add(usuario);
                MessageBox.Show("Cadastrado com sucesso");

            }
            else
            {
                MessageBox.Show("Senhas incompativeis. Tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
