using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        string tipoOperacion;
        DataTable dt = new DataTable();
        UsuarioDB UsuarioDB = new UsuarioDB();
        Usuario user = new Usuario();

        private void NuevoButton1_Click(object sender, EventArgs e)
        {
            CodigoTextBox1.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";
        }

        private void HabilitarControles()
        {
            CodigoTextBox1.Enabled = true;
            ContrasenaTextBox3.Enabled = true;
            NombreTextBox2.Enabled = true;
            CorreoTextBox4.Enabled = true;
            RolComboBox1.Enabled = true;
            EstaActivoCheckBox1.Enabled = true;
            AdjuntarButton1.Enabled = true;
            GuardarButton1.Enabled = true;
            CancelarButton1.Enabled = true;
            ModificarButton1.Enabled = false;
        }

        private void DeshabilitarControles()
        {
            CodigoTextBox1.Enabled = false;
            ContrasenaTextBox3.Enabled = false;
            NombreTextBox2.Enabled = false;
            CorreoTextBox4.Enabled = false;
            RolComboBox1.Enabled = false;
            EstaActivoCheckBox1.Enabled = false;
            AdjuntarButton1.Enabled = false;
            GuardarButton1.Enabled = false;
            CancelarButton1.Enabled = false;
            ModificarButton1.Enabled = true;
        }
        private void CancelarButton1_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            limpiarControles();
        }

        private void limpiarControles()
        {
            CodigoTextBox1.Clear();
            NombreTextBox2.Clear();
            ContrasenaTextBox3.Clear();
            CorreoTextBox4.Clear();
            RolComboBox1.Text = "";
            EstaActivoCheckBox1.Checked = false;
            FotoPictureBox1.Image = null;
        }

        private void ModificarButton1_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
            if (UsuariosDataGridView1.SelectedRows.Count > 0)
            {
                CodigoTextBox1.Text = UsuariosDataGridView1.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                NombreTextBox2.Text = UsuariosDataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                ContrasenaTextBox3.Text = UsuariosDataGridView1.CurrentRow.Cells["Contrasena"].Value.ToString();
                CorreoTextBox4.Text = UsuariosDataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                RolComboBox1.Text = UsuariosDataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
                EstaActivoCheckBox1.Checked = Convert.ToBoolean(UsuariosDataGridView1.CurrentRow.Cells["EstaActivo"].Value);

                byte[] miFoto = UsuarioDB.DevolverFoto(UsuariosDataGridView1.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                if (miFoto.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(miFoto);
                    FotoPictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                }

                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }


        }

        private void GuardarButton1_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox1.Text))
                {
                    errorProvider1.SetError(CodigoTextBox1, "Ingrese un Codigo");
                    CodigoTextBox1.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(NombreTextBox2.Text))
                {
                    errorProvider1.SetError(NombreTextBox2, "Ingrese un Nombre");
                    NombreTextBox2.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(ContrasenaTextBox3.Text))
                {
                    errorProvider1.SetError(ContrasenaTextBox3, "Ingrese una Contraseña");
                    ContrasenaTextBox3.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(RolComboBox1.Text))
                {
                    errorProvider1.SetError(RolComboBox1, "Seleccione un Rol");
                    ContrasenaTextBox3.Focus();
                    return;
                }
                errorProvider1.Clear();

                user.codigoUsuario = CodigoTextBox1.Text;
                user.nombre = NombreTextBox2.Text;
                user.contraseña = ContrasenaTextBox3.Text;
                user.rol = RolComboBox1.Text;
                user.correo = CorreoTextBox4.Text;
                user.estaActivo = EstaActivoCheckBox1.Checked;

                if (FotoPictureBox1.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    FotoPictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.foto = ms.GetBuffer();
                }
                //insertar en la base de datos
                bool inserto = UsuarioDB.Insertar(user);

                if (inserto)
                {
                    limpiarControles();
                    DeshabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro Guardado");
                }
                else
                {
                    MessageBox.Show("No se puede guardar el registro");
                }

            }
            else if (tipoOperacion == "Modificar")
            {
                user.codigoUsuario = CodigoTextBox1.Text;
                user.nombre = NombreTextBox2.Text;
                user.contraseña = ContrasenaTextBox3.Text;
                user.rol = RolComboBox1.Text;
                user.correo = CorreoTextBox4.Text;
                user.estaActivo = EstaActivoCheckBox1.Checked;

                if (FotoPictureBox1.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    FotoPictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.foto = ms.GetBuffer();
                }

                bool modifico = UsuarioDB.Edito(user);
                if (modifico)
                {
                    limpiarControles();
                    DeshabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }
            }
        }

        private void AdjuntarButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FotoPictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            TraerUsuarios();
        }

        private void TraerUsuarios()
        {
            dt = UsuarioDB.DevolverUsuarios();
            UsuariosDataGridView1.DataSource = dt;
        }

        private void EliminarButton1_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar el registro??", "Advertencia", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    bool elimino = UsuarioDB.Eliminar(UsuariosDataGridView1.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                    if (elimino)
                    {
                        limpiarControles();
                        DeshabilitarControles();
                        TraerUsuarios();
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

    }
}
