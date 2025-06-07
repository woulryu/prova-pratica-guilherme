public class Pedido
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public List<ItemPedido> Itens { get; private set; }
    public DateTime Data { get; set; }

    public Pedido(int id, Cliente cliente)
    {
        Id = id;
        Cliente = cliente;
        Data = DateTime.Now;
        Itens = new List<ItemPedido>();
    }

    public void AdicionarItem(Produto produto, int qtd)
    {
        Itens.Add(new ItemPedido { Produto = produto, Quantidade = qtd });
    }

    public decimal ValorTotal => Itens.Sum(i => i.Subtotal);
}
