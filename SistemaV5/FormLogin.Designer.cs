namespace SistemaV5
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            BtnIniciarSesion = new FontAwesome.Sharp.IconButton();
            txtPassword = new TextBox();
            txtCorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-14, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 521);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(720, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(274, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(720, 257);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(274, 115);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 60;
            iconPictureBox1.Location = new Point(629, 157);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(69, 60);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 60;
            iconPictureBox2.Location = new Point(629, 289);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(69, 60);
            iconPictureBox2.TabIndex = 4;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 80;
            iconPictureBox3.Location = new Point(824, 59);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(80, 80);
            iconPictureBox3.TabIndex = 5;
            iconPictureBox3.TabStop = false;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.BackColor = Color.FromArgb(34, 14, 84);
            BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            BtnIniciarSesion.FlatStyle = FlatStyle.Flat;
            BtnIniciarSesion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIniciarSesion.ForeColor = Color.White;
            BtnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.Telegram;
            BtnIniciarSesion.IconColor = Color.White;
            BtnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnIniciarSesion.Location = new Point(720, 405);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Padding = new Padding(10, 0, 20, 0);
            BtnIniciarSesion.Size = new Size(274, 62);
            BtnIniciarSesion.TabIndex = 6;
            BtnIniciarSesion.Text = "Iniciar Sesión";
            BtnIniciarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnIniciarSesion.UseVisualStyleBackColor = false;
            BtnIniciarSesion.Click += this.BtnIniciarSesion_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(742, 303);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(742, 170);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(234, 23);
            txtCorreo.TabIndex = 8;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1051, 514);
            Controls.Add(txtCorreo);
            Controls.Add(txtPassword);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(iconPictureBox3);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconButton BtnIniciarSesion;
        private TextBox txtPassword;
        private TextBox txtCorreo;
    }
}
