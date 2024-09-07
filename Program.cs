namespace ProvaPOO3;

class Program
{
	static void Main(string[] args)
	{
		Gerente gerente = new Gerente("Carlos", 42988372637);
		
		gerente.calcularSalario(1300, 2000);
		gerente.RegistrarPonto();
		
		
		Operador operador = new Operador("João", 1);
		operador.calcularSalario(1700, 1500);
		operador.RegistrarPonto();
		
	}
}
