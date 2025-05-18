// Um cliente quer solicitar um empréstimo. Receba o valor solicitado, a quantidade de parcelas desejada e a renda mensal comprovada. Só autorize empréstimos cuja parcela não ultrapasse 30% da renda (desconsidere os juros).

double emprestimo, qtdParcelas, parcelas, renda, porcentagemRenda;

Console.WriteLine("Bem vindo a analise de Creditos ");

Console.Write("Qual a sua Renda Mensal: ");
renda = Convert.ToDouble(Console.ReadLine());
Console.Write("Quanto você gostaria de receber de emprestimo: ");
emprestimo = Convert.ToDouble(Console.ReadLine());
Console.Write("Quantidade de Parcelas que você ira pegar: ");
qtdParcelas = Convert.ToDouble(Console.ReadLine());

parcelas = emprestimo / qtdParcelas;
porcentagemRenda = renda / 0.3;

if (parcelas <= porcentagemRenda )
{
    Console.WriteLine("Parabens seu emprestimo foi aprovado");
}
else
{
    Console.WriteLine("infelizmente Seu emprestimo não foi aprovado");
}

