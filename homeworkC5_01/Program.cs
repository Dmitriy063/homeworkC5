// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GenerateArray(int leght, int min, int max)
{
    int[] newArray = new int[leght];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

void even(int[] array)
{
    int tmp = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            tmp = tmp + 1;
        }
        }
        System.Console.WriteLine($"Количество четных в массиве {tmp} ");
        return;
}

int[] array = GenerateArray(10, 100, 999);
PrintArray(array);
even(array);
