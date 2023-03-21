using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CancelarButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox1.Text == string.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox1, "Ingrese un usuario");
                UsuarioTextBox1.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ContraseñaTextBox2.Text))
            {
                errorProvider1.SetError(ContraseñaTextBox2, "Ingrese la contraseña");
                ContraseñaTextBox2.Focus();
                return;
            }
            errorProvider1.Clear();

            //Validar la base de datos
            Login login = new Login(UsuarioTextBox1.Text, ContraseñaTextBox2.Text);
            Usuario usuario = new Usuario();
            UsuarioDB usuarioDB = new UsuarioDB();

            usuario = usuarioDB.Autenticar(login);

            if (usuario != null)
            {
                if (usuario.estaActivo)
                {
                    //Mostramos el menu
                    Menu menuFormulario = new Menu();
                    Hide();
                    menuFormulario.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no esta activo", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }




        private void MostrarContraseñaButton1_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox2.PasswordChar == '*')
            {
                ContraseñaTextBox2.PasswordChar = '\0';
            }
            else
            {
                ContraseñaTextBox2.PasswordChar = '*';
            }
        }
    }
}
