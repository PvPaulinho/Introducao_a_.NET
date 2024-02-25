namespace LacosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Laços condicionais -> Execução mediante uma condição/situação satisfeita
            int hora = 14;
            if (hora >= 15)
            {
                Console.WriteLine("Já são mais 15h ou mais");
            }
            else if (hora >= 13) //So executará se o primeiro não for satisfeita
            { Console.WriteLine("Já são mais 13h ou mais"); }

            // Switch ... case -> Só executa o caso em que a condição e satisfeita exatamente
            switch(hora) {
                case 13:
                    Console.WriteLine("São 13 horas!");
                    break;
                case 14:
                    Console.WriteLine("São 14 horas!");
                    break;
                case 15:
                    Console.WriteLine("São 15 horas!");
                    break;
            }

            PrimeiroSemestre mes = PrimeiroSemestre.Março;

            // Utilizando Switch ... case
            switch (mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Nós estamos em Janeiro!");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Nós estamos em Fevereiro!");
                    break;
                case PrimeiroSemestre.Março:
                    Console.WriteLine("Nós estamos em Março!");
                    break;
                case PrimeiroSemestre.Abril:
                    Console.WriteLine("Nós estamos em Abril!");
                    break;
                case PrimeiroSemestre.Maio:
                    Console.WriteLine("Nós estamos em Maio!");
                    break;
                case PrimeiroSemestre.Junho:
                    Console.WriteLine("Nós estamos em Junho!");
                    break;
                default: //Será executado caso nenhuma das condições tenha sido satisfeitas
                    Console.WriteLine("Nós não estamos no Primeiro semestre do ano!. Nós estamos no mes: " + mes);
                    break;
            }

            // utilizando if ... else
            if (mes == PrimeiroSemestre.Janeiro)
            {
                Console.WriteLine("Nós estamos em Janeiro!");
            } else if (mes == PrimeiroSemestre.Fevereiro)
            {
                Console.WriteLine("Nós estamos em Fevereiro!");
            }
            else if (mes == PrimeiroSemestre.Março)
            {
                Console.WriteLine("Nós estamos em Março!");
            }
            else if (mes == PrimeiroSemestre.Abril)
            {
                Console.WriteLine("Nós estamos em Abril!");
            }
            else if (mes == PrimeiroSemestre.Maio)
            {
                Console.WriteLine("Nós estamos em Maio!");
            } 
            else if (mes == PrimeiroSemestre.Junho)
            {
                Console.WriteLine("Nós estamos em Junho!");
            }
            else
            {
                Console.WriteLine("Nós não estamos no Primeiro semestre do ano!");
            })
        }
    }

    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Março, Abril, Maio, Junho
    }

}
