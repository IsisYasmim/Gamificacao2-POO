﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamificacao2.Models;

namespace Gamificacao2.Enums
{
    public class Bolsa : Acessorio
    {
        private string _material;

        public Bolsa(string nome, double preco, string tamanho, string cor, string material)
            : base(nome, preco, CategoriaProduto.Bolsa, tamanho, cor)
        {
            _material = material;
        }

        public string GetMaterial()
        {
            return _material;
        }

        public override string Descricao()
        {
            return GetNome() + " - R$" + GetPreco() + " - " + _tamanho + " - " + _cor + " - estilo " + GetMaterial();
        }

    }
}
