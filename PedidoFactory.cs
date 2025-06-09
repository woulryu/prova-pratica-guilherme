public class PedidoFactory
{
    private static int sequencial = 100;

    public Pedido GerarPedido(Cliente cliente)
    {
        return new Pedido(++sequencial, cliente);
    }
}
