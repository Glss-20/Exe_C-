using System;
using System.Security.Cryptography.X509Certificates;

namespace ExBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            int opcao = 0;

            while (opcao != 6)
            {
                Console.WriteLine("--------------Bem vindo a Biblioteca--------------");
                Console.WriteLine("1. Adicionar um livro");
                Console.WriteLine("2. Listar livros disponíveis");
                Console.WriteLine("3. Buscar livro por título");
                Console.WriteLine("4. Sair");

                Console.Write("Digite uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: 
                        AdicionarLivros(biblioteca);
                        break;

                    case 2:
                        biblioteca.ListarLivros();
                        break;

                    case 3:
                        BuscarLivro(biblioteca);
                        break;

                    case 4:
                        break;

                }

            }
        }

        static void AdicionarLivros(Biblioteca biblioteca)
        {
            Console.WriteLine("Título do livro");
            string titulo = Console.ReadLine();

            Console.WriteLine("Autor do livro");
            string autor = Console.ReadLine();

            Console.WriteLine("Ano do livro");
            int ano = int.Parse(Console.ReadLine());

            Livro novoLivro = new Livro(titulo, autor, ano);
            biblioteca.AdicionarLivros(novoLivro);      
        }

        static void BuscarLivro(Biblioteca biblioteca)
        {
            Console.WriteLine("Informe o título: ");
            string titulo = Console.ReadLine();
            biblioteca.BuscarLivros(titulo);
        }

    }
}
