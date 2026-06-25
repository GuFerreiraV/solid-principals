> Classes derivadas (filhas) devem ser capazes de substituir suas classes-base (mãe)

Definição dita por Robert Martin, que aponta as classes-filhas como capazes de executar tudo que sua classe-mãe faz. Esse princípio se conecta com o polimorfismo e reforça esse pilar da POO.

Com isso, aprendemos que se a classe-filha apresentar um comportamento diferente do que foi definido na class-mãe, algo está errado. Trazendo este princípio para o código, temos uma modelagem mais fiel à realidade, reduzindo erros inesperados no programa e simplificando a manutenção do código.

#### Exemplo
```java
public class Estudante {
    String nome;
    public Estudante(String nome) {
        this.nome = nome;
    }
    public void estudar() {
        System.out.println(nome + " está estudando.");
    }
}

public class EstudanteDePosGraduacao extends Estudante {
    @Override
    public void estudar() {
        System.out.println(nome + " está estudando e pesquisando.");
    }
}
```
Se quisermos adicionar uma função ``entregarTCC()`` ao sistema acima, na classe ``Estudante``, não faria sentido, já que **Estudantes de Pós Graduação** não entregam o TCC, porém por ser uma classe derivada, ela precisar herdar todos os comportamentos da classe base.

#### Solução
```java
public class Estudante {
    String nome;
    public Estudante(String nome) {
        this.nome = nome;
    }
    public void estudar() {
        System.out.println(nome + " está estudando.");
    }

    public void entregarTCC() {
        System.out.println(nome + " entregou o tcc.");
    }
}

public class EstudanteDeGraduacao extends Estudante { 
    @Override
    public void entregarTCC() {
        System.out.println(nome + " entregou o tcc.");
    }
}

public class EstudanteDePosGraduacao extends Estudante {
    @Override
    public void estudar() {
        System.out.println(nome + " está estudando e pesquisando.");
    }
}
```