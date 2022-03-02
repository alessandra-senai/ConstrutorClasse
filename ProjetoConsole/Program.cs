using BibliotecaClasses;
using System;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Codigo = 21;
            produto.Nome = "Celular A8";
            produto.Descricao = "produto da nova geração";
            produto.QtdeEstoque = 45;

            Console.WriteLine("------------- PRODUTO ------------------");
            Console.WriteLine("produto código = " + produto.Codigo);
            Console.WriteLine($"produto nome = {produto.Nome}");
            Console.WriteLine($"produto descrição  = {produto.Descricao}");
            Console.WriteLine($"produto qtde estoque = {produto.QtdeEstoque}");
            Console.WriteLine("-------------------------------------------");


            Funcionario funcionario = new Funcionario();

            funcionario.Matricula = 45;
            funcionario.Nome = "Zelia Lima";
            funcionario.Salario = 12345.54M;
            funcionario.Funcao = "Diretora";
            funcionario.DataAdmissao = new DateTime(2012, 04, 24);

            Console.WriteLine("------------- FUNCIONARIO ----------------------------------");
            Console.WriteLine($"funcionário matrícula = {funcionario.Matricula} ");
            Console.WriteLine($" funcionário nome = {funcionario.Nome}");
            Console.WriteLine($" funcionário salário = {funcionario.Salario}");
            Console.WriteLine($" funcionário função =  { funcionario.Funcao}");
            Console.WriteLine($" funcionário data de admissão = {funcionario.DataAdmissao}");
            Console.WriteLine("--------------------------------------------------------------");

            Usuario usuario = new Usuario();
            usuario.Nome = "Alessandra";
            usuario.Login = "ale.teste";
            usuario.Senha = "123admin";

            Console.WriteLine("------------- USUÁRIO CONSTRUTOR PADRÃO ----------------------------");
            Console.WriteLine($"usuário nome = {usuario.Nome}");
            Console.WriteLine($"usuário senha = {usuario.Senha}");
            Console.WriteLine($"usuário login = {usuario.Login}");
            Console.WriteLine("--------------------------------------------------------------");

            Usuario usuarioRedeSocial = new Usuario("Patricia Alves", "123", "patricia.alves");

            Console.WriteLine("------------- USUÁRIO CONSTRUTOR COM ARGUMENTOS----------------------");
            Console.WriteLine($"usuário rede social nome = {usuarioRedeSocial.Nome}");
            Console.WriteLine($"usuário rede social senha = {usuarioRedeSocial.Senha}");
            Console.WriteLine($"usuário rede social login = {usuarioRedeSocial.Login}");
            Console.WriteLine("--------------------------------------------------------------");


            int resultadoSoma = Calculadora.Somar(4, 5);

            Console.WriteLine("----------- CLASSSE ESTÁTICA --------------------------");
            Console.WriteLine($"resultado da soma = {resultadoSoma}");

            int resultadoMultiplicacao = Calculadora.Multiplicar(6, 8);

            Console.WriteLine("----------- CLASSSE ESTÁTICA --------------------------");
            Console.WriteLine($"resultado da multiplicação = {resultadoMultiplicacao}");

            int resultadoSubtracao = Calculadora.Subtrair(6, 3);

            Console.WriteLine("----------- CLASSSE ESTÁTICA --------------------------");
            Console.WriteLine($"resultado da subtração = {resultadoSubtracao}");
        }
    }
}