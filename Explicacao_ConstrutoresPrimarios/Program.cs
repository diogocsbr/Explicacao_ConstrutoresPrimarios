using Explicacao_ConstrutoresPrimarios;

PessoaComConstrutorPrimario pessoa = new("João", 30);
Console.WriteLine(pessoa.Nome);

PessoaSemConstrutorPrimario pessoa2 = new("João", 30);
Console.WriteLine(pessoa2.Nome);