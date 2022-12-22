Console.Write("Введите ПЕРВОЕ целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

Console.Write("Введите ВТОРОЕ целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse(userInput2);

Console.Write("Введите ТРЕТЬЕ целое число: ");
int number3 = int.Parse(Console.ReadLine() ?? "");

int max = number1; //Пусть 1 номер будет максимальный! Далее поочередно проверяем кто из чисул больше)

if (number1 > max)
{
    max = number1;
}
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"Число {max} ---> Максимальное");
