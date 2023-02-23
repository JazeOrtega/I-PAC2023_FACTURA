namespace Vista
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.CancelarButton2 = new System.Windows.Forms.Button();
            this.MostrarContraseñaButton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // UsuarioTextBox1
            // 
            this.UsuarioTextBox1.Location = new System.Drawing.Point(117, 39);
            this.UsuarioTextBox1.Name = "UsuarioTextBox1";
            this.UsuarioTextBox1.Size = new System.Drawing.Size(155, 22);
            this.UsuarioTextBox1.TabIndex = 2;
            // 
            // ContraseñaTextBox2
            // 
            this.ContraseñaTextBox2.Location = new System.Drawing.Point(117, 83);
            this.ContraseñaTextBox2.Name = "ContraseñaTextBox2";
            this.ContraseñaTextBox2.Size = new System.Drawing.Size(155, 22);
            this.ContraseñaTextBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton1.Image = global::Vista.Properties.Resources.aceptar__1_;
            this.Aceptarbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptarbutton1.Location = new System.Drawing.Point(41, 125);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(104, 34);
            this.Aceptarbutton1.TabIndex = 0;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptarbutton1.UseVisualStyleBackColor = true;
            this.Aceptarbutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // CancelarButton2
            // 
            this.CancelarButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton2.Image = global::Vista.Properties.Resources.cancelar;
            this.CancelarButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton2.Location = new System.Drawing.Point(161, 125);
            this.CancelarButton2.Name = "CancelarButton2";
            this.CancelarButton2.Size = new System.Drawing.Size(111, 34);
            this.CancelarButton2.TabIndex = 3;
            this.CancelarButton2.Text = "Cancelar";
            this.CancelarButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton2.UseVisualStyleBackColor = true;
            this.CancelarButton2.Click += new System.EventHandler(this.CancelarButton2_Click);
            // 
            // MostrarContraseñaButton1
            // 
            this.MostrarContraseñaButton1.Image = global::Vista.Properties.Resources.vista;
            this.MostrarContraseñaButton1.Location = new System.Drawing.Point(278, 83);
            this.MostrarContraseñaButton1.Name = "MostrarContraseñaButton1";
            this.MostrarContraseñaButton1.Size = new System.Drawing.Size(23, 22);
            this.MostrarContraseñaButton1.TabIndex = 7;
            this.MostrarContraseñaButton1.UseVisualStyleBackColor = true;
            this.MostrarContraseñaButton1.Click += new System.EventHandler(this.MostrarContraseñaButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.intimidad;
            this.pictureBox1.Location = new System.Drawing.Point(326, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.Aceptarbutton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton2;
            this.ClientSize = new System.Drawing.Size(460, 187);
            this.ControlBox = false;
            this.Controls.Add(this.MostrarContraseñaButton1);
            this.Controls.Add(this.ContraseñaTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelarButton2);
            this.Controls.Add(this.UsuarioTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptarbutton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioTextBox1;
        private System.Windows.Forms.Button CancelarButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ContraseñaTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button MostrarContraseñaButton1;
    }
}

