public class DescontoPorCategoriaStrategy : IDescontoStrategy
{
    private string categoria;
    private decimal percentual;

    public DescontoPorCategoriaStrategy(string categoria, decimal percentual)
    {
        this.categoria = categoria;
        this.percentual = percentual;
    }

    public decimal CalcularDesconto(Pedido pedido)
    {
        return pedido.Itens
                     .Where(i => i.Produto.Categoria == categoria)
                     .Sum(i => i.Subtotal * percentual);
    }
}
