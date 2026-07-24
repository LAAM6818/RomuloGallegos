using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Presentacion.ControlesPersonalizados
{
    [ToolboxItem(true)]
    public class MdsTabControl : TabControl
    {
        private const int WM_PAINT = 0x000F;
        private int _radius = 6;

        public MdsTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            DrawMode = TabDrawMode.OwnerDrawFixed;
            Alignment = TabAlignment.Top;
            Appearance = TabAppearance.Normal;
            ItemSize = new Size(120, 36);
            Padding = new Point(10, 3);

            // colores por defecto
            TabBackColor = Color.FromArgb(45, 45, 48);
            TabSelectedColor = Color.FromArgb(62, 62, 66);
            TabBorderColor = Color.FromArgb(50, 50, 58);
            TabForeColor = Color.White;
            TabInactiveForeColor = Color.LightGray;
        }
        #region Propiedades de color (aparecen en el diseñador)
        [Category("Appearance")]
        public Color TabBackColor { get; set; }

        [Category("Appearance")]
        public Color TabSelectedColor { get; set; }

        [Category("Appearance")]
        public Color TabBorderColor { get; set; }

        [Category("Appearance")]
        public Color TabForeColor { get; set; }

        [Category("Appearance")]
        public Color TabInactiveForeColor { get; set; }

        [Category("Appearance")]
        public int CornerRadius
        {
            get => _radius;
            set { _radius = value; Invalidate(); }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            BufferedPaintInit();
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.Clear(TabBackColor);

                if (SelectedIndex >= 0)
                {
                    using var path = GetTabRectPath(GetTabRect(SelectedIndex));
                    using var brush = new SolidBrush(TabSelectedColor);
                    e.Graphics.FillPath(brush, path);
                }

                for (int i = 0; i < TabCount; i++)
                    DrawTab(e.Graphics, i);

                using var pagePath = GetPageRectPath();
                using var borderPen = new Pen(TabBorderColor, 2);
                e.Graphics.DrawPath(borderPen, pagePath);
            }
            finally
            {
                BufferedPaintUnInit();
            }
        }

        private void DrawTab(Graphics g, int index)
        {
            Rectangle tabRect = GetTabRect(index);
            using var path = GetTabRectPath(tabRect);

            using var brush = new SolidBrush(index == SelectedIndex
                                             ? TabSelectedColor
                                             : TabBackColor);
            g.FillPath(brush, path);

            // aquí usas las propiedades expuestas
            Color textColor = index == SelectedIndex ? TabForeColor : TabInactiveForeColor;
            TextRenderer.DrawText(g, TabPages[index].Text, Font,
                                  tabRect, textColor,
                                  TextFormatFlags.HorizontalCenter |
                                  TextFormatFlags.VerticalCenter);

            using var pen = new Pen(TabBorderColor, 1);
            g.DrawPath(pen, path);
        }

        private GraphicsPath GetTabRectPath(Rectangle r)
        {
            var path = new GraphicsPath();
            int d = CornerRadius * 2;
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d - 1, r.Y, d, d, 270, 90);
            path.AddLine(r.Right - 1, r.Bottom, r.X, r.Bottom);
            path.CloseFigure();
            return path;
        }

        private GraphicsPath GetPageRectPath()
        {
            var r = ClientRectangle;
            var path = new GraphicsPath();
            int d = CornerRadius * 2;
            path.AddArc(r.X, r.Bottom - d, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 270, 90);
            path.AddLine(r.Right, r.Bottom - d, r.Right, r.Y + d);
            path.AddLine(r.Right, r.Y + d, r.X, r.Y + d);
            path.CloseFigure();
            return path;
        }

        [DllImport("uxtheme.dll", PreserveSig = false)]
        private static extern void BufferedPaintInit();

        [DllImport("uxtheme.dll", PreserveSig = false)]
        private static extern void BufferedPaintUnInit();
    }
}