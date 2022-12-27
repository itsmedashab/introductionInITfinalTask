//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 

Console.Write($"Введите массив из строк, отделяя эл-ты через пробел: ");

string[] array1 = Console.ReadLine()!.Split(' ');
string[] array2 = new string[array1.Length];

CreateSecondArray(array1, array2);
Console.Write($"Новый массив из строк c длиной <= 3 символа: ");
PrintArray(array2);


//---------------------------------
void CreateSecondArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if (arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}

//---------------------------------
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write($"\n");
}