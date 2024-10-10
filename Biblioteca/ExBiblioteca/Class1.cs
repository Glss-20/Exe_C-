using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExBiblioteca
{
    public class Biblioteca
    {
        public List<Livro> livros;// Lista de livros

        public Biblioteca()
        {
            livros = new List<Livro>();// Inicializa a lista de livros
        }
        
        public void AdicionarLivros(Livro livro)
        {
            livros.Add(livro);
            Console.WriteLine($"Livro {livro.Titulo} foi adicionado!");
        }
        public void ListarLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de Livros: ");
                int cont = 0;
                while (cont < livros.Count)
                {
                    livros[cont].ExibirDetalhes();
                    cont++;
                }
            }

        }
        public void BuscarLivros(string titulo)
        {
            var resultado = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (resultado != null)
            {
                Console.WriteLine("\nLivro encontrado:");
                resultado.ExibirDetalhes(); // Chama o método para exibir detalhes
            }
            else
            {
                Console.WriteLine($"Nenhum livro encontrado com o título '{titulo}'.");
            }
        }

    }       
}
