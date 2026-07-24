using Presentacion.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Views
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();



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
        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

            this.ActiveControl = lblRecuperarAcceso;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnVlidarToken_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
