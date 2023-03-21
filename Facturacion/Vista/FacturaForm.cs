using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }
        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        private void IdentidadTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorIdentidad(IdentidadTextBox2.Text);
                NombreClienteTextBox1.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                NombreClienteTextBox1.Clear();
            }
        }

        private void BuscarClienteButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
