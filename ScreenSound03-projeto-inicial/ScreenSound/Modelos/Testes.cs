internal class Colaborador
{
    public Colaborador(string nome, double salario, int anosEmpresa, double descontos = 0)
    {
        Nome = nome;
        Salario = salario;
        AnosEmpresa = anosEmpresa;
        Descontos = descontos;
    }

    public string Nome { get; }
    public double Salario { get; }
    public int AnosEmpresa { get; }
    public double Descontos { get; }
    public double Anuenio => 1 + (AnosEmpresa * 0.01);
}

internal class DepartamentoPessoal
{
    public static void ExibeFolha(List<Colaborador> colaboradores)
    {
        foreach (Colaborador c in colaboradores)
        {
            var salarioDoMes = (c.Salario * c.Anuenio) - c.Descontos;
            Console.WriteLine($"- {c.Nome}: R$ {salarioDoMes}");
        }
    }
}