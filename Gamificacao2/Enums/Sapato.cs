using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamificacao2.Models;

namespace Gamificacao2.Enums
{
    public class Sapato : Acessorio
    {
        private string _tipo;

        public Sapato(string nome, double preco, string tamanho, string cor, string tipo)
            : base(nome, preco, CategoriaProduto.Sapato, tamanho, cor)
        {
            _tipo = tipo;
        }

        public string GetTipo()
        {
            return _tipo;
        }

        public override string Descricao()
        {
            return GetNome() + " - R$" + GetPreco() + " - " + _tamanho + " - " + _cor + " - estilo " + GetTipo();
        }

    }
}
