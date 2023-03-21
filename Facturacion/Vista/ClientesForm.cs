using Datos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        string operacion;
        Cliente cliente = new Cliente();
        ClienteDB clienteDB = new ClienteDB();

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdentidadTextBox.Focus();
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            IdentidadTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            TelefonoTextBox1.Enabled = true;
            CorreoTextBox1.Enabled = true;
            DireccionTextBox1.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
        }

        private void DeshabilitarControles()
        {
            IdentidadTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            TelefonoTextBox1.Enabled = false;
            CorreoTextBox1.Enabled = false;
            DireccionTextBox1.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            ModificarButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            IdentidadTextBox.Clear();
            NombreTextBox.Clear();
            TelefonoTextBox1.Clear();
            CorreoTextBox1.Clear();
            DireccionTextBox1.Text = "";
            EstaActivoCheckBox.Checked = false;
            cliente = null;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (ClientesdataGridView1.SelectedRows.Count > 0)
            {
                IdentidadTextBox.Text = ClientesdataGridView1.CurrentRow.Cells["Identidad"].Value.ToString();
                NombreTextBox.Text = ClientesdataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                TelefonoTextBox1.Text = ClientesdataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                CorreoTextBox1.Text = ClientesdataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                DireccionTextBox1.Text = ClientesdataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                EstaActivoCheckBox.Checked = Convert.ToBoolean(ClientesdataGridView1.CurrentRow.Cells["EstaActivo"].Value);

                HabilitarControles();
                IdentidadTextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            if (operacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(IdentidadTextBox.Text))
                {
                    errorProvider1.SetError(IdentidadTextBox, "Ingrese una identidad");
                    IdentidadTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese un Nombre");
                    NombreTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(TelefonoTextBox1.Text))
                {
                    errorProvider1.SetError(TelefonoTextBox1, "Ingrese un Telefono");
                    TelefonoTextBox1.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(CorreoTextBox1.Text))
                {
                    errorProvider1.SetError(CorreoTextBox1, "Ingrese un Correo");
                    CorreoTextBox1.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DireccionTextBox1.Text))
                {
                    errorProvider1.SetError(DireccionTextBox1, "Ingrese un Correo");
                    DireccionTextBox1.Focus();
                    return;
                }
                errorProvider1.Clear();

                cliente.Identidad = IdentidadTextBox.Text;
                cliente.Nombre = NombreTextBox.Text;
                cliente.Telefono = TelefonoTextBox1.Text;
                cliente.Correo = CorreoTextBox1.Text;
                cliente.Direccion = DireccionTextBox1.Text;
                cliente.EstaActivo = EstaActivoCheckBox.Checked;

                bool inserto = clienteDB.Insertar(cliente);
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerCliente();
                    MessageBox.Show("Registro guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puro guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                cliente.Identidad = IdentidadTextBox.Text;
                cliente.Nombre = NombreTextBox.Text;
                cliente.Telefono = TelefonoTextBox1.Text;
                cliente.Correo = CorreoTextBox1.Text;
                cliente.Direccion = DireccionTextBox1.Text;
                cliente.EstaActivo = EstaActivoCheckBox.Checked;

                bool modifico = clienteDB.Editar(cliente);
                if (modifico)
                {
                    IdentidadTextBox.ReadOnly = false;
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerCliente();
                    MessageBox.Show("Registro actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puro actualizar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TraerCliente()
        {
            dt = clienteDB.DevolverClientes();

            ClientesdataGridView1.DataSource = dt;
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            TraerCliente();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ClientesdataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = clienteDB.Eliminar(ClientesdataGridView1.CurrentRow.Cells["Identidad"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerCliente();
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    { MessageBox.Show("No se pudo eliminar el registro"); }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

    }
}
