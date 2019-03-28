using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TratamentoDeExcecoes.Model
{
    public class Numeros
    {
        public int GerarNumeroAleatorio()
        {
            int novoNumero;

            Random random = new Random();
            novoNumero = random.Next();

            throw new Exception("Ocorreu um erro ao gerar o número aleatório"); //Descomente para simular um erro

            return novoNumero;
        }
    }
}
