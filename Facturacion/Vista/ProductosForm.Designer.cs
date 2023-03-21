namespace Vista
{
    partial class ProductosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoTextBox1 = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExistenciaTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ImagenPictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdjuntarButton1 = new System.Windows.Forms.Button();
            this.CancelarButton1 = new System.Windows.Forms.Button();
            this.EliminarButton1 = new System.Windows.Forms.Button();
            this.GuardarButton1 = new System.Windows.Forms.Button();
            this.ModificarButton1 = new System.Windows.Forms.Button();
            this.NuevoButton1 = new System.Windows.Forms.Button();
            this.ProductosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EstaActivoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // CodigoTextBox1
            // 
            this.CodigoTextBox1.Location = new System.Drawing.Point(125, 59);
            this.CodigoTextBox1.Name = "CodigoTextBox1";
            this.CodigoTextBox1.Size = new System.Drawing.Size(153, 20);
            this.CodigoTextBox1.TabIndex = 1;
            // 
            // DescripcionTextBox1
            // 
            this.DescripcionTextBox1.Location = new System.Drawing.Point(125, 95);
            this.DescripcionTextBox1.Name = "DescripcionTextBox1";
            this.DescripcionTextBox1.Size = new System.Drawing.Size(153, 20);
            this.DescripcionTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // ExistenciaTextBox1
            // 
            this.ExistenciaTextBox1.Location = new System.Drawing.Point(125, 130);
            this.ExistenciaTextBox1.Name = "ExistenciaTextBox1";
            this.ExistenciaTextBox1.Size = new System.Drawing.Size(153, 20);
            this.ExistenciaTextBox1.TabIndex = 5;
            this.ExistenciaTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciaTextBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia";
            // 
            // PrecioTextBox1
            // 
            this.PrecioTextBox1.Location = new System.Drawing.Point(125, 167);
            this.PrecioTextBox1.Name = "PrecioTextBox1";
            this.PrecioTextBox1.Size = new System.Drawing.Size(153, 20);
            this.PrecioTextBox1.TabIndex = 7;
            this.PrecioTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // ImagenPictureBox1
            // 
            this.ImagenPictureBox1.BackColor = System.Drawing.Color.White;
            this.ImagenPictureBox1.Location = new System.Drawing.Point(338, 51);
            this.ImagenPictureBox1.Name = "ImagenPictureBox1";
            this.ImagenPictureBox1.Size = new System.Drawing.Size(166, 116);
            this.ImagenPictureBox1.TabIndex = 8;
            this.ImagenPictureBox1.TabStop = false;
            // 
            // AdjuntarButton1
            // 
            this.AdjuntarButton1.Image = global::Vista.Properties.Resources.buscar;
            this.AdjuntarButton1.Location = new System.Drawing.Point(510, 133);
            this.AdjuntarButton1.Name = "AdjuntarButton1";
            this.AdjuntarButton1.Size = new System.Drawing.Size(34, 34);
            this.AdjuntarButton1.TabIndex = 9;
            this.AdjuntarButton1.UseVisualStyleBackColor = true;
            this.AdjuntarButton1.Click += new System.EventHandler(this.AdjuntarButton1_Click);
            // 
            // CancelarButton1
            // 
            this.CancelarButton1.Enabled = false;
            this.CancelarButton1.Location = new System.Drawing.Point(483, 217);
            this.CancelarButton1.Name = "CancelarButton1";
            this.CancelarButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton1.TabIndex = 23;
            this.CancelarButton1.Text = "Cancelar";
            this.CancelarButton1.UseVisualStyleBackColor = true;
            this.CancelarButton1.Click += new System.EventHandler(this.CancelarButton1_Click);
            // 
            // EliminarButton1
            // 
            this.EliminarButton1.Location = new System.Drawing.Point(402, 217);
            this.EliminarButton1.Name = "EliminarButton1";
            this.EliminarButton1.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton1.TabIndex = 22;
            this.EliminarButton1.Text = "Eliminar";
            this.EliminarButton1.UseVisualStyleBackColor = true;
            this.EliminarButton1.Click += new System.EventHandler(this.EliminarButton1_Click);
            // 
            // GuardarButton1
            // 
            this.GuardarButton1.Enabled = false;
            this.GuardarButton1.Location = new System.Drawing.Point(321, 217);
            this.GuardarButton1.Name = "GuardarButton1";
            this.GuardarButton1.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton1.TabIndex = 21;
            this.GuardarButton1.Text = "Guardar";
            this.GuardarButton1.UseVisualStyleBackColor = true;
            this.GuardarButton1.Click += new System.EventHandler(this.GuardarButton1_Click);
            // 
            // ModificarButton1
            // 
            this.ModificarButton1.Location = new System.Drawing.Point(240, 217);
            this.ModificarButton1.Name = "ModificarButton1";
            this.ModificarButton1.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton1.TabIndex = 20;
            this.ModificarButton1.Text = "Modificar";
            this.ModificarButton1.UseVisualStyleBackColor = true;
            this.ModificarButton1.Click += new System.EventHandler(this.ModificarButton1_Click);
            // 
            // NuevoButton1
            // 
            this.NuevoButton1.Location = new System.Drawing.Point(159, 217);
            this.NuevoButton1.Name = "NuevoButton1";
            this.NuevoButton1.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton1.TabIndex = 19;
            this.NuevoButton1.Text = "Nuevo";
            this.NuevoButton1.UseVisualStyleBackColor = true;
            this.NuevoButton1.Click += new System.EventHandler(this.NuevoButton1_Click);
            // 
            // ProductosDataGridView1
            // 
            this.ProductosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView1.Location = new System.Drawing.Point(2, 267);
            this.ProductosDataGridView1.Name = "ProductosDataGridView1";
            this.ProductosDataGridView1.Size = new System.Drawing.Size(610, 84);
            this.ProductosDataGridView1.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstaActivoCheckBox1
            // 
            this.EstaActivoCheckBox1.AutoSize = true;
            this.EstaActivoCheckBox1.Enabled = false;
            this.EstaActivoCheckBox1.Location = new System.Drawing.Point(115, 217);
            this.EstaActivoCheckBox1.Name = "EstaActivoCheckBox1";
            this.EstaActivoCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.EstaActivoCheckBox1.TabIndex = 26;
            this.EstaActivoCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Esta Activo";
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 351);
            this.Controls.Add(this.EstaActivoCheckBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductosDataGridView1);
            this.Controls.Add(this.CancelarButton1);
            this.Controls.Add(this.EliminarButton1);
            this.Controls.Add(this.GuardarButton1);
            this.Controls.Add(this.ModificarButton1);
            this.Controls.Add(this.NuevoButton1);
            this.Controls.Add(this.AdjuntarButton1);
            this.Controls.Add(this.ImagenPictureBox1);
            this.Controls.Add(this.PrecioTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExistenciaTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "ProductosForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoTextBox1;
        private System.Windows.Forms.TextBox DescripcionTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExistenciaTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrecioTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ImagenPictureBox1;
        private System.Windows.Forms.Button AdjuntarButton1;
        private System.Windows.Forms.Button CancelarButton1;
        private System.Windows.Forms.Button EliminarButton1;
        private System.Windows.Forms.Button GuardarButton1;
        private System.Windows.Forms.Button ModificarButton1;
        private System.Windows.Forms.Button NuevoButton1;
        private System.Windows.Forms.DataGridView ProductosDataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox EstaActivoCheckBox1;
        private System.Windows.Forms.Label label6;
    }
}