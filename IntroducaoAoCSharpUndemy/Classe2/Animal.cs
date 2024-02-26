using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe2
{
    public abstract class Animal
    {
        public string Nome { get; }
        public int Idade { get; }
        public abstract Som SomEmitido { get; }
        public virtual string Locomocao { get { return "Está andando"; } }//Esta propriedade pode ou não ser sobreescrita pelas classes filhas

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
