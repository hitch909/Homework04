// программа, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int n = 8;
int[] array = new int[n];
void PrintArray(int[] array)
{
    Console.Write($" {array[1]}");  // избавился от запятой
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, n);
        Console.Write($",{array[i]}");
    }
}
PrintArray(array);
