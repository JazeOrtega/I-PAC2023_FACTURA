namespace Vista
{
    partial class UsuariosForm
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
            this.NombreTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContrasenaTextBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorreoTextBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RolComboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EstaActivoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.AdjuntarButton1 = new System.Windows.Forms.Button();
            this.FotoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.NuevoButton1 = new System.Windows.Forms.Button();
            this.ModificarButton1 = new System.Windows.Forms.Button();
            this.GuardarButton1 = new System.Windows.Forms.Button();
            this.EliminarButton1 = new System.Windows.Forms.Button();
            this.CancelarButton1 = new System.Windows.Forms.Button();
            this.UsuariosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // CodigoTextBox1
            // 
            this.CodigoTextBox1.Enabled = false;
            this.CodigoTextBox1.Location = new System.Drawing.Point(133, 24);
            this.CodigoTextBox1.Name = "CodigoTextBox1";
            this.CodigoTextBox1.Size = new System.Drawing.Size(121, 22);
            this.CodigoTextBox1.TabIndex = 1;
            // 
            // NombreTextBox2
            // 
            this.NombreTextBox2.Enabled = false;
            this.NombreTextBox2.Location = new System.Drawing.Point(133, 62);
            this.NombreTextBox2.Name = "NombreTextBox2";
            this.NombreTextBox2.Size = new System.Drawing.Size(121, 22);
            this.NombreTextBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // ContrasenaTextBox3
            // 
            this.ContrasenaTextBox3.Enabled = false;
            this.ContrasenaTextBox3.Location = new System.Drawing.Point(133, 107);
            this.ContrasenaTextBox3.Name = "ContrasenaTextBox3";
            this.ContrasenaTextBox3.PasswordChar = '*';
            this.ContrasenaTextBox3.Size = new System.Drawing.Size(121, 22);
            this.ContrasenaTextBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // CorreoTextBox4
            // 
            this.CorreoTextBox4.Enabled = false;
            this.CorreoTextBox4.Location = new System.Drawing.Point(133, 151);
            this.CorreoTextBox4.Name = "CorreoTextBox4";
            this.CorreoTextBox4.Size = new System.Drawing.Size(121, 22);
            this.CorreoTextBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol";
            // 
            // RolComboBox1
            // 
            this.RolComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolComboBox1.Enabled = false;
            this.RolComboBox1.FormattingEnabled = true;
            this.RolComboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolComboBox1.Location = new System.Drawing.Point(133, 191);
            this.RolComboBox1.Name = "RolComboBox1";
            this.RolComboBox1.Size = new System.Drawing.Size(121, 24);
            this.RolComboBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esta Activo";
            // 
            // EstaActivoCheckBox1
            // 
            this.EstaActivoCheckBox1.AutoSize = true;
            this.EstaActivoCheckBox1.Enabled = false;
            this.EstaActivoCheckBox1.Location = new System.Drawing.Point(136, 234);
            this.EstaActivoCheckBox1.Name = "EstaActivoCheckBox1";
            this.EstaActivoCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.EstaActivoCheckBox1.TabIndex = 11;
            this.EstaActivoCheckBox1.UseVisualStyleBackColor = true;
            // 
            // AdjuntarButton1
            // 
            this.AdjuntarButton1.Enabled = false;
            this.AdjuntarButton1.Image = global::Vista.Properties.Resources.buscar;
            this.AdjuntarButton1.Location = new System.Drawing.Point(541, 154);
            this.AdjuntarButton1.Name = "AdjuntarButton1";
            this.AdjuntarButton1.Size = new System.Drawing.Size(43, 37);
            this.AdjuntarButton1.TabIndex = 13;
            this.AdjuntarButton1.UseVisualStyleBackColor = true;
            this.AdjuntarButton1.Click += new System.EventHandler(this.AdjuntarButton1_Click);
            // 
            // FotoPictureBox1
            // 
            this.FotoPictureBox1.BackColor = System.Drawing.Color.White;
            this.FotoPictureBox1.Location = new System.Drawing.Point(330, 34);
            this.FotoPictureBox1.Name = "FotoPictureBox1";
            this.FotoPictureBox1.Size = new System.Drawing.Size(205, 154);
            this.FotoPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPictureBox1.TabIndex = 12;
            this.FotoPictureBox1.TabStop = false;
            // 
            // NuevoButton1
            // 
            this.NuevoButton1.Location = new System.Drawing.Point(104, 258);
            this.NuevoButton1.Name = "NuevoButton1";
            this.NuevoButton1.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton1.TabIndex = 14;
            this.NuevoButton1.Text = "Nuevo";
            this.NuevoButton1.UseVisualStyleBackColor = true;
            this.NuevoButton1.Click += new System.EventHandler(this.NuevoButton1_Click);
            // 
            // ModificarButton1
            // 
            this.ModificarButton1.Location = new System.Drawing.Point(185, 258);
            this.ModificarButton1.Name = "ModificarButton1";
            this.ModificarButton1.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton1.TabIndex = 15;
            this.ModificarButton1.Text = "Modificar";
            this.ModificarButton1.UseVisualStyleBackColor = true;
            this.ModificarButton1.Click += new System.EventHandler(this.ModificarButton1_Click);
            // 
            // GuardarButton1
            // 
            this.GuardarButton1.Enabled = false;
            this.GuardarButton1.Location = new System.Drawing.Point(266, 258);
            this.GuardarButton1.Name = "GuardarButton1";
            this.GuardarButton1.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton1.TabIndex = 16;
            this.GuardarButton1.Text = "Guardar";
            this.GuardarButton1.UseVisualStyleBackColor = true;
            this.GuardarButton1.Click += new System.EventHandler(this.GuardarButton1_Click);
            // 
            // EliminarButton1
            // 
            this.EliminarButton1.Location = new System.Drawing.Point(347, 258);
            this.EliminarButton1.Name = "EliminarButton1";
            this.EliminarButton1.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton1.TabIndex = 17;
            this.EliminarButton1.Text = "Eliminar";
            this.EliminarButton1.UseVisualStyleBackColor = true;
            this.EliminarButton1.Click += new System.EventHandler(this.EliminarButton1_Click);
            // 
            // CancelarButton1
            // 
            this.CancelarButton1.Enabled = false;
            this.CancelarButton1.Location = new System.Drawing.Point(428, 258);
            this.CancelarButton1.Name = "CancelarButton1";
            this.CancelarButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton1.TabIndex = 18;
            this.CancelarButton1.Text = "Cancelar";
            this.CancelarButton1.UseVisualStyleBackColor = true;
            this.CancelarButton1.Click += new System.EventHandler(this.CancelarButton1_Click);
            // 
            // UsuariosDataGridView1
            // 
            this.UsuariosDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridView1.Location = new System.Drawing.Point(1, 299);
            this.UsuariosDataGridView1.Name = "UsuariosDataGridView1";
            this.UsuariosDataGridView1.Size = new System.Drawing.Size(627, 150);
            this.UsuariosDataGridView1.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 447);
            this.Controls.Add(this.UsuariosDataGridView1);
            this.Controls.Add(this.CancelarButton1);
            this.Controls.Add(this.EliminarButton1);
            this.Controls.Add(this.GuardarButton1);
            this.Controls.Add(this.ModificarButton1);
            this.Controls.Add(this.NuevoButton1);
            this.Controls.Add(this.AdjuntarButton1);
            this.Controls.Add(this.FotoPictureBox1);
            this.Controls.Add(this.EstaActivoCheckBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RolComboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorreoTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContrasenaTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsuariosForm";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoTextBox1;
        private System.Windows.Forms.TextBox NombreTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContrasenaTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorreoTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RolComboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EstaActivoCheckBox1;
        private System.Windows.Forms.PictureBox FotoPictureBox1;
        private System.Windows.Forms.Button AdjuntarButton1;
        private System.Windows.Forms.Button NuevoButton1;
        private System.Windows.Forms.Button ModificarButton1;
        private System.Windows.Forms.Button GuardarButton1;
        private System.Windows.Forms.Button EliminarButton1;
        private System.Windows.Forms.Button CancelarButton1;
        private System.Windows.Forms.DataGridView UsuariosDataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}