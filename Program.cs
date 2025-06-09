using System;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            // Produtos
            var notebook = new Produto(1, "Notebook", 3500.00m, "Eletrônicos");
            var mouse = new Produto(2, "Mouse", 50.00m, "Acessórios");
            var monitor = new Produto(3, "Monitor", 800.00m, "Eletrônicos");

            // Clientes
            var cliente1 = new Cliente(1, "João Silva", "joao@email.com", "12345678900");
            var cliente2 = new Cliente(2, "Maria Oliveira", "maria@email.com", "23456789001");
            var cliente3 = new Cliente(3, "Carlos Souza", "carlos@email.com", "34567890123");

            // Pedidos
            var pedido1 = new Pedido(1, cliente1);
            pedido1.AdicionarItem(notebook, 1);
            pedido1.AdicionarItem(mouse, 2);

            var pedido2 = new Pedido(2, cliente2);
            pedido2.AdicionarItem(monitor, 1);

            var pedido3 = new Pedido(3, cliente3);
            pedido3.AdicionarItem(mouse, 3);

            // Estratégias de desconto
            var descontoCategoria = new DescontoPorCategoriaStrategy("Eletrônicos", 0.10m);
            var descontoQuantidade = new DescontoPorQuantidadeStrategy(3, 0.05m);

            // Lista de pedidos
            var pedidos = new List<Pedido> { pedido1, pedido2, pedido3 };

            foreach (var pedido in pedidos)
            {
                var desconto = descontoCategoria.CalcularDesconto(pedido)
                             + descontoQuantidade.CalcularDesconto(pedido);

                Console.WriteLine($"\nPedido #{pedido.Id} - Cliente: {pedido.Cliente.Nome}");
                foreach (var item in pedido.Itens)
                    Console.WriteLine($"- {item.Produto.Nome} x{item.Quantidade} = R${item.Subtotal:F2}");

                Console.WriteLine($"Subtotal: R${pedido.ValorTotal:F2}");
                Console.WriteLine($"Desconto: R${desconto:F2}");
                Console.WriteLine($"Total: R${pedido.ValorTotal - desconto:F2}");
            }
        }
    }
}
