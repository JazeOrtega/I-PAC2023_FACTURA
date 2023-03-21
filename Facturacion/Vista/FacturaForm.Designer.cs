namespace Vista
{
    partial class FacturaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NombreClienteTextBox1 = new System.Windows.Forms.TextBox();
            this.BuscarClienteButton1 = new System.Windows.Forms.Button();
            this.IdentidadTextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CantidadTextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExistenciaTextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescripcionProductoTextBox2 = new System.Windows.Forms.TextBox();
            this.BuscarProductoButton1 = new System.Windows.Forms.Button();
            this.CodigoTextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DetalleDataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.SubTotalTextBox1 = new System.Windows.Forms.TextBox();
            this.ISVTextBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DescuentoTextBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalTextBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GuardarButton1 = new System.Windows.Forms.Button();
            this.CancelarButton2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsuarioTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(620, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // UsuarioTextBox1
            // 
            this.UsuarioTextBox1.Location = new System.Drawing.Point(66, 12);
            this.UsuarioTextBox1.Name = "UsuarioTextBox1";
            this.UsuarioTextBox1.ReadOnly = true;
            this.UsuarioTextBox1.Size = new System.Drawing.Size(145, 22);
            this.UsuarioTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreClienteTextBox1);
            this.groupBox2.Controls.Add(this.BuscarClienteButton1);
            this.groupBox2.Controls.Add(this.IdentidadTextBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DatosCliente";
            // 
            // NombreClienteTextBox1
            // 
            this.NombreClienteTextBox1.Location = new System.Drawing.Point(270, 15);
            this.NombreClienteTextBox1.Name = "NombreClienteTextBox1";
            this.NombreClienteTextBox1.ReadOnly = true;
            this.NombreClienteTextBox1.Size = new System.Drawing.Size(461, 22);
            this.NombreClienteTextBox1.TabIndex = 6;
            // 
            // BuscarClienteButton1
            // 
            this.BuscarClienteButton1.Location = new System.Drawing.Point(226, 14);
            this.BuscarClienteButton1.Name = "BuscarClienteButton1";
            this.BuscarClienteButton1.Size = new System.Drawing.Size(38, 23);
            this.BuscarClienteButton1.TabIndex = 5;
            this.BuscarClienteButton1.UseVisualStyleBackColor = true;
            this.BuscarClienteButton1.Click += new System.EventHandler(this.BuscarClienteButton1_Click);
            // 
            // IdentidadTextBox2
            // 
            this.IdentidadTextBox2.Location = new System.Drawing.Point(75, 15);
            this.IdentidadTextBox2.Name = "IdentidadTextBox2";
            this.IdentidadTextBox2.Size = new System.Drawing.Size(145, 22);
            this.IdentidadTextBox2.TabIndex = 4;
            this.IdentidadTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadTextBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Identidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CantidadTextBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ExistenciaTextBox2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DescripcionProductoTextBox2);
            this.groupBox3.Controls.Add(this.BuscarProductoButton1);
            this.groupBox3.Controls.Add(this.CodigoTextBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(741, 98);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DatosProducto";
            // 
            // CantidadTextBox1
            // 
            this.CantidadTextBox1.Location = new System.Drawing.Point(586, 55);
            this.CantidadTextBox1.Name = "CantidadTextBox1";
            this.CantidadTextBox1.Size = new System.Drawing.Size(145, 22);
            this.CantidadTextBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad";
            // 
            // ExistenciaTextBox2
            // 
            this.ExistenciaTextBox2.Location = new System.Drawing.Point(75, 52);
            this.ExistenciaTextBox2.Name = "ExistenciaTextBox2";
            this.ExistenciaTextBox2.Size = new System.Drawing.Size(136, 22);
            this.ExistenciaTextBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Existencia";
            // 
            // DescripcionProductoTextBox2
            // 
            this.DescripcionProductoTextBox2.Location = new System.Drawing.Point(258, 14);
            this.DescripcionProductoTextBox2.Name = "DescripcionProductoTextBox2";
            this.DescripcionProductoTextBox2.ReadOnly = true;
            this.DescripcionProductoTextBox2.Size = new System.Drawing.Size(473, 22);
            this.DescripcionProductoTextBox2.TabIndex = 7;
            // 
            // BuscarProductoButton1
            // 
            this.BuscarProductoButton1.Location = new System.Drawing.Point(214, 14);
            this.BuscarProductoButton1.Name = "BuscarProductoButton1";
            this.BuscarProductoButton1.Size = new System.Drawing.Size(38, 23);
            this.BuscarProductoButton1.TabIndex = 7;
            this.BuscarProductoButton1.UseVisualStyleBackColor = true;
            // 
            // CodigoTextBox1
            // 
            this.CodigoTextBox1.Location = new System.Drawing.Point(75, 15);
            this.CodigoTextBox1.Name = "CodigoTextBox1";
            this.CodigoTextBox1.Size = new System.Drawing.Size(133, 22);
            this.CodigoTextBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo";
            // 
            // DetalleDataGridView1
            // 
            this.DetalleDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView1.Location = new System.Drawing.Point(12, 278);
            this.DetalleDataGridView1.Name = "DetalleDataGridView1";
            this.DetalleDataGridView1.Size = new System.Drawing.Size(741, 109);
            this.DetalleDataGridView1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sub Total";
            // 
            // SubTotalTextBox1
            // 
            this.SubTotalTextBox1.Location = new System.Drawing.Point(652, 396);
            this.SubTotalTextBox1.Name = "SubTotalTextBox1";
            this.SubTotalTextBox1.ReadOnly = true;
            this.SubTotalTextBox1.Size = new System.Drawing.Size(91, 22);
            this.SubTotalTextBox1.TabIndex = 12;
            // 
            // ISVTextBox2
            // 
            this.ISVTextBox2.Location = new System.Drawing.Point(652, 424);
            this.ISVTextBox2.Name = "ISVTextBox2";
            this.ISVTextBox2.ReadOnly = true;
            this.ISVTextBox2.Size = new System.Drawing.Size(91, 22);
            this.ISVTextBox2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "ISV";
            // 
            // DescuentoTextBox1
            // 
            this.DescuentoTextBox1.Location = new System.Drawing.Point(652, 452);
            this.DescuentoTextBox1.Name = "DescuentoTextBox1";
            this.DescuentoTextBox1.Size = new System.Drawing.Size(91, 22);
            this.DescuentoTextBox1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(574, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descuento";
            // 
            // TotalTextBox1
            // 
            this.TotalTextBox1.Location = new System.Drawing.Point(652, 480);
            this.TotalTextBox1.Name = "TotalTextBox1";
            this.TotalTextBox1.ReadOnly = true;
            this.TotalTextBox1.Size = new System.Drawing.Size(91, 22);
            this.TotalTextBox1.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(574, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total";
            // 
            // GuardarButton1
            // 
            this.GuardarButton1.Location = new System.Drawing.Point(13, 469);
            this.GuardarButton1.Name = "GuardarButton1";
            this.GuardarButton1.Size = new System.Drawing.Size(91, 33);
            this.GuardarButton1.TabIndex = 19;
            this.GuardarButton1.Text = "Guardar";
            this.GuardarButton1.UseVisualStyleBackColor = true;
            // 
            // CancelarButton2
            // 
            this.CancelarButton2.Location = new System.Drawing.Point(110, 469);
            this.CancelarButton2.Name = "CancelarButton2";
            this.CancelarButton2.Size = new System.Drawing.Size(85, 33);
            this.CancelarButton2.TabIndex = 20;
            this.CancelarButton2.Text = "Cancelar";
            this.CancelarButton2.UseVisualStyleBackColor = true;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.CancelarButton2);
            this.Controls.Add(this.GuardarButton1);
            this.Controls.Add(this.TotalTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DescuentoTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ISVTextBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SubTotalTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalleDataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacturaForm";
            this.Text = "FacturaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NombreClienteTextBox1;
        private System.Windows.Forms.Button BuscarClienteButton1;
        private System.Windows.Forms.TextBox IdentidadTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CantidadTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExistenciaTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripcionProductoTextBox2;
        private System.Windows.Forms.Button BuscarProductoButton1;
        private System.Windows.Forms.TextBox CodigoTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DetalleDataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubTotalTextBox1;
        private System.Windows.Forms.TextBox ISVTextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescuentoTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button GuardarButton1;
        private System.Windows.Forms.Button CancelarButton2;
    }
}