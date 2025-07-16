namespace SistemaV5
{
    partial class FormMenuEmpleado
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
            btnABMClientes = new FontAwesome.Sharp.IconButton();
            btnReservasClientes = new FontAwesome.Sharp.IconButton();
            btnRegistrarViaje = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btnABMClientes
            // 
            btnABMClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnABMClientes.IconColor = Color.Black;
            btnABMClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnABMClientes.Location = new Point(52, 69);
            btnABMClientes.Name = "btnABMClientes";
            btnABMClientes.Size = new Size(158, 23);
            btnABMClientes.TabIndex = 0;
            btnABMClientes.Text = "Clientes";
            btnABMClientes.UseVisualStyleBackColor = true;
            btnABMClientes.Click += btnABMClientes_Click;
            // 
            // btnReservasClientes
            // 
            btnReservasClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnReservasClientes.IconColor = Color.Black;
            btnReservasClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReservasClientes.Location = new Point(55, 161);
            btnReservasClientes.Name = "btnReservasClientes";
            btnReservasClientes.Size = new Size(155, 23);
            btnReservasClientes.TabIndex = 1;
            btnReservasClientes.Text = "Reservas Clientes";
            btnReservasClientes.TextAlign = ContentAlignment.TopCenter;
            btnReservasClientes.UseVisualStyleBackColor = true;
            btnReservasClientes.Click += btnReservasClientes_Click;
            // 
            // btnRegistrarViaje
            // 
            btnRegistrarViaje.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrarViaje.IconColor = Color.Black;
            btnRegistrarViaje.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarViaje.Location = new Point(53, 254);
            btnRegistrarViaje.Name = "btnRegistrarViaje";
            btnRegistrarViaje.Size = new Size(157, 23);
            btnRegistrarViaje.TabIndex = 2;
            btnRegistrarViaje.Text = "Registrar  Viaje";
            btnRegistrarViaje.UseVisualStyleBackColor = true;
            btnRegistrarViaje.Click += btnRegistrarViaje_Click;
            // 
            // FormMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarViaje);
            Controls.Add(btnReservasClientes);
            Controls.Add(btnABMClientes);
            Name = "FormMenuEmpleado";
            Text = "FormMenuClientes";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnABMClientes;
        private FontAwesome.Sharp.IconButton btnReservasClientes;
        private FontAwesome.Sharp.IconButton btnRegistrarViaje;
    }
}