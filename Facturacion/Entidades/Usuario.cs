using System;

namespace Entidades
{
    public class Usuario
    {
        public string codigoUsuario { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public string correo { get; set; }
        public string rol { get; set; }
        public DateTime fechaInicio { get; set; }
        public bool estaActivo { get; set; }
        public Usuario() { }

        public Usuario(string codigoUsuario, string nombre, string contraseña, string correo, string rol, DateTime fechaInicio, bool estaActivo)
        {
            this.codigoUsuario = codigoUsuario;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.correo = correo;
            this.rol = rol;
            this.fechaInicio = fechaInicio;
            this.estaActivo = estaActivo;
        }
    }
}
