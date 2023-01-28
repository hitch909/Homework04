// функцию, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("введите число A= ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число B= ");
int B = int.Parse(Console.ReadLine()!);

void Exponentiation (int A, int B)
{
int result = 1;
for (int i = 1; i <= B; i++) result = result * A;
Console.WriteLine($"введенное число {A} возведенное в степень {B} = {result}");
}
Exponentiation(A,B);
