using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca
{
    public class revista : MaterialBiblioteca
    {
        //Essa classe herdar as informaçoes da classe MaterialBiblioteca e traz duas informacoes especificas
        public revista(string titulo, string autor, int anoPublicacao, int id)
            : base(id,titulo, autor, anoPublicacao)
        {
        }
        public void Edicao()
        {
            Console.WriteLine("Digite a edição da revista:");
            string? edicao = Console.ReadLine();
            Console.WriteLine($"A edição da revista '{Titulo}' é {edicao}.");
        }
    }
}
