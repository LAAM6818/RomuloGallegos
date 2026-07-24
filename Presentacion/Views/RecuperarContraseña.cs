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

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

            this.ActiveControl = lblRecuperarAcceso;
        }
    }
}
