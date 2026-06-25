using System;

// Interfaces específicas
public interface ITrabalhoConclusao
{
    void entregarTCC();
}

public interface IPesquisa
{
    void apresentarPesquisa();
}

// Classe Base
public abstract class Student
{
    protected string Name { get; set; } 

    public Student(string name)
    {
        Name = name;
    }

    public void estudar()
    {
        Console.WriteLine($"{Name} está estudando.");
    }
}

// Classes Filhas que herdam a base
public class Graduation : Student, ITrabalhoConclusao
{
    public Graduation(string name) : base(name) { }

    public void entregarTCC()
    {
        Console.WriteLine($"{Name} entregará o TCC.");
    }
}

public class Postgraduate : Student, IPesquisa
{
    public Postgraduate(string name) : base(name) { }

    public void apresentarPesquisa()
    {
        Console.WriteLine($"{Name} apresentará sua pesquisa.");
    }
}