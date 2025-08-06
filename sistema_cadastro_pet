/////////// CLASSES //////////////////////////////////////////////////////////////////////////////////////////

 
 public class Animal     //
    {
        public string Nome {  get; set; }
        public int Idade { get; set; }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome:{Nome}, Idade: {Idade}");
        }
    }
 public class Gato:Animal    //
    {
        public bool GostarDeColo {  get; set; }

        public override void ExibirInfo()
        {                                 //se   //else
            string resposta = GostarDeColo ? "Sim" : "Não"; //um tipo de if e else simplificado
            Console.WriteLine($"Gato -> Nome {Nome}, Idade: {Idade}, Gosta de Colo: {resposta}");
        }
    }
 public class Cachorro : Animal  //
    {
        public string Raca {  get; set; }
        public override void ExibirInfo()
        {
            Console.WriteLine($"Cachorro -> Nome: {Nome}, Idade: {Idade}, Raça: {Raca}");
        }
    }
    ///////////// PROGRAMA //////////////////////////////////////////////////////////////////////////////////////////////////
    
     internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listaAnimais = new List<Animal>();

            Cachorro cachorro1 = new Cachorro { Nome = "Thor", Idade = 5, Raca = "Viralata" };
            Gato gato1 = new Gato { Nome = "Mingal", Idade = 3, GostarDeColo = true };
            Cachorro cachorro2 = new Cachorro { Nome = "Mary", Idade = 3, Raca = "Lhasa Apso" };

            listaAnimais.Add(cachorro1);
            listaAnimais.Add(gato1 );
            listaAnimais.Add (cachorro2);

            Console.WriteLine("=== Lista de Animais ===\n");

            foreach (Animal animal in listaAnimais)
            {
                animal.ExibirInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
            Console.Clear();
          }
    }

