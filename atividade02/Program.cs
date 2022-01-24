using System;
using System.Collections.Generic;

namespace atividade02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Produto tv = new Produto();
            Produto celular = new Produto();
            Produto misteira = new Produto();

            tv.Preco = 2000;
            celular.Preco = 3000;
            misteira.Preco = 500;

            tv.Nome = "Televisão";
            celular.Nome = "Celular";
            misteira.Nome = "misteira";

            Console.WriteLine("Bem vindo a nossa loja! Hoje temos disponiveis os seguintes produtos: Televisão, Celular e Misteira.");
            Console.WriteLine("Por favor informe a quantidade de Televisões que deseja: ");
            tv.Quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor informe a quantidade de Celulares que deseja: ");
            celular.Quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor informe a quantidade de Misteira que deseja: ");
            misteira.Quantidade = Convert.ToInt32((Console.ReadLine()));


            tv.ValorSemDesconto = tv.ValorTotal();
            celular.ValorSemDesconto = celular.ValorTotal();
            misteira.ValorSemDesconto = misteira.ValorTotal();

            tv.ValorFinalCompra = tv.Desconto(tv.ValorSemDesconto);
            celular.ValorFinalCompra = celular.Desconto(celular.ValorSemDesconto);
            misteira.ValorFinalCompra = misteira.Desconto(misteira.ValorSemDesconto);

            List<Produto> carrinhoDeCompra = new List<Produto>();

            carrinhoDeCompra.Add(tv);
            carrinhoDeCompra.Add(celular);
            carrinhoDeCompra.Add(misteira);

            double valorTotalCarrinho = 0;
            double valorTotalCarrinhoDesconto =0;

            foreach (var item in carrinhoDeCompra)
            {
                valorTotalCarrinhoDesconto = valorTotalCarrinhoDesconto + item.ValorFinalCompra;
                valorTotalCarrinho = valorTotalCarrinho + item.ValorSemDesconto;
            }

            Console.WriteLine("Caso pagamento seja a vista, o valor da sua compra será de: " + valorTotalCarrinhoDesconto);
            Console.WriteLine("Caso pagamento seja a prazo, o valor da sua compra será de: " + valorTotalCarrinho);
            Console.WriteLine("Entregaremos a sua compra hoje mesmo no local informado. Obragado pela preferência!");
                                   
        }
    }
}
