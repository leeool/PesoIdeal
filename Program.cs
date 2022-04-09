string id;
double altura;

Console.Write("Entre com seu sexo (F)/(M)..: ");
id = Console.ReadLine()!;

if (id == "M")
{
    Console.Write("Digite sua altura em (m)....: ");
    altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"\nSeu peso ideal é {altura * 72.7 - 58:N1}kg");
}

else if (id == "F")
{
    Console.Write("Digite sua altura em (m)....: ");
    altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"\nSeu peso ideal é {altura * 62.1 - 44.7:N1}kg");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nSEXO NÃO IDENTIFICADO.");
}

Console.ResetColor();