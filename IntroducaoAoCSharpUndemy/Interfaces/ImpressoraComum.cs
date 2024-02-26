using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ImpressoraComum : IImpressora
    {
        public string Imprimir(string texto)
        {
            return $"Texto a ser impresso: {texto}";
        }
    }
}
