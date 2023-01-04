// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int length = ReadInt("Array length");
int[] array = GetArray(length, -100, 100);

PrintArray(array);
System.Console.WriteLine();
Search (array);


int ReadInt (string argument)
{
    System.Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input number {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
   
    return array;
}

void PrintArray (int[] array)
{
    for (int i= 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

void Search (int[] array)
{
    int N = 0;
    for (int i= 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            N += 1;
        }        
    }System.Console.WriteLine($"number of positive = {N} ");
}