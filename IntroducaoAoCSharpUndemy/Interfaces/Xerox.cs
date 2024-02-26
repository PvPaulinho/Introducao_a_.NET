using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Xerox : ICopiadora
    {
        public string Copiar(string texto)
        {
            return $"Texto a ser copiado: {texto}";
        }
    }
}
