namespace Presentacion.Views
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            picCerrar = new PictureBox();
            lblPortal = new Label();
            btnEnviarCodigo = new Krypton.Toolkit.KryptonButton();
            linkIniciarSesion = new LinkLabel();
            txtCorreo = new TextBox();
            pnlCorreo = new Panel();
            lblCorreo = new Label();
            lblMensaje = new Label();
            pnlPic = new Panel();
            lblFrase = new Label();
            lblColegioEducativo = new Label();
            picLogo = new PictureBox();
            lblGallegos = new Label();
            lblDonRomulo = new Label();
            lblComplejoEducativo = new Label();
            picFondoVinotinto = new PictureBox();
            lblRecuperarAcceso = new Label();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            pnlPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFondoVinotinto).BeginInit();
            SuspendLayout();
            // 
            // picCerrar
            // 
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(911, 6);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(24, 24);
            picCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            picCerrar.TabIndex = 24;
            picCerrar.TabStop = false;
            // 
            // lblPortal
            // 
            lblPortal.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblPortal.ForeColor = Color.Gray;
            lblPortal.Location = new Point(473, 539);
            lblPortal.Name = "lblPortal";
            lblPortal.Size = new Size(467, 15);
            lblPortal.TabIndex = 18;
            lblPortal.Text = " P O R T A L   I N S T I T U C I O N A L ";
            lblPortal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(562, 332);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.OverrideDefault.Back.Color1 = Color.FromArgb(82, 26, 27);
            btnEnviarCodigo.OverrideDefault.Back.Color2 = Color.FromArgb(82, 26, 27);
            btnEnviarCodigo.Size = new Size(288, 43);
            btnEnviarCodigo.StateCommon.Back.Color1 = Color.FromArgb(82, 26, 27);
            btnEnviarCodigo.StateCommon.Back.Color2 = Color.FromArgb(82, 26, 27);
            btnEnviarCodigo.StateCommon.Border.Color1 = Color.FromArgb(234, 219, 211);
            btnEnviarCodigo.StateCommon.Border.Color2 = Color.FromArgb(234, 219, 211);
            btnEnviarCodigo.StateCommon.Content.ShortText.Color1 = Color.FromArgb(234, 219, 211);
            btnEnviarCodigo.StateCommon.Content.ShortText.Color2 = Color.FromArgb(234, 219, 211);
            btnEnviarCodigo.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviarCodigo.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            btnEnviarCodigo.StatePressed.Back.Color1 = Color.FromArgb(45, 29, 29);
            btnEnviarCodigo.StatePressed.Back.Color2 = Color.FromArgb(45, 29, 29);
            btnEnviarCodigo.TabIndex = 23;
            btnEnviarCodigo.Values.DropDownArrowColor = Color.Empty;
            btnEnviarCodigo.Values.Text = "ENVIAR CODIGO";
            // 
            // linkIniciarSesion
            // 
            linkIniciarSesion.ActiveLinkColor = Color.FromArgb(107, 20, 32);
            linkIniciarSesion.AutoSize = true;
            linkIniciarSesion.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkIniciarSesion.LinkBehavior = LinkBehavior.HoverUnderline;
            linkIniciarSesion.LinkColor = Color.FromArgb(107, 20, 32);
            linkIniciarSesion.Location = new Point(656, 283);
            linkIniciarSesion.Name = "linkIniciarSesion";
            linkIniciarSesion.Size = new Size(91, 16);
            linkIniciarSesion.TabIndex = 22;
            linkIniciarSesion.TabStop = true;
            linkIniciarSesion.Text = "Iniciar sesion";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(239, 230, 210);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.DimGray;
            txtCorreo.Location = new Point(564, 237);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ej: Romulo123@gmail.com";
            txtCorreo.Size = new Size(286, 22);
            txtCorreo.TabIndex = 13;
            // 
            // pnlCorreo
            // 
            pnlCorreo.BackColor = Color.FromArgb(171, 159, 145);
            pnlCorreo.ForeColor = Color.FromArgb(171, 159, 145);
            pnlCorreo.Location = new Point(564, 262);
            pnlCorreo.Name = "pnlCorreo";
            pnlCorreo.Size = new Size(285, 2);
            pnlCorreo.TabIndex = 20;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.ForeColor = Color.FromArgb(43, 27, 24);
            lblCorreo.Location = new Point(559, 209);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(56, 20);
            lblCorreo.TabIndex = 16;
            lblCorreo.Text = "Correo";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.FromArgb(107, 92, 85);
            lblMensaje.Location = new Point(559, 148);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(262, 17);
            lblMensaje.TabIndex = 14;
            lblMensaje.Text = "Ingresa tus datos para acceder al sistema.";
            // 
            // pnlPic
            // 
            pnlPic.BackColor = Color.Transparent;
            pnlPic.Controls.Add(lblFrase);
            pnlPic.Controls.Add(lblColegioEducativo);
            pnlPic.Controls.Add(picLogo);
            pnlPic.Controls.Add(lblGallegos);
            pnlPic.Controls.Add(lblDonRomulo);
            pnlPic.Controls.Add(lblComplejoEducativo);
            pnlPic.Controls.Add(picFondoVinotinto);
            pnlPic.Dock = DockStyle.Left;
            pnlPic.Location = new Point(0, 0);
            pnlPic.Name = "pnlPic";
            pnlPic.Size = new Size(470, 580);
            pnlPic.TabIndex = 21;
            // 
            // lblFrase
            // 
            lblFrase.Font = new Font("Constantia", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFrase.ForeColor = Color.FromArgb(234, 219, 211);
            lblFrase.Location = new Point(34, 424);
            lblFrase.Name = "lblFrase";
            lblFrase.Size = new Size(396, 51);
            lblFrase.TabIndex = 4;
            lblFrase.Text = "\"La educación forma el carácter que sostiene a un pueblo.\"";
            lblFrase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblColegioEducativo
            // 
            lblColegioEducativo.AutoSize = true;
            lblColegioEducativo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColegioEducativo.ForeColor = Color.FromArgb(216, 192, 136);
            lblColegioEducativo.Location = new Point(114, 241);
            lblColegioEducativo.Name = "lblColegioEducativo";
            lblColegioEducativo.Size = new Size(234, 15);
            lblColegioEducativo.TabIndex = 0;
            lblColegioEducativo.Text = "I N S T I T U C I Ó N   D E   E D U C A T I V A";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(121, 60);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(217, 175);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblGallegos
            // 
            lblGallegos.AutoSize = true;
            lblGallegos.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGallegos.ForeColor = Color.FromArgb(216, 192, 136);
            lblGallegos.Location = new Point(162, 355);
            lblGallegos.Name = "lblGallegos";
            lblGallegos.Size = new Size(133, 36);
            lblGallegos.TabIndex = 3;
            lblGallegos.Text = "Gallegos";
            // 
            // lblDonRomulo
            // 
            lblDonRomulo.AutoSize = true;
            lblDonRomulo.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonRomulo.ForeColor = Color.FromArgb(216, 192, 136);
            lblDonRomulo.Location = new Point(136, 319);
            lblDonRomulo.Name = "lblDonRomulo";
            lblDonRomulo.Size = new Size(190, 36);
            lblDonRomulo.TabIndex = 2;
            lblDonRomulo.Text = "Don Rómulo";
            // 
            // lblComplejoEducativo
            // 
            lblComplejoEducativo.AutoSize = true;
            lblComplejoEducativo.Font = new Font("Constantia", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplejoEducativo.ForeColor = Color.FromArgb(250, 246, 236);
            lblComplejoEducativo.Location = new Point(99, 284);
            lblComplejoEducativo.Name = "lblComplejoEducativo";
            lblComplejoEducativo.Size = new Size(267, 36);
            lblComplejoEducativo.TabIndex = 1;
            lblComplejoEducativo.Text = "Complejo Educativo";
            // 
            // picFondoVinotinto
            // 
            picFondoVinotinto.Dock = DockStyle.Fill;
            picFondoVinotinto.Image = (Image)resources.GetObject("picFondoVinotinto.Image");
            picFondoVinotinto.Location = new Point(0, 0);
            picFondoVinotinto.Name = "picFondoVinotinto";
            picFondoVinotinto.Size = new Size(470, 580);
            picFondoVinotinto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFondoVinotinto.TabIndex = 0;
            picFondoVinotinto.TabStop = false;
            // 
            // lblRecuperarAcceso
            // 
            lblRecuperarAcceso.AutoSize = true;
            lblRecuperarAcceso.Font = new Font("Constantia", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecuperarAcceso.ForeColor = Color.FromArgb(96, 11, 18);
            lblRecuperarAcceso.Location = new Point(554, 107);
            lblRecuperarAcceso.Name = "lblRecuperarAcceso";
            lblRecuperarAcceso.Size = new Size(282, 42);
            lblRecuperarAcceso.TabIndex = 12;
            lblRecuperarAcceso.Text = "Recuperar Acceso";
            // 
            // RecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 230, 210);
            ClientSize = new Size(940, 580);
            Controls.Add(picCerrar);
            Controls.Add(lblPortal);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(linkIniciarSesion);
            Controls.Add(txtCorreo);
            Controls.Add(pnlCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(lblMensaje);
            Controls.Add(pnlPic);
            Controls.Add(lblRecuperarAcceso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecuperarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecuperarContraseña";
            Load += RecuperarContraseña_Load;
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            pnlPic.ResumeLayout(false);
            pnlPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFondoVinotinto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCerrar;
        private Label lblPortal;
        private Krypton.Toolkit.KryptonButton btnEnviarCodigo;
        private LinkLabel linkIniciarSesion;
        private TextBox txtCorreo;
        private Panel pnlCorreo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Panel pnlContraseña;
        private Panel pnlUsuario;
        private Label lblContraseña;
        private Label lblCorreo;
        private Label lblMensaje;
        private Panel pnlPic;
        private Label lblFrase;
        private Label lblColegioEducativo;
        private PictureBox picLogo;
        private Label lblGallegos;
        private Label lblDonRomulo;
        private Label lblComplejoEducativo;
        private PictureBox picFondoVinotinto;
        private Label lblRecuperarAcceso;
    }
}