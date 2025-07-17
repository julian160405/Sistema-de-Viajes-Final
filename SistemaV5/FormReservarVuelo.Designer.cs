namespace SistemaV5
{
    partial class FormReservarVuelo
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
            BtnBuscarVuelosDisponibles = new FontAwesome.Sharp.IconButton();
            BtnSeleccionarVuelo = new FontAwesome.Sharp.IconButton();
            DgvVuelosDisponibles = new DataGridView();
            CbOrigen = new ComboBox();
            CbDestino = new ComboBox();
            DtpFechaIda = new DateTimePicker();
            DtpFechaVuelta = new DateTimePicker();
            NuDCantidadBoletosA = new NumericUpDown();
            NuDCantidadBoletosN = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvVuelosDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NuDCantidadBoletosA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NuDCantidadBoletosN).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscarVuelosDisponibles
            // 
            BtnBuscarVuelosDisponibles.BackColor = Color.FromArgb(108, 60, 152);
            BtnBuscarVuelosDisponibles.Cursor = Cursors.Hand;
            BtnBuscarVuelosDisponibles.FlatStyle = FlatStyle.Flat;
            BtnBuscarVuelosDisponibles.ForeColor = Color.White;
            BtnBuscarVuelosDisponibles.IconChar = FontAwesome.Sharp.IconChar.Plane;
            BtnBuscarVuelosDisponibles.IconColor = Color.White;
            BtnBuscarVuelosDisponibles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarVuelosDisponibles.IconSize = 32;
            BtnBuscarVuelosDisponibles.Location = new Point(90, 416);
            BtnBuscarVuelosDisponibles.Name = "BtnBuscarVuelosDisponibles";
            BtnBuscarVuelosDisponibles.Padding = new Padding(10, 0, 20, 0);
            BtnBuscarVuelosDisponibles.Size = new Size(219, 41);
            BtnBuscarVuelosDisponibles.TabIndex = 0;
            BtnBuscarVuelosDisponibles.Text = "Buscar Vuelos Disponibles";
            BtnBuscarVuelosDisponibles.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscarVuelosDisponibles.UseVisualStyleBackColor = false;
            BtnBuscarVuelosDisponibles.Click += BtnBuscarVuelosDisponibles_Click;
            // 
            // BtnSeleccionarVuelo
            // 
            BtnSeleccionarVuelo.BackColor = Color.FromArgb(108, 60, 152);
            BtnSeleccionarVuelo.Cursor = Cursors.Hand;
            BtnSeleccionarVuelo.FlatStyle = FlatStyle.Flat;
            BtnSeleccionarVuelo.ForeColor = Color.White;
            BtnSeleccionarVuelo.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnSeleccionarVuelo.IconColor = Color.White;
            BtnSeleccionarVuelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSeleccionarVuelo.IconSize = 32;
            BtnSeleccionarVuelo.Location = new Point(370, 416);
            BtnSeleccionarVuelo.Name = "BtnSeleccionarVuelo";
            BtnSeleccionarVuelo.Padding = new Padding(10, 0, 20, 0);
            BtnSeleccionarVuelo.Size = new Size(219, 41);
            BtnSeleccionarVuelo.TabIndex = 1;
            BtnSeleccionarVuelo.Text = "Seleccionar Vuelo";
            BtnSeleccionarVuelo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSeleccionarVuelo.UseVisualStyleBackColor = false;
            BtnSeleccionarVuelo.Click += BtnSeleccionarVuelo_Click;
            // 
            // DgvVuelosDisponibles
            // 
            DgvVuelosDisponibles.BackgroundColor = Color.FromArgb(34, 33, 74);
            DgvVuelosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVuelosDisponibles.Location = new Point(21, 178);
            DgvVuelosDisponibles.Name = "DgvVuelosDisponibles";
            DgvVuelosDisponibles.Size = new Size(642, 211);
            DgvVuelosDisponibles.TabIndex = 2;
            // 
            // CbOrigen
            // 
            CbOrigen.FormattingEnabled = true;
            CbOrigen.Location = new Point(21, 54);
            CbOrigen.Name = "CbOrigen";
            CbOrigen.Size = new Size(193, 23);
            CbOrigen.TabIndex = 3;
            // 
            // CbDestino
            // 
            CbDestino.FormattingEnabled = true;
            CbDestino.Location = new Point(248, 54);
            CbDestino.Name = "CbDestino";
            CbDestino.Size = new Size(193, 23);
            CbDestino.TabIndex = 4;
            // 
            // DtpFechaIda
            // 
            DtpFechaIda.Location = new Point(24, 136);
            DtpFechaIda.Name = "DtpFechaIda";
            DtpFechaIda.Size = new Size(200, 23);
            DtpFechaIda.TabIndex = 5;
            // 
            // DtpFechaVuelta
            // 
            DtpFechaVuelta.Location = new Point(248, 136);
            DtpFechaVuelta.Name = "DtpFechaVuelta";
            DtpFechaVuelta.Size = new Size(200, 23);
            DtpFechaVuelta.TabIndex = 6;
            // 
            // NuDCantidadBoletosA
            // 
            NuDCantidadBoletosA.Location = new Point(472, 55);
            NuDCantidadBoletosA.Name = "NuDCantidadBoletosA";
            NuDCantidadBoletosA.Size = new Size(120, 23);
            NuDCantidadBoletosA.TabIndex = 7;
            // 
            // NuDCantidadBoletosN
            // 
            NuDCantidadBoletosN.Location = new Point(472, 136);
            NuDCantidadBoletosN.Name = "NuDCantidadBoletosN";
            NuDCantidadBoletosN.Size = new Size(120, 23);
            NuDCantidadBoletosN.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 9;
            label1.Text = "Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(248, 22);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "Destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(472, 22);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 11;
            label3.Text = "Cantidad de Adultos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(472, 112);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 12;
            label4.Text = "Cantidad de Niños";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(248, 112);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 13;
            label5.Text = "Fecha de Vuelta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 112);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 14;
            label6.Text = "Fecha de Ida";
            // 
            // FormReservarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(682, 469);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NuDCantidadBoletosN);
            Controls.Add(NuDCantidadBoletosA);
            Controls.Add(DtpFechaVuelta);
            Controls.Add(DtpFechaIda);
            Controls.Add(CbDestino);
            Controls.Add(CbOrigen);
            Controls.Add(DgvVuelosDisponibles);
            Controls.Add(BtnSeleccionarVuelo);
            Controls.Add(BtnBuscarVuelosDisponibles);
            Name = "FormReservarVuelo";
            Text = "FormReservarVuelo";
            Load += FormReservarVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)DgvVuelosDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)NuDCantidadBoletosA).EndInit();
            ((System.ComponentModel.ISupportInitialize)NuDCantidadBoletosN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBuscarVuelosDisponibles;
        private FontAwesome.Sharp.IconButton BtnSeleccionarVuelo;
        private DataGridView DgvVuelosDisponibles;
        private ComboBox CbOrigen;
        private ComboBox CbDestino;
        private DateTimePicker DtpFechaIda;
        private DateTimePicker DtpFechaVuelta;
        private NumericUpDown NuDCantidadBoletosA;
        private NumericUpDown NuDCantidadBoletosN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}