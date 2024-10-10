using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExBiblioteca
{
    public class Livro
    {
        public string Titulo; //Atributo público para título
        public string Autor;
        public int Ano; 

        public Livro(string titulo, string autor, int ano) 
        //Método Construtor - é chamado automaticamente quando você cria uma nova instância dessa classe.
        {
            Titulo = titulo; //Atribui o valor passado para o parâmetro "titulo" ao atributo "Titulo" da classe.
            Autor = autor; 
            Ano = ano; 
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Ano:{Ano}");
        }
    }
}
