 //Задание: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам
 
 
string[] array1 = new string[5] { "final", ")ut", "task", "%'", "7" };
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
Console.WriteLine("Массив из строк, длина которых <=3 символов: \n");
PrintArray(array2);
            
            
