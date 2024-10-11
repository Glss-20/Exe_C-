namespace ExContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco meuBanco = new Banco();

            int cont = 0;
            Console.Write("Quantas contas adicionar: ");
            int quant = int.Parse(Console.ReadLine());
            
            while(cont < quant)
            {
                Console.Write("Numero da conta: ");
                int nconta = int.Parse(Console.ReadLine());

                Console.Write("Titular da conta: ");
                string nome = Console.ReadLine();

                Console.Write("Saldo da conta: ");
                double sal = double.Parse(Console.ReadLine());
                
                Conta novaConta = new Conta(nconta, nome, sal);
                meuBanco.AdicionarConta(novaConta);
                Console.WriteLine($"Conta numero {nconta} adicionada com sucesso!");                   
                
                cont++;
            }
            //---------------------------------------------------------------------------------------------------------------------------
            // Criar um sistema para que eu escolha uma conta e escolha uma função para realizar com ela.
            // ---------------------------------------------------------------------------------------------------------------------------

        }
    }
}
