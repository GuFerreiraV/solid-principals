> Uma classe não deve ser forçada a implementar interfaces e métodos que não serão utilizados.

#### Exemplo 
```java
public interface Funcionario {
    public BigDecimal salario();
    public BigDecimal gerarComissao();
}

import java.math.BigDecimal;
public class Vendedor implements Funcionario {
    @Override
    public BigDecimal salario() {
    }
    @Override
    public BigDecimal gerarComissao() {
    }
}

import java.math.BigDecimal;
public class Recepcionista implements Funcionario{
    @Override
    public BigDecimal salario() {
    }
    @Override
    public BigDecimal gerarComissao() {
    }   
}
```
A classe recepcionista não deveria implementar a função ``gerarComissao()``.
Para resolver isso, vamos criar **interfaces específicas**.
```java
public interface Funcionario {
    public BigDecimal salario();    
}

public interface Comissionavel { 
    public BigDecimal gerarComissao();
}

import java.math.BigDecimal;
public class Vendedor implements Funcionario, Comissionavel {
    @Override
    public BigDecimal salario() {
    }
    @Override
    public BigDecimal gerarComissao() {
    }
}

import java.math.BigDecimal;
public class Recepcionista implements Funcionario{
    @Override
    public BigDecimal salario() {
    }    
}
```