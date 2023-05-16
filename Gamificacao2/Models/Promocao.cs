using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2.Models
{
    public class Promocao
    {
        public string TipoDesconto { get; private set; }
        public double ValorDesconto { get; private set; }

        public Promocao(string tipoDesconto, double valorDesconto)
        {
            TipoDesconto = tipoDesconto;
            ValorDesconto = valorDesconto;
        }

        public double CalcularDesconto(double preco)
        {
            if (TipoDesconto == "porcentagem")
            {
                return preco * (ValorDesconto / 100);
            }
            else if (TipoDesconto == "valor_fixo")
            {
                return ValorDesconto;
            }
            else
            {
                throw new ArgumentException("Tipo de desconto inválido");
            }
        }
    }
}

