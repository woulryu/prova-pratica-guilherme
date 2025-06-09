public class DescontoPorQuantidadeStrategy : IDescontoStrategy
{
    private int minimoItens;
    private decimal percentual;

    public DescontoPorQuantidadeStrategy(int minimoItens, decimal percentual)
    {
        this.minimoItens = minimoItens;
        this.percentual = percentual;
    }

    public decimal CalcularDesconto(Pedido pedido)
    {
        int totalItens = pedido.Itens.Sum(i => i.Quantidade);
        return totalItens >= minimoItens ? pedido.ValorTotal * percentual : 0;
    }
}
