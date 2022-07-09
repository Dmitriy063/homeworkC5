// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
int oddsum (int [] array)
{
   int sum = 0;
   for (int i= 0; i < array.Length; i +=2)
   {
    sum = array[i] +sum;
   }
   return sum;
}
int[] array = GenerateArray(5, 1, 10);
PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine($"Сумма нечетных элементов в массиве равна {oddsum(array)}");