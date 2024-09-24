
Console.WriteLine("Calculator, airchiet pirveli ricxvi ");
double number1 = double.Parse(Console.ReadLine());

Console.WriteLine("airchiet simbolo: (+, -, *, /) ");
String symbol = Console.ReadLine();

if (symbol != "+" && symbol != "-" && symbol != "*" && symbol != "/")
{
    Console.WriteLine("Wrong Command");
    return; 
}

Console.WriteLine("airchiet meore ricxvi");
double number2 = double.Parse(Console.ReadLine());




if (symbol == "+")
{
    Console.WriteLine($"{number1 + number2}");
}
else if (symbol == "-")
{
    Console.WriteLine($"{number1 - number2}");
}
else if (symbol == "*")
{
    Console.WriteLine($"{number1 * number2}");
}
else if (symbol == "/")
{
    Console.WriteLine($"{number1 / number2}");
}

else
{
    Console.WriteLine("Wrong Command");
}


Console.ReadLine();