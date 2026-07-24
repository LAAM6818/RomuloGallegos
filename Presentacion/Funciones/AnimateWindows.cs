using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Funciones
{
    internal class AnimateWindows
    {

        //Importacion de la libreria user32.dll para poder usar las animaciones de ventanas de Windows
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        //Nos trae la funcion AnimateWindow de la libreria user32.dll
        private static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);

        //Ahora usaré flags para traer constantes activas de lo que serán las animaciones.

        [Flags]
        public enum AnimationFlags
        {
            //Tipos de animaciones
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0X00080000,
            AW_CENTER = 0x00000010,

            //Direcciones de movimiento
            AW_HOR_POSITIVE = 0x00000001, //Izquierda a Derecha
            AW_HOR_NEGATIVE = 0x00000002, //Derecha a Izquierda
            AW_VER_POSITIVE = 0x00000004, //Arriba hacia Abajo
            AW_VER_NEGATIVE = 0x00000008, //Abajo a Arriba

            //Acciones para la animación
            AW_HIDE = 0x00010000, //Ocultar la ventana
            AW_ACTIVATE = 0x00020000 //Mostrar la ventana
        }

        //Método para iniciar la animación
        public static void Start(Control target, int durationMS, AnimationFlags flags)
        {
            if (target == null)
                return;

            AnimateWindow(target.Handle, durationMS, (int)flags);
        }
    }
}

