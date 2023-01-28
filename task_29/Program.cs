// Задача 29: Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int N = new Random().Next(3, 20);
int[] array = new int[N];
FillArray(array);
void FillArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 9);
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b ");
    Console.WriteLine("]");
}
