using Datos;
using Entidades;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        string operacion;
        Producto producto;
        ProductoDB productoDB = new ProductoDB();

        private void NuevoButton1_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigoTextBox1.Enabled = true;
            DescripcionTextBox1.Enabled = true;
            ExistenciaTextBox1.Enabled = true;
            PrecioTextBox1.Enabled = true;
            AdjuntarButton1.Enabled = true;
            GuardarButton1.Enabled = true;
            CancelarButton1.Enabled = true;
            NuevoButton1.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoTextBox1.Clear();
            DescripcionTextBox1.Clear();
            ExistenciaTextBox1.Clear();
            PrecioTextBox1.Clear();
            EstaActivoCheckBox1.Checked = false;
            ImagenPictureBox1.Image = null;
            producto = null;
        }

        private void DeshabilitarControles()
        {
            CodigoTextBox1.Enabled = false;
            DescripcionTextBox1.Enabled = false;
            ExistenciaTextBox1.Enabled = false;
            PrecioTextBox1.Enabled = false;
            AdjuntarButton1.Enabled = false;
            GuardarButton1.Enabled = false;
            CancelarButton1.Enabled = false;
            NuevoButton1.Enabled = true;
        }

        private void CancelarButton1_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
        }

        private void ModificarButton1_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (ProductosDataGridView1.SelectedRows.Count > 0)
            {
                CodigoTextBox1.Text = ProductosDataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripcionTextBox1.Text = ProductosDataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                ExistenciaTextBox1.Text = ProductosDataGridView1.CurrentRow.Cells["Existencia"].Value.ToString();
                PrecioTextBox1.Text = ProductosDataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivoCheckBox1.Checked = Convert.ToBoolean(ProductosDataGridView1.CurrentRow.Cells["EstaActivo"].Value);

                byte[] img = productoDB.DevolverFoto(ProductosDataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());

                if (img.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    ImagenPictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                HabilitarControles();
                CodigoTextBox1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void GuardarButton1_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto.Codigo = CodigoTextBox1.Text;
            producto.Descripcion = DescripcionTextBox1.Text;
            producto.Precio = Convert.ToDecimal(PrecioTextBox1);
            producto.Existencia = Convert.ToInt32(ExistenciaTextBox1.Text);
            producto.EstaActivo = EstaActivoCheckBox1.Checked;

            if (ImagenPictureBox1.Image != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                ImagenPictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                producto.Imagen = ms.GetBuffer();
            }

            if (operacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox1.Text))
                {
                    errorProvider1.SetError(CodigoTextBox1, "Ingrese un codigo");
                    CodigoTextBox1.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(DescripcionTextBox1.Text))
                {
                    errorProvider1.SetError(DescripcionTextBox1, "Ingrese una descripcion");
                    DescripcionTextBox1.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(ExistenciaTextBox1.Text))
                {
                    errorProvider1.SetError(ExistenciaTextBox1, "Ingrese una Existencia");
                    ExistenciaTextBox1.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(PrecioTextBox1.Text))
                {
                    errorProvider1.SetError(PrecioTextBox1, "Ingrese un Precio");
                    PrecioTextBox1.Focus();
                    return;
                }
                errorProvider1.Clear();

                bool inserto = productoDB.Insertar(producto);
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("Registro guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                bool modifico = productoDB.Edito(producto);
                if (modifico)
                {
                    CodigoTextBox1.ReadOnly = false;
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("Registro guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExistenciaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PrecioTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void AdjuntarButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ImagenPictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            TraerProductos();
        }

        private void TraerProductos()
        {
            ProductosDataGridView1.DataSource = productoDB.DevolverProductos();
        }

        private void EliminarButton1_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar el registro??", "Advertencia", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    bool elimino = productoDB.Eliminar(ProductosDataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerProductos();
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }
            }
        }

    }
}
