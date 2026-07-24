using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Presentacion.ControlesPersonalizados
{
    [DefaultEvent(nameof(TextChanged))]
    public partial class MdsTextBox : UserControl
    {
        private TextBox textBox;
        private bool isFocused;
        private bool useAntiAlias = true;
        private bool useHighQuality = true;

        private Color borderColor = Color.FromArgb(130, 130, 130);
        private Color borderFocusColor = Color.FromArgb(0, 120, 215);
        private int borderSize = 2;
        private int borderRadius = 0;
        private string placeHolderText = string.Empty;

        public MdsTextBox()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            BackColor = Color.White;
            Padding = new Padding(10, 7, 10, 7);
            Size = new Size(200, 35);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (textBox != null) return;

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                BackColor = BackColor,
                ForeColor = ForeColor,
                Font = Font,
                TabStop = true
            };

            textBox.Enter += (_, _) => { isFocused = true; Invalidate(); };
            textBox.Leave += (_, _) => { isFocused = false; Invalidate(); };
            textBox.TextChanged += (_, e) => { OnTextChanged(e); Invalidate(); };
            textBox.KeyDown += (_, e) => OnKeyDown(e);
            textBox.KeyPress += (_, e) => OnKeyPress(e);
            textBox.KeyUp += (_, e) => OnKeyUp(e);

            Controls.Add(textBox);
            AdjustHeight();
        }

        [Category("MDS")]
        public override string Text
        {
            get => textBox?.Text ?? string.Empty;
            set
            {
                if (textBox != null)
                {
                    textBox.Text = value;
                    Invalidate();
                }
            }
        }

        [Category("MDS")]
        public string PlaceHolder
        {
            get => placeHolderText;
            set { placeHolderText = value; Invalidate(); }
        }

        [Category("MDS")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("MDS")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = Math.Max(1, value); Invalidate(); }
        }

        [Category("MDS")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("MDS")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set { borderFocusColor = value; Invalidate(); }
        }

        [Category("MDS")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                if (textBox != null) textBox.BackColor = value;
                Invalidate();
            }
        }

        [Category("MDS")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                if (textBox != null) textBox.ForeColor = value;
                Invalidate();
            }
        }

        [Category("MDS")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                if (textBox != null) textBox.Font = value;
                AdjustHeight();
            }
        }

        [Category("MDS")]
        [DefaultValue(true)]
        public bool UseAntiAlias
        {
            get => useAntiAlias;
            set { useAntiAlias = value; Invalidate(); }
        }

        [Category("MDS")]
        [DefaultValue(true)]
        public bool UseHighQuality
        {
            get => useHighQuality;
            set { useHighQuality = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = useAntiAlias ? SmoothingMode.AntiAlias : SmoothingMode.None;
            e.Graphics.InterpolationMode = useHighQuality ? InterpolationMode.HighQualityBicubic : InterpolationMode.NearestNeighbor;

            Rectangle rect = new Rectangle(
                borderSize / 2,
                borderSize / 2,
                Width - borderSize,
                Height - borderSize
            );

            using Pen pen = new Pen(isFocused ? borderFocusColor : borderColor, borderSize)
            {
                Alignment = PenAlignment.Center
            };

            if (borderRadius <= 0)
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                e.Graphics.DrawRectangle(pen, rect);
            }
            else
            {
                using GraphicsPath path = GetRoundedPath(rect, borderRadius);
                e.Graphics.DrawPath(pen, path);
            }

            // Dibujar PlaceHolder si corresponde
            if (!isFocused && string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(placeHolderText))
            {
                using SolidBrush brush = new SolidBrush(Color.Gray);
                StringFormat sf = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near };
                Rectangle placeholderRect = new Rectangle(rect.X + Padding.Left, rect.Y, rect.Width - Padding.Horizontal, rect.Height);
                e.Graphics.DrawString(placeHolderText, Font, brush, placeholderRect, sf);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            float r = radius * 2f;
            GraphicsPath path = new();

            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void AdjustHeight()
        {
            if (textBox == null) return;

            // Altura según la fuente actual + padding + borde
            int newHeight = Font.Height + Padding.Top + Padding.Bottom + borderSize;
            textBox.Height = newHeight;
            if (Height < newHeight) Height = newHeight;
        }

        // Delegación de eventos
        public new event KeyEventHandler KeyDown;
        public new event KeyPressEventHandler KeyPress;
        public new event KeyEventHandler KeyUp;

        protected override void OnKeyDown(KeyEventArgs e) => KeyDown?.Invoke(this, e);
        protected override void OnKeyPress(KeyPressEventArgs e) => KeyPress?.Invoke(this, e);
        protected override void OnKeyUp(KeyEventArgs e) => KeyUp?.Invoke(this, e);

        public override bool Focused => textBox?.Focused ?? false;
        public TextBox InnerTextBox => textBox;
    }
}