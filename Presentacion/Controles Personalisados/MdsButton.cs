using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Presentacion.ControlesPersonalizados
{
    public class MdsButton : Button
    {
        #region fields
        private int _radius = 8;
        private float _borderWidth = 2f;
        private Color _borderColor = Color.LightGray;
        private Color _color1 = Color.DodgerBlue;
        private Color _color2 = Color.RoyalBlue;
        private float _gradientAngle = 90f;
        private bool _antialias = true;
        private bool _highQuality = true;
        #endregion

        #region props
        [Browsable(true), Category("MdsButton")]
        public int Radius
        {
            get => _radius;
            set { _radius = Math.Max(0, value); Invalidate(); }
        }

        [Browsable(true), Category("MdsButton"), DefaultValue(2f)]
        public float BorderWidth
        {
            get => _borderWidth;
            set { _borderWidth = Math.Max(0, value); Invalidate(); }
        }

        [Browsable(true), Category("MdsButton")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Browsable(true), Category("MdsButton")]
        public Color Color1
        {
            get => _color1;
            set { _color1 = value; Invalidate(); }
        }

        [Browsable(true), Category("MdsButton")]
        public Color Color2
        {
            get => _color2;
            set { _color2 = value; Invalidate(); }
        }

        [Browsable(true), Category("MdsButton")]
        public float GradientAngle
        {
            get => _gradientAngle;
            set { _gradientAngle = value % 360; Invalidate(); }
        }

        [Browsable(true), Category("MdsButton")]
        public bool Antialias
        {
            get => _antialias;
            set { _antialias = value; Invalidate(); }
        }

        [Browsable(true), Category("MdsButton")]
        public bool HighQuality
        {
            get => _highQuality;
            set { _highQuality = value; Invalidate(); }
        }
        #endregion

        public MdsButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }

        private GraphicsPath GetPath()
        {
            var r = ClientRectangle;
            r.Inflate(-1, -1);
            if (_radius == 0 || !_highQuality)
            {
                var path = new GraphicsPath();
                path.AddRectangle(r);
                return path;
            }

            var path2 = new GraphicsPath();
            path2.AddArc(r.X, r.Y, _radius, _radius, 180, 90);
            path2.AddArc(r.Right - _radius, r.Y, _radius, _radius, 270, 90);
            path2.AddArc(r.Right - _radius, r.Bottom - _radius, _radius, _radius, 0, 90);
            path2.AddArc(r.X, r.Bottom - _radius, _radius, _radius, 90, 90);
            path2.CloseFigure();
            return path2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!HighQuality) { base.OnPaint(e); return; }

            if (_antialias) e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var path = GetPath();

            // fondo gradiente
            using (var brush = new LinearGradientBrush(ClientRectangle,
                                                      _color1, _color2,
                                                      _gradientAngle))
                e.Graphics.FillPath(brush, path);

            // borde (solo si hay grosor)
            if (_borderWidth > 0)
                using (var pen = new Pen(_borderColor, _borderWidth))
                    e.Graphics.DrawPath(pen, path);

            // texto
            TextRenderer.DrawText(e.Graphics, Text, Font,
                                  ClientRectangle, ForeColor,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
