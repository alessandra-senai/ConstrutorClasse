namespace BibliotecaClasses
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuario() { }

        public Usuario(string login, string nome, string senha)
        {
            Login = login;
            Nome = nome;
            Senha = senha;
        }
    }
}
