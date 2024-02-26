using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe2
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade) : base(nome, idade) //base -> Invoca o construtor da classe pai
        {
        }

        public override Som SomEmitido => Som.Miado;

        public override string Locomocao => "Está pulando.";
    }
}
