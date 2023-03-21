namespace Entidades
{
    public class Login
    {
        public string codigoUsuario { get; set; }
        public string contraseña { get; set; }

        public Login()
        {
        }

        public Login(string codigoUsuario, string contraseña)
        {
            this.codigoUsuario = codigoUsuario;
            this.contraseña = contraseña;
        }
    }
}
