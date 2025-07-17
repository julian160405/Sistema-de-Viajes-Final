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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuEmpleado));
            btnReservasClientes = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            btnRegistrarViaje = new FontAwesome.Sharp.IconButton();
            btnABMClientes = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            BtnClose = new FontAwesome.Sharp.IconPictureBox();
            BtnAgrandar = new FontAwesome.Sharp.IconPictureBox();
            BtnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            PanelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgrandar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // btnReservasClientes
            // 
            btnReservasClientes.Dock = DockStyle.Top;
            btnReservasClientes.FlatAppearance.BorderSize = 0;
            btnReservasClientes.FlatStyle = FlatStyle.Flat;
            btnReservasClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservasClientes.ForeColor = Color.White;
            btnReservasClientes.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            btnReservasClientes.IconColor = Color.White;
            btnReservasClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReservasClientes.IconSize = 32;
            btnReservasClientes.Location = new Point(0, 140);
            btnReservasClientes.Name = "btnReservasClientes";
            btnReservasClientes.Padding = new Padding(10, 0, 20, 0);
            btnReservasClientes.Size = new Size(220, 60);
            btnReservasClientes.TabIndex = 1;
            btnReservasClientes.Text = "Reservas Clientes";
            btnReservasClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnReservasClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReservasClientes.UseVisualStyleBackColor = false;
            btnReservasClientes.Click += btnReservasClientes_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnRegistrarViaje);
            panelMenu.Controls.Add(btnABMClientes);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(btnReservasClientes);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 602);
            panelMenu.TabIndex = 3;
            // 
            // btnRegistrarViaje
            // 
            btnRegistrarViaje.Dock = DockStyle.Top;
            btnRegistrarViaje.FlatAppearance.BorderSize = 0;
            btnRegistrarViaje.FlatStyle = FlatStyle.Flat;
            btnRegistrarViaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarViaje.ForeColor = Color.White;
            btnRegistrarViaje.IconChar = FontAwesome.Sharp.IconChar.PlaneCircleCheck;
            btnRegistrarViaje.IconColor = Color.White;
            btnRegistrarViaje.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarViaje.IconSize = 32;
            btnRegistrarViaje.Location = new Point(0, 260);
            btnRegistrarViaje.Name = "btnRegistrarViaje";
            btnRegistrarViaje.Padding = new Padding(10, 0, 20, 0);
            btnRegistrarViaje.Size = new Size(220, 60);
            btnRegistrarViaje.TabIndex = 4;
            btnRegistrarViaje.Text = "Registrar Viaje";
            btnRegistrarViaje.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarViaje.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarViaje.UseVisualStyleBackColor = false;
            btnRegistrarViaje.Click += btnRegistrarViaje_Click;
            // 
            // btnABMClientes
            // 
            btnABMClientes.Dock = DockStyle.Top;
            btnABMClientes.FlatAppearance.BorderSize = 0;
            btnABMClientes.FlatStyle = FlatStyle.Flat;
            btnABMClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnABMClientes.ForeColor = Color.White;
            btnABMClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            btnABMClientes.IconColor = Color.White;
            btnABMClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnABMClientes.IconSize = 32;
            btnABMClientes.Location = new Point(0, 200);
            btnABMClientes.Name = "btnABMClientes";
            btnABMClientes.Padding = new Padding(10, 0, 20, 0);
            btnABMClientes.Size = new Size(220, 60);
            btnABMClientes.TabIndex = 3;
            btnABMClientes.Text = "Clientes";
            btnABMClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnABMClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnABMClientes.UseVisualStyleBackColor = false;
            btnABMClientes.Click += btnABMClientes_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(31, 30, 68);
            iconButton1.Dock = DockStyle.Bottom;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(0, 548);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(220, 54);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Cerrar Sesión";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 140);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 25, 62);
            panel1.Controls.Add(BtnClose);
            panel1.Controls.Add(BtnAgrandar);
            panel1.Controls.Add(BtnMinimizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 80);
            panel1.TabIndex = 4;
            panel1.MouseDown += panelTitleBar_MouseDown;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(26, 25, 62);
            BtnClose.ForeColor = Color.MediumSlateBlue;
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnClose.IconColor = Color.MediumSlateBlue;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.IconSize = 25;
            BtnClose.Location = new Point(661, 22);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(25, 26);
            BtnClose.TabIndex = 6;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnAgrandar
            // 
            BtnAgrandar.BackColor = Color.FromArgb(26, 25, 62);
            BtnAgrandar.ForeColor = Color.MediumSlateBlue;
            BtnAgrandar.IconChar = FontAwesome.Sharp.IconChar.Expand;
            BtnAgrandar.IconColor = Color.MediumSlateBlue;
            BtnAgrandar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgrandar.IconSize = 25;
            BtnAgrandar.Location = new Point(630, 22);
            BtnAgrandar.Name = "BtnAgrandar";
            BtnAgrandar.Size = new Size(25, 26);
            BtnAgrandar.TabIndex = 5;
            BtnAgrandar.TabStop = false;
            BtnAgrandar.Click += BtnAgrandar_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.BackColor = Color.FromArgb(26, 25, 62);
            BtnMinimizar.ForeColor = Color.MediumSlateBlue;
            BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            BtnMinimizar.IconColor = Color.MediumSlateBlue;
            BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMinimizar.IconSize = 25;
            BtnMinimizar.Location = new Point(599, 22);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(25, 26);
            BtnMinimizar.TabIndex = 4;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 24, 58);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(220, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(698, 9);
            panel3.TabIndex = 5;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(220, 89);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(698, 513);
            PanelDesktop.TabIndex = 6;
            // 
            // FormMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 602);
            Controls.Add(PanelDesktop);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "FormMenuEmpleado";
            Text = "FormMenuClientes";
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnAgrandar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnReservasClientes;
        private Panel panelMenu;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Panel PanelDesktop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox BtnMinimizar;
        private FontAwesome.Sharp.IconPictureBox BtnAgrandar;
        private FontAwesome.Sharp.IconPictureBox BtnClose;
        private FontAwesome.Sharp.IconButton btnRegistrarViaje;
        private FontAwesome.Sharp.IconButton btnABMClientes;
    }
}