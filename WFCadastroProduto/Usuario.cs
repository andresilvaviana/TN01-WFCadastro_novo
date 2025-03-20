using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    
    public class Usuario
    {
        public Usuario(int codigo, string? login, string? senha, DateTime dtCadastro)
        {
            Codigo = codigo;
            Login = login;
            Senha = senha;
            DtCadastro = dtCadastro;
        }
        public Usuario() { }
        public int Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public DateTime DtCadastro { get; set; }

        public static List<Usuario> ListaUsuarios = new List<Usuario>();

    }

    public enum eCategoria
    {
        Açougue = 10,
        Frioselaticínios = 25,
        Adegaebebidas = 30,
        Higieneelimpeza = 35,
        Hortifrutiemercearia = 40,
        Padaria = 45,
        Enlatados = 50,
        Cereais = 55,
    }

    public class Produto
    {
        public Produto(int codigo, string? nome, string? categoria, double preco, DateTime dataVencimento, string? observacao)
        {
            Codigo = codigo;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            DataVencimento = dataVencimento;
            Observacao = observacao;
        }

        public Produto() { }
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public double Preco { get; set; }
        public DateTime DataVencimento { get; set; }
        public string? Observacao { get; set; }

        public static List<Produto> ListaProdutos = new List<Produto>();

    }
}
