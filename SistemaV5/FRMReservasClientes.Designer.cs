namespace SistemaV5
{
    partial class FRMReservasClientes
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
            txtIdClienteBuscar = new TextBox();
            btnBuscarReservas = new FontAwesome.Sharp.IconButton();
            dgvReservas = new DataGridView();
            btnMostrarReservas = new FontAwesome.Sharp.IconButton();
<<<<<<< HEAD
            dtpFechaCancelacion = new DateTimePicker();
            BtnCancelarReserva = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
=======
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 47);
=======
            label1.Location = new Point(12, 56);
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Cliente";
            // 
            // txtIdClienteBuscar
            // 
<<<<<<< HEAD
            txtIdClienteBuscar.Location = new Point(101, 47);
            txtIdClienteBuscar.Name = "txtIdClienteBuscar";
            txtIdClienteBuscar.Size = new Size(125, 23);
=======
            txtIdClienteBuscar.Location = new Point(76, 56);
            txtIdClienteBuscar.Name = "txtIdClienteBuscar";
            txtIdClienteBuscar.Size = new Size(100, 23);
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
            txtIdClienteBuscar.TabIndex = 1;
            // 
            // btnBuscarReservas
            // 
<<<<<<< HEAD
            btnBuscarReservas.BackColor = Color.FromArgb(108, 60, 152);
            btnBuscarReservas.FlatStyle = FlatStyle.Flat;
            btnBuscarReservas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarReservas.ForeColor = Color.White;
            btnBuscarReservas.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarReservas.IconColor = Color.Black;
            btnBuscarReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarReservas.Location = new Point(304, 39);
            btnBuscarReservas.Name = "btnBuscarReservas";
            btnBuscarReservas.Size = new Size(119, 31);
            btnBuscarReservas.TabIndex = 2;
            btnBuscarReservas.Text = "Buscar Reservas";
            btnBuscarReservas.UseVisualStyleBackColor = false;
=======
            btnBuscarReservas.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarReservas.IconColor = Color.Black;
            btnBuscarReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarReservas.Location = new Point(57, 124);
            btnBuscarReservas.Name = "btnBuscarReservas";
            btnBuscarReservas.Size = new Size(119, 23);
            btnBuscarReservas.TabIndex = 2;
            btnBuscarReservas.Text = "Buscar Reservas";
            btnBuscarReservas.UseVisualStyleBackColor = true;
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
            btnBuscarReservas.Click += btnBuscarReservas_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dgvReservas.Location = new Point(37, 120);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.Size = new Size(608, 315);
=======
            dgvReservas.Location = new Point(247, 56);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.Size = new Size(487, 278);
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
            dgvReservas.TabIndex = 3;
            // 
            // btnMostrarReservas
            // 
<<<<<<< HEAD
            btnMostrarReservas.BackColor = Color.FromArgb(108, 60, 152);
            btnMostrarReservas.FlatStyle = FlatStyle.Flat;
            btnMostrarReservas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarReservas.ForeColor = Color.White;
            btnMostrarReservas.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMostrarReservas.IconColor = Color.Black;
            btnMostrarReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarReservas.Location = new Point(469, 39);
            btnMostrarReservas.Name = "btnMostrarReservas";
            btnMostrarReservas.Size = new Size(176, 31);
            btnMostrarReservas.TabIndex = 4;
            btnMostrarReservas.Text = "Mostrar Todas las Reservas";
            btnMostrarReservas.UseVisualStyleBackColor = false;
            btnMostrarReservas.Click += btnMostrarReservas_Click;
            // 
            // dtpFechaCancelacion
            // 
            dtpFechaCancelacion.Location = new Point(165, 461);
            dtpFechaCancelacion.Name = "dtpFechaCancelacion";
            dtpFechaCancelacion.Size = new Size(200, 23);
            dtpFechaCancelacion.TabIndex = 5;
            // 
            // BtnCancelarReserva
            // 
            BtnCancelarReserva.BackColor = Color.FromArgb(108, 60, 152);
            BtnCancelarReserva.FlatStyle = FlatStyle.Flat;
            BtnCancelarReserva.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelarReserva.ForeColor = SystemColors.ControlLightLight;
            BtnCancelarReserva.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnCancelarReserva.IconColor = Color.Black;
            BtnCancelarReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelarReserva.Location = new Point(444, 459);
            BtnCancelarReserva.Name = "BtnCancelarReserva";
            BtnCancelarReserva.Size = new Size(201, 31);
            BtnCancelarReserva.TabIndex = 6;
            BtnCancelarReserva.Text = "Consultar Tarifa de Cancelación";
            BtnCancelarReserva.UseVisualStyleBackColor = false;
            BtnCancelarReserva.Click += BtnCancelarReserva_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 467);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 7;
            label2.Text = "Fecha de Cancelación";
            // 
=======
            btnMostrarReservas.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMostrarReservas.IconColor = Color.Black;
            btnMostrarReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarReservas.Location = new Point(39, 187);
            btnMostrarReservas.Name = "btnMostrarReservas";
            btnMostrarReservas.Size = new Size(162, 23);
            btnMostrarReservas.TabIndex = 4;
            btnMostrarReservas.Text = "Mostrar Todas las Reservas";
            btnMostrarReservas.UseVisualStyleBackColor = true;
            btnMostrarReservas.Click += btnMostrarReservas_Click;
            // 
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
            // FRMReservasClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(682, 498);
            Controls.Add(label2);
            Controls.Add(BtnCancelarReserva);
            Controls.Add(dtpFechaCancelacion);
=======
            ClientSize = new Size(800, 450);
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
            Controls.Add(btnMostrarReservas);
            Controls.Add(dgvReservas);
            Controls.Add(btnBuscarReservas);
            Controls.Add(txtIdClienteBuscar);
            Controls.Add(label1);
            Name = "FRMReservasClientes";
            Text = "FRMReservasClientes";
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdClienteBuscar;
        private FontAwesome.Sharp.IconButton btnBuscarReservas;
        private DataGridView dgvReservas;
        private FontAwesome.Sharp.IconButton btnMostrarReservas;
<<<<<<< HEAD
        private DateTimePicker dtpFechaCancelacion;
        private FontAwesome.Sharp.IconButton BtnCancelarReserva;
        private Label label2;
=======
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
    }
}