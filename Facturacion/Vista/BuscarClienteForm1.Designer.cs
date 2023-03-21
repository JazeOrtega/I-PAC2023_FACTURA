namespace Vista
{
    partial class BuscarClienteForm1
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
            this.NombreTextBox1 = new System.Windows.Forms.TextBox();
            this.AceptarButton1 = new System.Windows.Forms.Button();
            this.CancelarButton2 = new System.Windows.Forms.Button();
            this.ClientesDataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // NombreTextBox1
            // 
            this.NombreTextBox1.Location = new System.Drawing.Point(101, 52);
            this.NombreTextBox1.Name = "NombreTextBox1";
            this.NombreTextBox1.Size = new System.Drawing.Size(522, 22);
            this.NombreTextBox1.TabIndex = 1;
            this.NombreTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NombreTextBox1_KeyUp);
            // 
            // AceptarButton1
            // 
            this.AceptarButton1.Location = new System.Drawing.Point(354, 93);
            this.AceptarButton1.Name = "AceptarButton1";
            this.AceptarButton1.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton1.TabIndex = 2;
            this.AceptarButton1.Text = "Aceptar";
            this.AceptarButton1.UseVisualStyleBackColor = true;
            this.AceptarButton1.Click += new System.EventHandler(this.AceptarButton1_Click);
            // 
            // CancelarButton2
            // 
            this.CancelarButton2.Location = new System.Drawing.Point(448, 93);
            this.CancelarButton2.Name = "CancelarButton2";
            this.CancelarButton2.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton2.TabIndex = 3;
            this.CancelarButton2.Text = "Cancelar";
            this.CancelarButton2.UseVisualStyleBackColor = true;
            this.CancelarButton2.Click += new System.EventHandler(this.CancelarButton2_Click);
            // 
            // ClientesDataGridView1
            // 
            this.ClientesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView1.Location = new System.Drawing.Point(12, 151);
            this.ClientesDataGridView1.Name = "ClientesDataGridView1";
            this.ClientesDataGridView1.Size = new System.Drawing.Size(618, 129);
            this.ClientesDataGridView1.TabIndex = 4;
            // 
            // BuscarClienteForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 282);
            this.Controls.Add(this.ClientesDataGridView1);
            this.Controls.Add(this.CancelarButton2);
            this.Controls.Add(this.AceptarButton1);
            this.Controls.Add(this.NombreTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuscarClienteForm1";
            this.Text = "BuscarClienteForm1";
            this.Load += new System.EventHandler(this.BuscarClienteForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox1;
        private System.Windows.Forms.Button AceptarButton1;
        private System.Windows.Forms.Button CancelarButton2;
        private System.Windows.Forms.DataGridView ClientesDataGridView1;
    }
}