namespace Entidades
{
    public class Login
    {
        public string codigoUsuario { get; set; }
        public string contraseña { get; set; }
        public string rol { get; set; }

        public Login()
        {
        }

        public Login(string codigoUsuario, string contraseña, string rol)
        {
            this.codigoUsuario = codigoUsuario;
            this.contraseña = contraseña;
            this.rol = rol;
        }
    }
}
