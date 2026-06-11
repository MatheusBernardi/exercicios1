Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

int contador = 1;

while (contador <= 10)
{
    Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
    contador = contador + 1;
}
