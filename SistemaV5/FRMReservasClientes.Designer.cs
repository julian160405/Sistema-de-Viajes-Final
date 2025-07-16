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
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Cliente";
            // 
            // txtIdClienteBuscar
            // 
            txtIdClienteBuscar.Location = new Point(76, 56);
            txtIdClienteBuscar.Name = "txtIdClienteBuscar";
            txtIdClienteBuscar.Size = new Size(100, 23);
            txtIdClienteBuscar.TabIndex = 1;
            // 
            // btnBuscarReservas
            // 
            btnBuscarReservas.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarReservas.IconColor = Color.Black;
            btnBuscarReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarReservas.Location = new Point(57, 124);
            btnBuscarReservas.Name = "btnBuscarReservas";
            btnBuscarReservas.Size = new Size(119, 23);
            btnBuscarReservas.TabIndex = 2;
            btnBuscarReservas.Text = "Buscar Reservas";
            btnBuscarReservas.UseVisualStyleBackColor = true;
            btnBuscarReservas.Click += btnBuscarReservas_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(247, 56);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.Size = new Size(487, 278);
            dgvReservas.TabIndex = 3;
            // 
            // btnMostrarReservas
            // 
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
            // FRMReservasClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}