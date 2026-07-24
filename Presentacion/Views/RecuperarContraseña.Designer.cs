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
            btnRecuperarContraseña = new Krypton.Toolkit.KryptonButton();
            linkIniciarSesion = new LinkLabel();
            txtCorreo = new TextBox();
            pnlArriba = new Panel();
            lblEmail = new Label();
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
            txtToken = new TextBox();
            lblToken = new Label();
            btnVlidarToken = new Krypton.Toolkit.KryptonButton();
            btnActualizarContraseña = new Krypton.Toolkit.KryptonButton();
            txtContraseña = new TextBox();
            txtContraseñaRepetida = new TextBox();
            lblContraseña = new Label();
            lblRepetirContraseña = new Label();
            pnlAbajo = new Panel();
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
            picCerrar.Click += picCerrar_Click;
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
            // btnRecuperarContraseña
            // 
            btnRecuperarContraseña.Location = new Point(562, 332);
            btnRecuperarContraseña.Name = "btnRecuperarContraseña";
            btnRecuperarContraseña.OverrideDefault.Back.Color1 = Color.FromArgb(82, 26, 27);
            btnRecuperarContraseña.OverrideDefault.Back.Color2 = Color.FromArgb(82, 26, 27);
            btnRecuperarContraseña.Size = new Size(288, 43);
            btnRecuperarContraseña.StateCommon.Back.Color1 = Color.FromArgb(82, 26, 27);
            btnRecuperarContraseña.StateCommon.Back.Color2 = Color.FromArgb(82, 26, 27);
            btnRecuperarContraseña.StateCommon.Border.Color1 = Color.FromArgb(234, 219, 211);
            btnRecuperarContraseña.StateCommon.Border.Color2 = Color.FromArgb(234, 219, 211);
            btnRecuperarContraseña.StateCommon.Content.ShortText.Color1 = Color.FromArgb(234, 219, 211);
            btnRecuperarContraseña.StateCommon.Content.ShortText.Color2 = Color.FromArgb(234, 219, 211);
            btnRecuperarContraseña.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecuperarContraseña.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            btnRecuperarContraseña.StatePressed.Back.Color1 = Color.FromArgb(45, 29, 29);
            btnRecuperarContraseña.StatePressed.Back.Color2 = Color.FromArgb(45, 29, 29);
            btnRecuperarContraseña.TabIndex = 23;
            btnRecuperarContraseña.Values.DropDownArrowColor = Color.Empty;
            btnRecuperarContraseña.Values.Text = "Recuperar Contraseña";
            btnRecuperarContraseña.Click += btnRecuperarContraseña_Click;
            // 
            // linkIniciarSesion
            // 
            linkIniciarSesion.ActiveLinkColor = Color.FromArgb(107, 20, 32);
            linkIniciarSesion.AutoSize = true;
            linkIniciarSesion.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkIniciarSesion.LinkBehavior = LinkBehavior.HoverUnderline;
            linkIniciarSesion.LinkColor = Color.FromArgb(107, 20, 32);
            linkIniciarSesion.Location = new Point(648, 284);
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
            // pnlArriba
            // 
            pnlArriba.BackColor = Color.FromArgb(171, 159, 145);
            pnlArriba.ForeColor = Color.FromArgb(171, 159, 145);
            pnlArriba.Location = new Point(564, 262);
            pnlArriba.Name = "pnlArriba";
            pnlArriba.Size = new Size(285, 2);
            pnlArriba.TabIndex = 20;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(43, 27, 24);
            lblEmail.Location = new Point(559, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.FromArgb(107, 92, 85);
            lblMensaje.Location = new Point(559, 148);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(109, 17);
            lblMensaje.TabIndex = 14;
            lblMensaje.Text = "Rapido y sencillo";
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
            // txtToken
            // 
            txtToken.BackColor = Color.FromArgb(239, 230, 210);
            txtToken.BorderStyle = BorderStyle.None;
            txtToken.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtToken.ForeColor = Color.DimGray;
            txtToken.Location = new Point(563, 237);
            txtToken.Name = "txtToken";
            txtToken.PlaceholderText = "Ingrse el token";
            txtToken.Size = new Size(286, 22);
            txtToken.TabIndex = 25;
            txtToken.Visible = false;
            // 
            // lblToken
            // 
            lblToken.AutoSize = true;
            lblToken.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToken.ForeColor = Color.FromArgb(43, 27, 24);
            lblToken.Location = new Point(558, 209);
            lblToken.Name = "lblToken";
            lblToken.Size = new Size(50, 20);
            lblToken.TabIndex = 26;
            lblToken.Text = "Token";
            lblToken.Visible = false;
            // 
            // btnVlidarToken
            // 
            btnVlidarToken.Location = new Point(562, 332);
            btnVlidarToken.Name = "btnVlidarToken";
            btnVlidarToken.OverrideDefault.Back.Color1 = Color.FromArgb(82, 26, 27);
            btnVlidarToken.OverrideDefault.Back.Color2 = Color.FromArgb(82, 26, 27);
            btnVlidarToken.Size = new Size(288, 43);
            btnVlidarToken.StateCommon.Back.Color1 = Color.FromArgb(82, 26, 27);
            btnVlidarToken.StateCommon.Back.Color2 = Color.FromArgb(82, 26, 27);
            btnVlidarToken.StateCommon.Border.Color1 = Color.FromArgb(234, 219, 211);
            btnVlidarToken.StateCommon.Border.Color2 = Color.FromArgb(234, 219, 211);
            btnVlidarToken.StateCommon.Content.ShortText.Color1 = Color.FromArgb(234, 219, 211);
            btnVlidarToken.StateCommon.Content.ShortText.Color2 = Color.FromArgb(234, 219, 211);
            btnVlidarToken.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVlidarToken.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            btnVlidarToken.StatePressed.Back.Color1 = Color.FromArgb(45, 29, 29);
            btnVlidarToken.StatePressed.Back.Color2 = Color.FromArgb(45, 29, 29);
            btnVlidarToken.TabIndex = 27;
            btnVlidarToken.Values.DropDownArrowColor = Color.Empty;
            btnVlidarToken.Values.Text = "Validar Token";
            btnVlidarToken.Visible = false;
            btnVlidarToken.Click += btnVlidarToken_Click;
            // 
            // btnActualizarContraseña
            // 
            btnActualizarContraseña.Location = new Point(561, 412);
            btnActualizarContraseña.Name = "btnActualizarContraseña";
            btnActualizarContraseña.OverrideDefault.Back.Color1 = Color.FromArgb(82, 26, 27);
            btnActualizarContraseña.OverrideDefault.Back.Color2 = Color.FromArgb(82, 26, 27);
            btnActualizarContraseña.Size = new Size(288, 43);
            btnActualizarContraseña.StateCommon.Back.Color1 = Color.FromArgb(82, 26, 27);
            btnActualizarContraseña.StateCommon.Back.Color2 = Color.FromArgb(82, 26, 27);
            btnActualizarContraseña.StateCommon.Border.Color1 = Color.FromArgb(234, 219, 211);
            btnActualizarContraseña.StateCommon.Border.Color2 = Color.FromArgb(234, 219, 211);
            btnActualizarContraseña.StateCommon.Content.ShortText.Color1 = Color.FromArgb(234, 219, 211);
            btnActualizarContraseña.StateCommon.Content.ShortText.Color2 = Color.FromArgb(234, 219, 211);
            btnActualizarContraseña.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarContraseña.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias;
            btnActualizarContraseña.StatePressed.Back.Color1 = Color.FromArgb(45, 29, 29);
            btnActualizarContraseña.StatePressed.Back.Color2 = Color.FromArgb(45, 29, 29);
            btnActualizarContraseña.TabIndex = 28;
            btnActualizarContraseña.Values.DropDownArrowColor = Color.Empty;
            btnActualizarContraseña.Values.Text = "Actualizar";
            btnActualizarContraseña.Visible = false;
            btnActualizarContraseña.Click += btnActualizarContraseña_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(239, 230, 210);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(563, 237);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Ingrse el token";
            txtContraseña.Size = new Size(286, 22);
            txtContraseña.TabIndex = 29;
            txtContraseña.Visible = false;
            // 
            // txtContraseñaRepetida
            // 
            txtContraseñaRepetida.BackColor = Color.FromArgb(239, 230, 210);
            txtContraseñaRepetida.BorderStyle = BorderStyle.None;
            txtContraseñaRepetida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaRepetida.ForeColor = Color.DimGray;
            txtContraseñaRepetida.Location = new Point(563, 323);
            txtContraseñaRepetida.Name = "txtContraseñaRepetida";
            txtContraseñaRepetida.PlaceholderText = "Ingrse el token";
            txtContraseñaRepetida.Size = new Size(286, 22);
            txtContraseñaRepetida.TabIndex = 30;
            txtContraseñaRepetida.Visible = false;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.ForeColor = Color.FromArgb(43, 27, 24);
            lblContraseña.Location = new Point(558, 209);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(135, 20);
            lblContraseña.TabIndex = 31;
            lblContraseña.Text = "Nueva Contraseña";
            lblContraseña.Visible = false;
            // 
            // lblRepetirContraseña
            // 
            lblRepetirContraseña.AutoSize = true;
            lblRepetirContraseña.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepetirContraseña.ForeColor = Color.FromArgb(43, 27, 24);
            lblRepetirContraseña.Location = new Point(561, 296);
            lblRepetirContraseña.Name = "lblRepetirContraseña";
            lblRepetirContraseña.Size = new Size(193, 20);
            lblRepetirContraseña.TabIndex = 32;
            lblRepetirContraseña.Text = "Repita la nueva contraseña";
            lblRepetirContraseña.Visible = false;
            // 
            // pnlAbajo
            // 
            pnlAbajo.BackColor = Color.FromArgb(171, 159, 145);
            pnlAbajo.ForeColor = Color.FromArgb(171, 159, 145);
            pnlAbajo.Location = new Point(563, 349);
            pnlAbajo.Name = "pnlAbajo";
            pnlAbajo.Size = new Size(285, 2);
            pnlAbajo.TabIndex = 21;
            pnlAbajo.Visible = false;
            // 
            // RecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 230, 210);
            ClientSize = new Size(940, 580);
            Controls.Add(pnlAbajo);
            Controls.Add(lblRepetirContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtContraseñaRepetida);
            Controls.Add(txtContraseña);
            Controls.Add(btnActualizarContraseña);
            Controls.Add(btnVlidarToken);
            Controls.Add(lblToken);
            Controls.Add(txtToken);
            Controls.Add(picCerrar);
            Controls.Add(lblPortal);
            Controls.Add(btnRecuperarContraseña);
            Controls.Add(linkIniciarSesion);
            Controls.Add(txtCorreo);
            Controls.Add(pnlArriba);
            Controls.Add(lblEmail);
            Controls.Add(lblMensaje);
            Controls.Add(pnlPic);
            Controls.Add(lblRecuperarAcceso);
            DoubleBuffered = true;
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
        private Krypton.Toolkit.KryptonButton btnRecuperarContraseña;
        private LinkLabel linkIniciarSesion;
        private TextBox txtCorreo;
        private Panel pnlArriba;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Panel pnlContraseña;
        private Panel pnlUsuario;
        private Label lblContraseña;
        private Label lblRepetirContraseña;
        private Panel pnlAbajo;
        private Label lblEmail;
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
        private TextBox txtToken;
        private Label lblToken;
        private Krypton.Toolkit.KryptonButton btnVlidarToken;
        private Krypton.Toolkit.KryptonButton btnActualizarContraseña;
        private TextBox txtContraseñaRepetida;
    }
}