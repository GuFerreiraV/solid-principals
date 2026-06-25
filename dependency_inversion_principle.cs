public class PedidoService
{
    private readonly PedidoRepository _repository;

    public PedidoService() {
        _repository = new PedidoRepository();
    }

    public void ProcessarPedido(Pedido pedido)
    {
        _repository.SalvarPedido(pedido);
    }
}

// Código acima está preso à implementação da classe PedidoRepository(), 
// portanto para uma futura mudança de armazenamento dos pedidos, isso gerará um problema.

public interface IPedidoRepository
{
    void SalvarPedido(Pedido pedido);
}

public class PedidoService
{
    private readonly IPedidoRepository _repository;

    public PedidoService(IPedidoRepository repository) 
    {
        _repository = repository;
    }

    public void ProcessarPedido(Pedido pedido)
    {
        _repository.SalvarPedido(pedido);
    }
}

public class SqlPedidoRepository : IPedidoRepository
{
    public void SalvarPedido(Pedido pedido)
    {
        Console.WriteLine("Salvando pedido no banco SQL Server...");
    }
}

public class MongoPedidoRepository : IPedidoRepository
{
    public void SalvarPedido(Pedido pedido)
    {
        Console.WriteLine("Salvando pedido no MongoDB...");
    }
}