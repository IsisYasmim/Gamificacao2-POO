using Gamificacao2.Enums;
using Gamificacao2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao2.Services
{
    class Menu
    {
        public Loja loja;

        public Menu(Loja loja)
        {
            this.loja = loja;
        }

        public void IniciarMenu()
        {
            // Implemente a lógica do menu aqui

            int opcao;
            do
            {
                //menu do usuário
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar camiseta ao carrinho de compras");
                Console.WriteLine("2 - Adicionar calça ao carrinho de compras");
                Console.WriteLine("3 - Adicionar bolsa ao carrinho de compras");
                Console.WriteLine("4 - Adicionar sapato ao carrinho de compras");
                Console.WriteLine("5 - Adicionar promoções");
                Console.WriteLine("6 - Finalizar compra");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Escolha uma camiseta pelo número: ");
                        List<Produto> camisetas = loja.Produtos.Where(p => p is Camiseta).ToList();
                        for (int i = 0; i < camisetas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {camisetas[i].Descricao()}");
                        }
                        int opcaoCamisa = int.Parse(Console.ReadLine());
                        if (opcaoCamisa >= 1 && opcaoCamisa <= camisetas.Count)
                        {
                            loja.Carrinho.AdicionarProduto(camisetas[opcaoCamisa - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Escolha uma calça pelo número: ");
                        List<Produto> calcas = loja.Produtos.Where(p => p is Calca).ToList();
                        for (int i = 0; i < calcas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {calcas[i].Descricao()}");
                        }
                        int opcaoCalca = int.Parse(Console.ReadLine());
                        if (opcaoCalca >= 1 && opcaoCalca <= calcas.Count)
                        {
                            loja.Carrinho.AdicionarProduto(calcas[opcaoCalca - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        break;


                    case 3:
                        Console.WriteLine("Escolha uma bolsa pelo número: ");
                        List<Produto> bolsas = loja.Produtos.Where(p => p is Bolsa).ToList();
                        for (int i = 0; i < bolsas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {bolsas[i].Descricao()}");
                        }
                        int opcaoBolsa = int.Parse(Console.ReadLine());
                        if (opcaoBolsa >= 1 && opcaoBolsa <= bolsas.Count)
                        {
                            loja.Carrinho.AdicionarProduto(bolsas[opcaoBolsa - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Escolha um sapato pelo número: ");
                        List<Produto> sapatos = loja.Produtos.Where(p => p is Sapato).ToList();
                        for (int i = 0; i < sapatos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {sapatos[i].Descricao()}");
                        }
                        int opcaoSapato = int.Parse(Console.ReadLine());
                        if (opcaoSapato >= 1 && opcaoSapato <= sapatos.Count)
                        {
                            loja.Carrinho.AdicionarProduto(sapatos[opcaoSapato - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        break;


                    case 5:
                        int opcaoPromocao;
                        do
                        {
                            Console.WriteLine("Escolha uma opção:");
                            for (int i = 0; i < loja.Promocoes.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} - Adicionar promoção {loja.Promocoes[i].TipoDesconto} com desconto de {loja.Promocoes[i].ValorDesconto}");
                            }
                            Console.WriteLine("0 - Sair");
                            opcaoPromocao = int.Parse(Console.ReadLine());
                            if (opcaoPromocao >= 1 && opcaoPromocao <= loja.Promocoes.Count)
                            {
                                loja.Carrinho.AdicionarPromocao(loja.Promocoes[opcaoPromocao - 1]);
                            }
                            else if (opcaoPromocao != 0)
                            {
                                Console.WriteLine("Opção inválida!");
                            }

                            Console.WriteLine("\nPressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        } while (opcaoPromocao != 0);

                        break;


                    case 6:
                        Console.WriteLine("Valor total com descontos: " + loja.Carrinho.CalcularValorTotal());
                        Console.WriteLine("Insira o nome do cliente: ");
                        string cliente = Console.ReadLine();
                        Console.WriteLine("Insira o endereço do cliente: ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Insira o método de pagamento do cliente: ");
                        string metodo = Console.ReadLine();
                        Pagamento pagamento = new Pagamento(loja.Carrinho, cliente, endereco, metodo);
                        Console.WriteLine(pagamento.GerarNotaFiscal());
                        break;


                    case 0:
                        Console.WriteLine("Saindo...");
                        break;


                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcao != 0);

        }
    }
}
