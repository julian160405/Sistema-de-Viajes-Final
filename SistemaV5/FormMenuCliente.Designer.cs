namespace SistemaV5
{
    partial class FormMenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuCliente));
            panelMenu = new Panel();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            btnReservarVuelo = new FontAwesome.Sharp.IconButton();
            btnMisReservas = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            BtnInicio = new PictureBox();
            panelTitleBar = new Panel();
            BtnAgrandar = new FontAwesome.Sharp.IconButton();
            BtnClose = new FontAwesome.Sharp.IconButton();
            BtnMinimizar = new FontAwesome.Sharp.IconButton();
            LblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            PanelShadow = new Panel();
            PanelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnInicio).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnReservarVuelo);
            panelMenu.Controls.Add(btnMisReservas);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.FromArgb(31, 30, 68);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 602);
            panelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.IconSize = 32;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 542);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(10, 0, 20, 0);
            btnCerrarSesion.Size = new Size(220, 60);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnReservarVuelo
            // 
            btnReservarVuelo.Dock = DockStyle.Top;
            btnReservarVuelo.FlatAppearance.BorderSize = 0;
            btnReservarVuelo.FlatStyle = FlatStyle.Flat;
            btnReservarVuelo.ForeColor = Color.White;
            btnReservarVuelo.IconChar = FontAwesome.Sharp.IconChar.Plane;
            btnReservarVuelo.IconColor = Color.White;
            btnReservarVuelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReservarVuelo.IconSize = 32;
            btnReservarVuelo.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservarVuelo.Location = new Point(0, 260);
            btnReservarVuelo.Name = "btnReservarVuelo";
            btnReservarVuelo.Padding = new Padding(10, 0, 20, 0);
            btnReservarVuelo.Size = new Size(220, 60);
            btnReservarVuelo.TabIndex = 4;
            btnReservarVuelo.Text = "Reservas Vuelo";
            btnReservarVuelo.TextAlign = ContentAlignment.MiddleLeft;
            btnReservarVuelo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReservarVuelo.UseVisualStyleBackColor = true;
            btnReservarVuelo.Click += BtnReservarVuelo_Click;
            // 
            // btnMisReservas
            // 
            btnMisReservas.Dock = DockStyle.Top;
            btnMisReservas.FlatAppearance.BorderSize = 0;
            btnMisReservas.FlatStyle = FlatStyle.Flat;
            btnMisReservas.ForeColor = Color.White;
            btnMisReservas.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            btnMisReservas.IconColor = Color.White;
            btnMisReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMisReservas.IconSize = 32;
            btnMisReservas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMisReservas.Location = new Point(0, 200);
            btnMisReservas.Name = "btnMisReservas";
            btnMisReservas.Padding = new Padding(10, 0, 20, 0);
            btnMisReservas.Size = new Size(220, 60);
            btnMisReservas.TabIndex = 3;
            btnMisReservas.Text = "Mis Reservas";
            btnMisReservas.TextAlign = ContentAlignment.MiddleLeft;
            btnMisReservas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMisReservas.UseVisualStyleBackColor = true;
            btnMisReservas.Click += BtnMisReservas_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 32;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 140);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 20, 0);
            btnHome.Size = new Size(220, 60);
            btnHome.TabIndex = 1;
            btnHome.Text = "Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += BtnHome_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 140);
            panel1.TabIndex = 0;
            // 
            // BtnInicio
            // 
            BtnInicio.Image = (Image)resources.GetObject("BtnInicio.Image");
            BtnInicio.Location = new Point(33, 23);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(140, 93);
            BtnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            BtnInicio.TabIndex = 0;
            BtnInicio.TabStop = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(BtnAgrandar);
            panelTitleBar.Controls.Add(BtnClose);
            panelTitleBar.Controls.Add(BtnMinimizar);
            panelTitleBar.Controls.Add(LblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(698, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // BtnAgrandar
            // 
            BtnAgrandar.FlatAppearance.BorderSize = 0;
            BtnAgrandar.FlatStyle = FlatStyle.Flat;
            BtnAgrandar.ForeColor = Color.MediumSlateBlue;
            BtnAgrandar.IconChar = FontAwesome.Sharp.IconChar.Expand;
            BtnAgrandar.IconColor = Color.MediumSlateBlue;
            BtnAgrandar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgrandar.IconSize = 20;
            BtnAgrandar.Location = new Point(640, 12);
            BtnAgrandar.Name = "BtnAgrandar";
            BtnAgrandar.Size = new Size(20, 24);
            BtnAgrandar.TabIndex = 4;
            BtnAgrandar.UseVisualStyleBackColor = true;
            BtnAgrandar.Click += BtnAgrandar_Click;
            // 
            // BtnClose
            // 
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.MediumSlateBlue;
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnClose.IconColor = Color.MediumSlateBlue;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.IconSize = 20;
            BtnClose.Location = new Point(666, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(20, 24);
            BtnClose.TabIndex = 3;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.FlatAppearance.BorderSize = 0;
            BtnMinimizar.FlatStyle = FlatStyle.Flat;
            BtnMinimizar.ForeColor = Color.MediumSlateBlue;
            BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            BtnMinimizar.IconColor = Color.MediumSlateBlue;
            BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMinimizar.IconSize = 20;
            BtnMinimizar.Location = new Point(614, 12);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(20, 24);
            BtnMinimizar.TabIndex = 2;
            BtnMinimizar.UseVisualStyleBackColor = true;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // LblTitleChildForm
            // 
            LblTitleChildForm.AutoSize = true;
            LblTitleChildForm.ForeColor = Color.White;
            LblTitleChildForm.Location = new Point(68, 32);
            LblTitleChildForm.Name = "LblTitleChildForm";
            LblTitleChildForm.Size = new Size(36, 15);
            LblTitleChildForm.TabIndex = 1;
            LblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildForm.ForeColor = Color.MediumSlateBlue;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.MediumSlateBlue;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(30, 23);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // PanelShadow
            // 
            PanelShadow.BackColor = Color.FromArgb(26, 24, 58);
            PanelShadow.Dock = DockStyle.Top;
            PanelShadow.Location = new Point(220, 80);
            PanelShadow.Name = "PanelShadow";
            PanelShadow.Size = new Size(698, 9);
            PanelShadow.TabIndex = 2;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(220, 89);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(698, 513);
            PanelDesktop.TabIndex = 3;
            // 
            // FormMenuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 602);
            Controls.Add(PanelDesktop);
            Controls.Add(PanelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMenuCliente";
            Text = "FormMenuCliente";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnInicio).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnReservarVuelo;
        private FontAwesome.Sharp.IconButton btnMisReservas;
        private Panel panel1;
        private PictureBox BtnInicio;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private Label LblTitleChildForm;
        private FontAwesome.Sharp.IconButton BtnAgrandar;
        private FontAwesome.Sharp.IconButton BtnClose;
        private Panel PanelShadow;
        private Panel PanelDesktop;
    }
}