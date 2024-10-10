using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_youtube
{
    public class Alunos
    {
        string nome;
        int idade;
        List<double> notas = new List<double>();

        public void Executar()
        {
            dados();
            Console.WriteLine($"A média do aluno(a) {nome}, com idade de {idade} anos é de {media()}");
            Console.ReadLine();
        }

        public void dados()
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Quantas notas inserir: ");
            int quant = int.Parse(Console.ReadLine());

            int cont = 0;
            while (cont < quant)
            {
                Console.Write($"Nota {cont + 1}: ");
                double nota = double.Parse(Console.ReadLine());
                notas.Add(nota);
                cont++;
            }

        }

        public double media()
        {
            int tamanho = notas.Count;
            if (tamanho == 0) // Verifica se a lista está vazia
            {
                Console.WriteLine("Nenhuma nota foi inserida.");
                return 0; // Se estiver invés da função retornar a "media" ela retorna 0 
            }

            double soma = 0;
            int cont = 0;

            while (cont < tamanho)
            {
                soma += notas[cont];
                cont++;
            }

            double media = soma / tamanho;
            return media;
        }

    }
}

