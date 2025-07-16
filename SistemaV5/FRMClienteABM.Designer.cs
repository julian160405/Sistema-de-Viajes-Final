namespace SistemaV5
{
    partial class FRMClienteABM
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtMailCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtPasswordCliente = new TextBox();
            txtDNICliente = new TextBox();
            txtIDCliente = new TextBox();
            dgvClientes = new DataGridView();
            btnRegistrarCliente = new FontAwesome.Sharp.IconButton();
            btnEliminarCliente = new FontAwesome.Sharp.IconButton();
            btnModificarCliente = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 138);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 199);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 260);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 321);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 5;
            label6.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 378);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "ID Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(77, 16);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 23);
            txtNombreCliente.TabIndex = 7;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(77, 75);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(100, 23);
            txtApellidoCliente.TabIndex = 8;
            // 
            // txtMailCliente
            // 
            txtMailCliente.Location = new Point(77, 134);
            txtMailCliente.Name = "txtMailCliente";
            txtMailCliente.Size = new Size(100, 23);
            txtMailCliente.TabIndex = 9;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(77, 193);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(100, 23);
            txtTelefonoCliente.TabIndex = 10;
            // 
            // txtPasswordCliente
            // 
            txtPasswordCliente.Location = new Point(77, 252);
            txtPasswordCliente.Name = "txtPasswordCliente";
            txtPasswordCliente.Size = new Size(100, 23);
            txtPasswordCliente.TabIndex = 11;
            // 
            // txtDNICliente
            // 
            txtDNICliente.Location = new Point(77, 311);
            txtDNICliente.Name = "txtDNICliente";
            txtDNICliente.Size = new Size(100, 23);
            txtDNICliente.TabIndex = 12;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(77, 370);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(100, 23);
            txtIDCliente.TabIndex = 13;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(229, 16);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(545, 377);
            dgvClientes.TabIndex = 14;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrarCliente.IconColor = Color.Black;
            btnRegistrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarCliente.Location = new Point(229, 415);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(75, 23);
            btnRegistrarCliente.TabIndex = 15;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminarCliente.IconColor = Color.Black;
            btnEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarCliente.Location = new Point(328, 415);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(75, 23);
            btnEliminarCliente.TabIndex = 16;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificarCliente.IconColor = Color.Black;
            btnModificarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificarCliente.Location = new Point(430, 415);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(75, 23);
            btnModificarCliente.TabIndex = 17;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(553, 415);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(122, 23);
            iconButton1.TabIndex = 18;
            iconButton1.Text = "Reservar Vuelo";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // FRMClienteABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconButton1);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(dgvClientes);
            Controls.Add(txtIDCliente);
            Controls.Add(txtDNICliente);
            Controls.Add(txtPasswordCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtMailCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMClienteABM";
            Text = "FRMClienteABM";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtMailCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtPasswordCliente;
        private TextBox txtDNICliente;
        private TextBox txtIDCliente;
        private DataGridView dgvClientes;
        private FontAwesome.Sharp.IconButton btnRegistrarCliente;
        private FontAwesome.Sharp.IconButton btnEliminarCliente;
        private FontAwesome.Sharp.IconButton btnModificarCliente;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}