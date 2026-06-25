
// Problemática
public class GerenciadorTarefas
{
    public String conectarAPI()
    {
        // ...
    }

    public void CriarTarefa()
    {
        // ...     
    }

    public void EditarTarefa()
    {
        // ...
    }

    public void ExcluirTarefa()
    {
        // ...
    }

    public void GerarRelatorio()
    {
        // ...
    }

    public void EnviarRelatorio()
    {
        // ...
    }
}

// funções como conectar conectarAPI(), EnviarRelatorio() e GerarRelatorio() não são de responsabilidade da classe "GerenciadorTarefas"

// Solução
// Separar as responsabilidades
public class GerenciadorTarefas
{
    public void CriarTarefa()
    {
        // ...     
    }

    public void EditarTarefa()
    {
        // ...
    }

    public void ExcluirTarefa()
    {
        // ...
    }    
}

public class Relatorio()
{
    public void GerarRelatorio()
    {
        // ...
    }

    public void EnviarRelatorio()
    {
        // ...
    }
}
