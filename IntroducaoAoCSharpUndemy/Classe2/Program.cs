namespace Classe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Rex", 5);
            var g = new Gato("Peste", 1);

            Animal a = new Gato("Demonio", 2); //Polimorfismo -> O objeto tem mais de uma forma

            ExibeAnimal(c);
            ExibeAnimal(g);
            ExibeAnimal(a);
        }

        public static void ExibeAnimal (Animal animal)
        {
            Console.WriteLine("\nNome: " + animal.Nome + "\n");
            Console.WriteLine($"Idade: {animal.Idade}\n");
            Console.WriteLine($"Som emitido: {animal.SomEmitido}\n");
            Console.WriteLine($"Locomoção: {animal.Locomocao}\n\n");
        }
    }
}
