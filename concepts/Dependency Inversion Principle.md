> Dependa de abstrações e não de implementaçãoes concretas.

Como é dito na mensagem acima, é recomendado que os **módulos de alto nível** não dependam diretamente dos detalhes de implementação de **módulos de baixo nível**.
Em vez disso, eles devem depender de abstrações ou interfaces que definem contratos de funcionamento. Isso promove maior flexibilidade e facilita a manutenção do sistema.
A adesão deste princípio promove a flexibilidade e a extensibilidade dos sistemas.

#### Exemplo
```java
public class PedidoService {
    private PedidoRepository repository;
    
    public PedidoService() {
        this.repository = new PedidoRepository();
    }
    
    public void processarPedido(Pedido pedido) {
        // Lógica de processamento do pedido
        repository.salvarPedido(pedido);
    }
}
```
Se no futuro, quisessemos alterar o modo de armazenamento dos pedidos, teríamos problemas porquê a classe ``PedidoService`` está acoplada à implementação concreta da classe ``PedidoRespository()``.

#### Solução
Criar uma interface para a classe de acesso ao banco e injetá-la em ``PedidoService``:
```java
public interface PedidoRepository {
    public void salvarPedido(Pedido pedido);    
}

public class PedidoService { 
    private PedidoRepository repository;
    
    public PedidoService(PedidoRepository repository) { 
        this.repository = repository;
    }

    public void processarPedido(Pedido pedido){
        repository.salvarPedido(pedido);
    }
}
```