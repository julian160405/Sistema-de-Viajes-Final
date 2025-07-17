<<<<<<< HEAD
﻿using FontAwesome.Sharp;
using sistemaDeViajesV3.Clases;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
=======
﻿using sistemaDeViajesV3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
using System.Windows.Forms;

namespace SistemaV5
{
    public partial class FormMenuEmpleado : Form
    {
<<<<<<< HEAD
        private CLSEmpleado empleadoLogueado;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
=======
        private CLSEmpleado empleadologueado;
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
        private Form currentChildForm;

        public FormMenuEmpleado(CLSEmpleado empleado)
        {
            InitializeComponent();
<<<<<<< HEAD
            empleadoLogueado = empleado;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void BotonActivado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                BotonDesactivado();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void BotonDesactivado()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        // Eventos de botones
        private void btnABMClientes_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.color2);
            OpenChildForm(new FRMClienteABM());
=======
            empleadologueado = empleado;
        }

        private void btnABMClientes_Click(object sender, EventArgs e)
        {
            FRMClienteABM nuevoform = new FRMClienteABM();
            nuevoform.Show();
            this.Hide();
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
        }

        private void btnReservasClientes_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            BotonActivado(sender, RGBColors.color4);
            OpenChildForm(new FRMReservasClientes());
=======
            FRMReservasClientes nuevoform = new FRMReservasClientes();
            nuevoform.Show();
            this.Hide();
>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        // Movimiento del formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnAgrandar_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ?
                          FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
=======

>>>>>>> bbd6c928afeb8b4a837eeca7a8ca047abcff98dd
        }
    }
}
