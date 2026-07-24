using Presentacion.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            lblBienvenido.Focus();


            lblComplejoEducativo.Parent = picFondoVinotinto;
            lblComplejoEducativo.BackColor = Color.Transparent;

            lblDonRomulo.Parent = picFondoVinotinto;
            lblDonRomulo.BackColor = Color.Transparent;

            lblGallegos.Parent = picFondoVinotinto;
            lblGallegos.BackColor = Color.Transparent;

            picLogo.Parent = picFondoVinotinto;
            picLogo.BackColor = Color.Transparent;

            lblColegioEducativo.Parent = picFondoVinotinto;
            lblColegioEducativo.BackColor = Color.Transparent;

            lblFrase.Parent = picFondoVinotinto;
            lblFrase.BackColor = Color.Transparent;

            //lblSanFernando.Parent = picFondoVinotinto;
            //lblSanFernando.BackColor = Color.Transparent;

            EnableDoubleBuffer(lblBienvenido);
            EnableDoubleBuffer(lblUsuario);
            EnableDoubleBuffer(lblContraseña);
            EnableDoubleBuffer(btnIniciarSesion);
            EnableDoubleBuffer(linkLabelOlvidoSuContraseña);
            EnableDoubleBuffer(picLogo);




        }
        private static void EnableDoubleBuffer(Control ctrl)
        {
            typeof(Control).GetProperty("DoubleBuffered",
                                        BindingFlags.NonPublic | BindingFlags.Instance)
                           ?.SetValue(ctrl, true);
        }
        protected override void OnLoad(EventArgs e) //Iniciar Login
        {
            base.OnLoad(e);
            AnimateWindows.Start(this, 350, AnimateWindows.AnimationFlags.AW_ACTIVATE | AnimateWindows.AnimationFlags.AW_BLEND);

            Invalidate(true);
        }
        protected override void OnFormClosing(FormClosingEventArgs e) // Cerrar login
        {
            base.OnFormClosing(e);
            AnimateWindows.Start(this, 350, AnimateWindows.AnimationFlags.AW_HIDE | AnimateWindows.AnimationFlags.AW_BLEND);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblBienvenido;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void linkLabelOlvidoSuContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

           RecuperarContraseña recuperacion = new RecuperarContraseña();

            recuperacion.ShowDialog();

            this.Show();
        }
    }
}
