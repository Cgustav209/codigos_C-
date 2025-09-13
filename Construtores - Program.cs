using System.Runtime.CompilerServices;

namespace Construtores_C_
{
    class Program
    {
        static void Main()
        {    Produto produto1 = new Produto();
             Produto produto2 = new Produto("Notebook",3500.0,10);


            Console.WriteLine("Produto 1:");
            Console.WriteLine($"Nome: {produto1.Nome}, Preço: {produto1.Preco}, Quantidade: {produto1.Quantidade}");

            Console.WriteLine("Produto 2:");
            Console.WriteLine($"Nome: {produto2.Nome}, Preço: {produto2.Preco}, Quantidade: {produto2.Quantidade}");


            //Aluno aluno1 = new Aluno();
            //Aluno aluno2 = new Aluno("Antony",9.5);

            ////string nome = Console.ReadLine();
            ////double nota = Console.ReadLine();

            ////Aluno aluno3 = new Aluno(nome, nota);



            //Console.WriteLine("Aluno1:");
            //Console.WriteLine($"Nome: {aluno1.Nome}, Nota: {aluno1.Nota}");

            //Console.WriteLine("Aluno2:");
            //Console.WriteLine($"Nome: {aluno2.Nome}, Nota: {aluno2.Nota}");

        }
    }
}
