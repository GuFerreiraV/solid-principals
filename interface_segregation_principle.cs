public interface IEmployee
{
    decimal CalcularSalario();
}

public interface ICommissionable
{
    decimal GerarComissao();
}

public class Seller : IEmployee, ICommissionable 
{
    public decimal CalcularSalario() { return 2000.00m; }
    public decimal GerarComissao() { return 500.00m; }
}

public class Receptionist : IEmployee
{
    public decimal CalcularSalario() { return 1800.00m; }
}