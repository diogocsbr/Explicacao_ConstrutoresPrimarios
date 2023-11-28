namespace Explicacao_ConstrutoresPrimarios;

public class PessoaSemConstrutorPrimario
{
    public string Nome { get; }
    public int Idade { get; }

    public PessoaSemConstrutorPrimario(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}