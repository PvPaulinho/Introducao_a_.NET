using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    public static class OperacoesAritmeticas
    {
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }

        public static double subtracao(double minuando, double subtraendo)
        {
            return minuando - subtraendo;
        }

        public static double multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }

        public static double divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
