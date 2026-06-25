#### Single Responsibility Principle (Princípio da responsabilidade única)

De forma resumida, cada classe deve ter uma única responsabilidade, se a classe for `GerenciarEmail()` , suas únicas funções devem ser referentes ao cadastro de email.

#### Exemplo
```java
public class GerenciadorTarefas {
    public String conectarAPI(){
        //...
    }
    public void criarTarefa(){
        //...
    }
    public void atualizarTarefa(){
        //...
    }
    public void removerTarefa(){
        //...
    }
    public void enviarNotificacao(){
        //...
    }
    public void produzirRelatorio(){
        //...
    }
    public void enviarRelatorio(){
        //...
    }
}
```

#### Problemática

A classe `GerenciadorTarefas` possui funções, como `conectarAPI()` e `produzirRelatorio()` , que não deveriam ser de sua responsabilidade.

#### Resolução

```java
public class GerenciadorTarefas {
    
    public void criarTarefa(){
        //...
    }
    public void atualizarTarefa(){
        //...
    }
    public void removerTarefa(){
        //...
    }
}
```