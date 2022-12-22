Console.Write("Введите ПЕРВОЕ целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

Console.Write("Введите ВТОРОЕ целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse(userInput2);

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} ---> Максимальное!!!");
}
else

    Console.WriteLine($"Число {number2} ---> Максимальное!!!");

