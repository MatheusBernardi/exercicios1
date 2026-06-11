Console.Write("Digite a primeira nota: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
double n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quarta nota: ");
double n4 = Convert.ToDouble(Console.ReadLine());

double media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine("Média: " + media);

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}
