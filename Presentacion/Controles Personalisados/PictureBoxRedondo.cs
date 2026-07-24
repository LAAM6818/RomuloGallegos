using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Presentacion.ControlesPersonalizados
{
    internal class PictureBoxRedondo : PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        public PictureBoxRedondo()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.DoubleBuffered = true;
        }

        // --- Propiedades con Invalidate() ---
        [Category("RJ Code Advance")]
        public int BorderSize { get { return borderSize; } set { borderSize = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public Color BorderColor { get { return borderColor; } set { borderColor = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public Color BorderColor2 { get { return borderColor2; } set { borderColor2 = value; this.Invalidate(); } }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = this.Height; // Mantener siempre cuadrado
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Obtenemos el objeto Graphics y configuramos máxima calidad
            Graphics graph = pe.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            graph.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Rectángulos de trabajo
            // El rectContour se infla un poco para asegurar que el recorte no "muerda" el borde
            Rectangle rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            Rectangle rectBorder = rectContourSmooth;

            if (borderSize > 0)
                rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize / 2, -borderSize / 2);

            using (GraphicsPath pathRegion = new GraphicsPath())
            {
                // Agregamos el círculo al path
                pathRegion.AddEllipse(rectContourSmooth);

                // Recortamos el control para que sea circular
                this.Region = new Region(pathRegion);

                // 1. Dibujamos la imagen de fondo si existe
                if (this.Image != null)
                {
                    // Creamos un path interno para la imagen para que no tape el borde
                    using (GraphicsPath pathImage = new GraphicsPath())
                    {
                        pathImage.AddEllipse(rectContourSmooth);
                        graph.SetClip(pathImage);
                        graph.DrawImage(this.Image, rectContourSmooth);
                        graph.ResetClip();
                    }
                }

                // 2. EL TRUCO PARA BORDES RASOS: 
                // Dibujamos el borde justo en el límite. Al usar PenAlignment.Inset, 
                // el borde crece hacia ADENTRO, evitando que se vea el corte de la región.
                if (borderSize > 0)
                {
                    using (LinearGradientBrush borderGColor = new LinearGradientBrush(rectContourSmooth, borderColor, borderColor2, gradientAngle))
                    using (Pen penBorder = new Pen(borderGColor, borderSize))
                    {
                        penBorder.DashStyle = borderLineStyle;
                        penBorder.DashCap = borderCapStyle;
                        penBorder.Alignment = PenAlignment.Inset; // IMPORTANTE: Crece hacia adentro

                        graph.DrawEllipse(penBorder, rectContourSmooth);
                    }
                }
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            if (this.Region != null) this.Region.Dispose();
        }
    }
}