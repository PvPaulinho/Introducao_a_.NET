namespace TiposEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10; // Declarando uma variável
            int numero2 = 10;
            var soma = numero1 + numero2; // O 'var' define dinamicamente o tipo da variável (É uma variável global)
            Console.WriteLine("O valor da soma é: " + soma);

            var quadrado1 = new Quadrado(); //Cria um objeto do tipo Quadrado
            quadrado1.lado = 10; //quadrado1 terá o valor de lado igual a 10
            var quadrado2 = quadrado1; /*Desta forma está criando apenas uma variável do tipo referência
                                         Pois quadrado2 não foi criada com um objeto, mas apenas uma variável
                                         que recebe a referência do objeto quadrado1*/
            quadrado2.lado = 11;
            //A alteração na variável de referência irá alterar o valor de todas ao mesmo tempo
            Console.WriteLine("Valor do lado do quadrado1: " + quadrado1.lado);
            Console.WriteLine("Valor do lado do quadrado2: " + quadrado2.lado);
        }

        class Quadrado
        {
            public int lado;
        }
    }
}
