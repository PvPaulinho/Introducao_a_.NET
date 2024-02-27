using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToPark
{
    internal class GerenciadorArrecadacao
    {
        public float ValorHora { get; set; } // Para configuramos o valor da hora dinâmicamente
        private float _arrecadado; // Para armazenar o total arrecadado

        public float Arrecadado // Esta propriedade serve para manipularmos os dados armazenados na variável "_arrecadado"
        {
            get => _arrecadado; // Simplesmente retorna o valor da variável "_arrecadado"
            set => _arrecadado += value; // Soma o valor atual da variável "_arrecadado" com o valor recebido e salva este na variável "_arrecadado"
        }

        public float CalcularEstadiaCliente(DateTime entrada) // Método usado para calcular o valor total que o cliente deve pagar
        {
            var permanencia = DateTime.Now - entrada; // Calcula o tempo de permanência desde a entrada até o presente momento

            if (permanencia.Hours <= 0) // Se foi a estadia foi menor que 1h, simplesmente retorna o valor de 1h...
                return ValorHora;
            else // ...senão, calcula o respectivo valor de acordo com o tempo de estadia
                return ValorHora * permanencia.Hours;
        }
    }
}
