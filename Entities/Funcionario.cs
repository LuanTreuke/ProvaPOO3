namespace ProvaPOO3;

public abstract class Funcionario
{
	public string Nome { get; set; }
	
	public Funcionario(string nome)
	{
		Nome = nome;
	}
	
	public abstract int calcularSalario(int a, int b)
	{
		int resultado = a + b;
		return resultado;
		Console.WriteLine($"A soma do salário do gerente é: {resultado}");
	}
	
	public abstract void RegistrarPonto()
	{
		Console.WriteLine("Ponto Registrado!");
	}
	
}