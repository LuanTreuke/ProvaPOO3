using ProvaPOO3;

public class Gerente : Funcionario
{
	public long Telefone {get;set;}
	
	public Gerente(string nome, long telefone) : base (nome)
	{
		Telefone = telefone;
	}
	
}