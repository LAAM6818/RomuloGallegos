using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.ControlesPersonalizados
{
    internal interface IAsyncLoad
    {
        Task LoadAsync(CancellationToken token);
    }
}
