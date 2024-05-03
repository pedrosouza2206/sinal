double numero;

Console.Write("Digite um número: ");
numero = Convert.ToDouble(Console.ReadLine());
 
if (numero < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você digitou um número negativo.");
    Console.ResetColor();
}
else if (numero > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você digitou um número positivo.");
    Console.ResetColor();
}

else
{
     Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Você digitou zero");
    Console.ResetColor();
}