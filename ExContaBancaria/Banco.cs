using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBancaria
{
    public class Banco
    {
        List<Conta> ListContas = new List<Conta>();

        public void AdicionarConta(Conta instConta)
        {
            ListContas.Add(instConta);  
        }

    }
}
