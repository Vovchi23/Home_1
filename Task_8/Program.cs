Console.Write("Введите целоче число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);
int sum = 0;

if (number > 0)
{
    Console.Write($"Четные числа от 1 до {number} ---> ");
    while (sum <= number - 2)
    {
        sum += 2;
        Console.Write($"{sum} ");
    }
}
else if (number == 0)
{
    Console.WriteLine ($"Вы ввели {number}! Ноль не натуральное число!");
}
else if (number < 0)
{
    Console.WriteLine ($"Вы ввели {number}! Отрицательное число не является натуральным числом!");
}
Console.WriteLine($"Количество четных чисел = {sum/2}");
