namespace LacosIterativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Laços iterativos -> São estruturas que se repetem um bloco de códigos, determinado número de vezes

            // Laço for
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("Valor de i: " + i);
            }

            //While -> testa a condição e depois executa
            int cont = 0;
            while(cont++ < 10)//Faz a verificação do valor de cont depois incrementa 1 no valor de cont e executa
            {
                Console.WriteLine("Valor de cont: " + cont);
            }
            while(cont < 10) //Vai incrementar somente depois de exibir o valor no laço
            {
                Console.WriteLine("Valor de cont: " + cont);
                cont++;
            }

            //do .. while -> Primeiro executa uma vez e depois testa a contição
            double j = 10;
            do
            {
                Console.WriteLine("Valor de j: " + j);
                j = j * 1.5;
            } while (j < 100);

            //foreach -> Percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 4, 5, };
            foreach(int numero in conjunto) //O contador será sempre o tamanho do conjunto
            { //Está colocando o valor do elemento do conjunto que vem no laço dentro da variável numero
                Console.WriteLine("Esse elemento do conjunto tem o valor: " + numero);
            }
        }
    }
}
