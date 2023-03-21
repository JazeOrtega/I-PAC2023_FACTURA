using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarClienteForm1 : Form
    {
        public BuscarClienteForm1()
        {
            InitializeComponent();
        }
        ClienteDB clienteDB = new ClienteDB();
        public Cliente cliente = new Cliente();
        private void BuscarClienteForm1_Load(object sender, EventArgs e)
        {
            ClientesDataGridView1.DataSource = clienteDB.DevolverClientes();
        }

        private void AceptarButton1_Click(object sender, EventArgs e)
        {
            if (ClientesDataGridView1.SelectedRows.Count > 0)
            {
                cliente.Identidad = ClientesDataGridView1.CurrentRow.Cells["Identidad"].Value.ToString();
                cliente.Nombre = ClientesDataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = ClientesDataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Correo = ClientesDataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.Direccion = ClientesDataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(ClientesDataGridView1.CurrentRow.Cells["FechaNacimiento"].Value);
                cliente.EstaActivo = Convert.ToBoolean(ClientesDataGridView1.CurrentRow.Cells["EstaActivo"].Value);
                this.Close();
            }
        }

        private void CancelarButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NombreTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            ClientesDataGridView1.DataSource = clienteDB.DevolverClientesPorNombre(NombreTextBox1.Text);
        }
    }
}
