using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.ControlesPersonalizados
{
    public class BufferedTextBox : TextBox
    {
        public BufferedTextBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
             ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            Parent?.Invalidate(new Rectangle(Left - 1, Top - 1, Width + 2, Height + 2));
        }
    }
}
