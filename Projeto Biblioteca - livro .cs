using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca
{   //Essa classe herdar as informaçoes da classe MaterialBiblioteca e traz duass especificas
    public class livro : MaterialBiblioteca
    {
        public livro(int id, string titulo, string autor, int anoPublicacao) : base(id, titulo, autor, anoPublicacao)
        {
        }

        public void Genero()
        {
            Console.WriteLine("Digite o gênero do livro:");
            string? genero = Console.ReadLine();
            Console.WriteLine($"O gênero do livro '{Titulo}' é {genero}.");
        }
    }
}
