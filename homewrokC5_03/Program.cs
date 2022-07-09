// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] GenerateArray(int lenght, int min, int max) 
{
    int[] newArray = new int[lenght];
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
        System.Console.Write($"{array[i]} ");
    }
}
int diff (int[] array)
{
    int max = array[0];
    int min = array[1];
    int differ = 0;
    for (int i= 0; i < array.Length; i++)
    {
    if  (max < array[i])
    {
        max = array [i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
    differ = max - min;
    }
    System.Console.WriteLine($"максимальный элемент: {max}");
    System.Console.WriteLine($"минимальный элемент: {min}");
    System.Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {differ}");
    return differ;
}
int[] array = GenerateArray(5, 1, 99);
PrintArray(array);
System.Console.WriteLine();
diff(array);

