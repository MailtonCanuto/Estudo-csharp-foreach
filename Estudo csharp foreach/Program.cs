// comando basico foreach, percorre todos os elementos de um array

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string car in cars)
{
    Console.WriteLine(car);
}
Console.WriteLine();

int[] numbers = { 1, 2, 3, 4, 5 };
int soma = 0;
foreach (int number in numbers)
{
    
    Console.Write($"Numero a ser somado = {soma } + {number} = ");
    soma += number;
    Console.WriteLine(soma);
}