Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);

int result = number % 2;

if (result == 0)
{
    Console.WriteLine($"Число {number} делится на два без остатка");
}
else
{
    Console.WriteLine($"Число {number} не делится на два без остатка");
}
