using ProvaPOO3;

public class Operador: Funcionario
{
	public int ID {get;set;}
	
	public Operador(string nome, int id) : base (nome)
	{
		ID = id;
	}
	
}