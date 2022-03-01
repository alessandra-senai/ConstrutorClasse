using BibliotecaClasses;
using System;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.Codigo = 1;
            produto.Nome = "Celular Samsung A10";
            produto.Descricao = "Eletroeletrônico de última geração";
            produto.QtdeEstoque = 40;

            Funcionario funcionario = new Funcionario();
            funcionario.Matricula = 33;
            funcionario.Nome = "Maria Silva";
            funcionario.Funcao = "Gerente Administrativo";
            funcionario.DataAdmissao = new DateTime(2001, 01, 22);
            funcionario.Salario = 12345.09M;

            Usuario usuario = new Usuario();
            usuario.Nome = "José Marinho";
            usuario.Login = "jose.marinho";
            usuario.Senha = "4560";

            Usuario usuarioRedeSocial = new Usuario("joao.santos", "João", "123");

            int resultadoSoma = Calculadora.Somar(4, 5);
        }
    }
}