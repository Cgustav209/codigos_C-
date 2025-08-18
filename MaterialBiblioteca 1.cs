using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca
{
    //Recebe os dados dos materias que seram insiridos
    public abstract class MaterialBiblioteca
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int AnoPublicação { get; set; }

        public bool Disponivel { get; set; }

        public MaterialBiblioteca(int id, string titulo, string autor, int anoPublicacao)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AnoPublicação = anoPublicacao;
            Disponivel = true; 
        }

        public void Emprestar()
        {   // Quando usamos esse metodo ele verifica se Disponivel é verdadeiro, se for, ocorre o emprestimo, se não, nao ocorre
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"O material '{Titulo}' foi emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine($"O material '{Titulo}' não está disponível para empréstimo.");
            }

        }
        public void Devolver()
        {   // Quando usamos esse metodo ele verifica se Disponivel é verdadeiro, caso for ele executa caso nao for nenhum material é devolvido
            if (Disponivel)
            {
                Disponivel = true;
                Console.WriteLine("Devolvido com sucesso");
            }
        }
         //traz as informações cadastradas do material
      public void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano de Publicação: {AnoPublicação}");
            Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
        }


    }
}
