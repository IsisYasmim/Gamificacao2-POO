using Gamificacao2.Enums;
using Gamificacao2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2
{
    class Loja
    {
        public List<Produto> Produtos { get; set; }
        public List<Promocao> Promocoes { get; set; }
        public CarrinhoDeCompras Carrinho { get; set; }

        public Loja()
        {
            Produtos = new List<Produto>();
            Promocoes = new List<Promocao>();
            Carrinho = new CarrinhoDeCompras();
        }

        public void AdicionarProdutos()
        {

            // Adicionar produtos à lista

            Camiseta camiseta = new Camiseta("Camiseta Polo", 49.99, "M", "Azul");
            Camiseta camiseta2 = new Camiseta("Camiseta de Botão", 59.99, "GG", "Branco");
            Calca calca = new Calca("Calça Social", 120.89, "M", "Preto", "dsfas");
            Calca calca2 = new Calca("Calça Jeans", 78.98, "M", "Azul", "fasdfasdfa");
            Sapato sapato = new Sapato("Sapato Social", 99.99, "42", "Preto", "Social");
            Sapato sapato2 = new Sapato("Sapato de Salto", 150.99, "35", "Vermelho", "Social");
            Bolsa bolsa = new Bolsa("Bolsa de Couro", 149.99, "Grande", "Marrom", "Couro");
            Bolsa bolsa2 = new Bolsa("Bolsa de Lantejoula", 30, "Pequena", "Rosa", "Lantejoula");

            Produtos.Add(camiseta);
            Produtos.Add(camiseta2);
            Produtos.Add(calca);
            Produtos.Add(calca2);
            Produtos.Add(sapato);
            Produtos.Add(sapato2);
            Produtos.Add(bolsa);
            Produtos.Add(bolsa2);
        }

        public void AdicionarPromocoes()
        {

            // Adicionar promocoes à lista

            Promocao promocaoCamiseta = new Promocao("porcentagem", 10);
            Promocao promocaoSapato = new Promocao("valor_fixo", 20);
            Promocao promocaoBolsa = new Promocao("porcentagem", 15);
            Promocao promocaoCalca = new Promocao("porcentagem", 5);

            Promocoes.Add(promocaoCamiseta);
            Promocoes.Add(promocaoSapato);
            Promocoes.Add(promocaoBolsa);
            Promocoes.Add(promocaoCalca);
        }
    }

}
