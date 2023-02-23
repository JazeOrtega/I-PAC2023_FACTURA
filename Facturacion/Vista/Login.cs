using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
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
