Quando uma classe é aberta para modificações, quanto mais implementações feitas, maior será sua complexidade, o princípio aberto-fechado veio para abstrairmos certas informações e deixar o código menos complexo e flexível.

#### Exemplo:

```java
public class AprovaExame {
    public void aprovarSolicitacaoExame(Exame exame){
        if(exame.tipo == SANGUE){
            if(verificaCondicoesExameSangue(exame))
                System.out.println("Exame sanguíneo aprovado!");
        }
    }
    private boolean verificaCondicoesExameSangue(){
        //....
    }
}
```

#### Problemática

Dentro do método `aprovarSolicitacaoExame()` , se quisermos adicionar mais um tipo de exame, adicionaríamos mias um `if`

 

```java
else if(exame.tipo == RAIOX) {
   if (verificaCondicoesRaioX(exame))
       System.out.println("Raio X aprovado!");
}

private boolean verificaCondicoesRaioX(){
  //....
}
```

Com isso, pensando num cenário aonde tenhamos mais tipos de exames, teríamos vários `else if` , isso deixaria o projeto mais complexo. Para evitar este problema, podemos construir uma `interface` genérica que contenha um método para informar o tipo de exame.

#### Solução

```java
public interface AprovaExame{
    void aprovarSolicitacaoExame(Exame exame);
    boolean verificaCondicoesExame(Exame exame);
}

public class AprovaExameSangue implements AprovaExame{
    @Override
    public void aprovarSolicitacaoExame(Exame exame){
            if(verificaCondicoesExame(exame))
                System.out.println("Exame sanguíneo aprovado!");
    }
    @Override
    boolean verificaCondicoesExame(Exame exame){
        //....
    }
}

public class AprovaRaioX implements AprovaExame{
    @Override
    public void aprovarSolicitacaoExame(Exame exame){
        if(verificaCondicoesExame(exame))
            System.out.println("Raio-X aprovado!");
    }
    @Override
    boolean verificaCondicoesExame(Exame exame){
        //....
    }
}
```