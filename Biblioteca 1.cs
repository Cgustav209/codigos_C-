using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca
{
    public class Biblioteca
    {
        List<MaterialBiblioteca> listaMaterialBiblioteca = new List<MaterialBiblioteca>();

        public void AdicionarMaterial(MaterialBiblioteca item)
        {   
            listaMaterialBiblioteca.Add(item);
            Console.WriteLine($"Material '{item}' adicionado à biblioteca.");
        }
        public void ListarMateriais()
        
        {      //Caso não tenha nenhum material cadastrado
            if (listaMaterialBiblioteca.Count == 0)
            {
                Console.WriteLine("Nenhum material na biblioteca.");
            }
            else
            {
                Console.WriteLine("Materiais na biblioteca:");
                foreach (var material in listaMaterialBiblioteca)
                {
                    Console.WriteLine($"- {material}");
                }
            }
        }
        public void BuscarPorTitulo()
        {   //ToLower= trasnforma todas as letras minusculo, que facilita para a pesquisa do material
            Console.WriteLine("Digite o título do material que deseja buscar:");
            string? Busca = Console.ReadLine().ToLower();


              ///Find pede a localização do atributo desejado e dps procura pelo informação dada= (item => item.atributo que voce queira encontrar.ToLower() == busca)
            MaterialBiblioteca? materialEncontrado = listaMaterialBiblioteca.Find(material => material.Titulo.ToLower() == Busca);
                
            if (materialEncontrado != null)
            {
                Console.WriteLine("O material está na biblioteca");
            }
            else
            {
                Console.WriteLine("\nO material não está na biblioteca");

            }
            //Caso o usuario queira busca por outro material
            Console.WriteLine("Deseja buscar novamente? (s/n)");
            string? resposta = Console.ReadLine();



            if (resposta.ToLower() == "s")
            {
                BuscarPorTitulo();
            }
            else if (resposta == "n")
            {
                Console.WriteLine("Busca encerrada.");
            }
            else
            {
                Console.WriteLine("Opção inválida. Encerrando busca.");
            }
        }
        //pega as informações do material, e usa do metodo emprestar para alterar o dado disponivel para falso
        public void EmprestarMaterial()
        {
            Console.WriteLine("Digite o ID do material que deseja empréstimo:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                MaterialBiblioteca? materialEmprestado = listaMaterialBiblioteca.FirstOrDefault(material => material.Id == id);
                if (materialEmprestado != null)
                {
                    materialEmprestado.Emprestar();
                }
                else
                {
                    Console.WriteLine("Material não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }

        }
        //Recebe os dados do material, caso sejam validos, ele usa do metodo devolver e altera o dispnivel para verdadeiro
        public void DevolverMaterial()
        {
            Console.WriteLine("Digite o ID do material que deseja devolver:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                MaterialBiblioteca? materialDevolvido = listaMaterialBiblioteca.FirstOrDefault(material => material.Id == id);
                if (materialDevolvido != null)
                {
                    materialDevolvido.Devolver();
                }
                else
                {
                    Console.WriteLine("Material não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }

    }
}
