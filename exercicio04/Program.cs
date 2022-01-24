using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto tv = new Produto();

            tv.Preco = 2000;
            
            tv.Nome = "Televisão";

            Console.WriteLine("Fui informado que desseja comprar Televisões, o valor unitário é " +tv.Preco+ ".  Quantas unidades seriam?");
            tv.Quantidade = Convert.ToInt32(Console.ReadLine());

            tv.ValorSemDesconto = tv.ValorTotal();
            tv.ValorFinalCompra = tv.Desconto(tv.ValorSemDesconto);



            Console.WriteLine("Trabalhamos com pagamento a vista e a prazo. A prazo sua compra fica: " +tv.ValorSemDesconto);
            Console.WriteLine("Caso prefira pagamento a vista, damos um desconto de 15%, ficando em: " +tv.ValorFinalCompra);
            Console.WriteLine("Entregaremos a sua compra hoje mesmo no local informado. Obragado pela preferência!");
        }
    }
}
