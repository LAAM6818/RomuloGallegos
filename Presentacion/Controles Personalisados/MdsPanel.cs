using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Presentacion.ControlesPersonalizados
{
    [ToolboxItem(true)]
    public class PanelMds : Panel
    {
        private int _radio = 12;
        private Color _color1 = Color.FromArgb(45, 45, 48);
        private Color _color2 = Color.FromArgb(32, 32, 32);
        private float _angulo = 90f;
        private bool _antiAlias = true;
        private bool _highQuality = true;

        [Category("PanelMds")]
        public int RadioEsquinas
        {
            get => _radio;
            set { _radio = Math.Max(0, value); Invalidate(); }
        }

        [Category("PanelMds")]
        public bool AntiAlias
        {
            get => _antiAlias;
            set { _antiAlias = value; Invalidate(); }
        }

        [Category("PanelMds")]
        public bool HighQuality
        {
            get => _highQuality;
            set { _highQuality = value; Invalidate(); }
        }


        [Category("PanelMds")]
        public Color Color1
        {
            get => _color1;
            set { _color1 = value; Invalidate(); }
        }

        [Category("PanelMds")]
        public Color Color2
        {
            get => _color2;
            set { _color2 = value; Invalidate(); }
        }

        [Category("PanelMds")]
        public float AnguloDegradado
        {
            get => _angulo;
            set { _angulo = value; Invalidate(); }
        }

        public PanelMds()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.DoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (AntiAlias)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            }

            if (HighQuality)
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            }

            if (RadioEsquinas == 0)
            {
                // Panel nativo: degradado sin redondeo
                using (var brush = new LinearGradientBrush(ClientRectangle,
                                                           Color1,
                                                           Color2,
                                                           AnguloDegradado))
                {
                    e.Graphics.FillRectangle(brush, ClientRectangle);
                }
            }
            else
            {
                // Redondeado
                using (var path = GetRoundRect(ClientRectangle, RadioEsquinas))
                using (var brush = new LinearGradientBrush(ClientRectangle,
                                                           Color1,
                                                           Color2,
                                                           AnguloDegradado))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            base.OnPaint(e);
        }

        private GraphicsPath GetRoundRect(Rectangle rect, int r)
        {
            var path = new GraphicsPath();
            int d = r << 1;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
