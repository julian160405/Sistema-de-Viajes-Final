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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(287, 189);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(158, 23);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Menu Empleado";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // FormMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconButton1);
            Name = "FormMenuEmpleado";
            Text = "FormMenuClientes";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
    }
}