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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            lblBienvenidos.Focus();


            lblCE.Parent = picFondoVinotinto;
            lblCE.BackColor = Color.Transparent;

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




        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblBienvenidos;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
