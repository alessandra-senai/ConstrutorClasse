using System;
namespace BibliotecaClasses
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Funcionario() { }
    }
}
