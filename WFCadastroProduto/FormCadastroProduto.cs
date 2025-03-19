using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        public void LimparFormulario()
        {
            txt_codigo.Clear();
            cbx_categoria.SelectedIndex = 0;
            txt_nomeproduto.Clear();
            nud_preco.Value = 0;
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            return;
        }


        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            string codigo;
            if (txt_codigo.Text == "")
            {
                Erro("Campo Codigo não informado!");
                return;
            }
            else
            {
                codigo = txt_codigo.Text;
            }

            string categoria;
            if (cbx_categoria.Text == "")
            {
                Erro("Campo Categoria não selecionado");
                return;
            }
            else
            {
                categoria = cbx_categoria.Text;
            }
            string nome;
            if (txt_nomeproduto.Text == "")
            {
                Erro("Campo Nome não selecionado");
                return;
            }
            else
            {
                nome = txt_nomeproduto.Text;
            }
            string preco;
            if (nud_preco.Text == "")
            {
                Erro("Campo Preço não selecionado");
                return;
            }
            else
            {
                preco = nud_preco.Text;
            }
            string observacao;
            if (rtb_observacao.Text == "")
            {
                Erro("Campo Observação não selecionado");
                return;
            }
            else
            {
                observacao = rtb_observacao.Text;
            }

            Produto p1 = new Produto();
            p1.Codigo = Convert.ToInt32(txt_codigo.Text);
            p1.Categoria = cbx_categoria.Text;
            p1.Nome = txt_nomeproduto.Text;
            p1.Preco = Convert.ToDouble(nud_preco.Text);
            p1.DataVencimento = DateTime.Now;
            p1.Observacao = rtb_observacao.Text;

            Produto.ListaProdutos.Add(p1);

            MessageBox.Show("Cadastro realizado com Sucesso!", "Info",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();

        }

       
    }
}
