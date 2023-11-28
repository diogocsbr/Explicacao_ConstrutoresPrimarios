namespace Explicacao_ConstrutoresPrimarios;

public class PessoaComConstrutorPrimario(string nome, int idade)
{
    public string Nome { get; } = nome;
    public int Idade { get; } = idade;
}