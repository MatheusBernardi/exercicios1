Console.Write("Digite o ano de nascimento: ");
int anoNascimento = Convert.ToInt32(Console.ReadLine());

int anoAtual = 2026;
int idade = anoAtual - anoNascimento;

if (idade >= 18)
{
    Console.WriteLine("Você já pode tirar a CNH");
}
else
{
    Console.WriteLine("Você ainda precisa esperar para tirar a CNH");
}
