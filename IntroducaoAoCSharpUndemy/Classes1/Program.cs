namespace Classes1
{
    class Program //Sem modificador de acesso explícito, por padrão será internal
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Prata, 2, "Celta 2001"); //Criando carro

            //Exibindo atributos
            Console.WriteLine("\nO carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas.\n");            

            Console.WriteLine(carro.Ligar());
            Console.WriteLine("\nO carro está ligado?" + carro.Ligado + "\n");
            Console.WriteLine(carro.Andar() + "\n");
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("\nO carro está ligado?" + carro.Ligado + "\n");
            carro.Cor = Cor.Azul;
            Console.WriteLine("A cor do carro está como: " + carro.Cor);
        }
    }
}
