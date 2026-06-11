Console.Write("Digite o primeiro número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("O primeiro número é maior");
}
else if (numero2 > numero1)
{
    Console.WriteLine("O segundo número é maior");
}
else
{
    Console.WriteLine("Os números são iguais");
}