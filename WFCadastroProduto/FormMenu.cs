using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnu_cadastrar_Click(object sender, EventArgs e)
        {
        }

        private void mnu_lista_Click(object sender, EventArgs e)
        {
            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();
        }

        private void mnu_sair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnu_produto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new();
            form.ShowDialog();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        private void mnu_usuario_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario form = new();
            form.ShowDialog();
        }
    }
}
