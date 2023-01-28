// программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("введите любое целое число");
int number = int.Parse(Console.ReadLine()!);
int result = 0; 
int res = 0;
void Sum(int result)
{
    if (number < 0) Console.WriteLine("Введите положительное число");
    else
    {
     while (number > 0)
        {
        res = number % 10;
        number = number / 10;
        result = result + res;
        }
    Console.WriteLine($"сумма цифр = {result}");
    }
}
Sum(result);
// готово.