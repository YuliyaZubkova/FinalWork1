/* Написать программу, которая из имеющегося массива строк формирует массив 
из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
алгоритма. При решение не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами
*/

string[] arrayOne = new string[5] { "Hello", "2", "World", ":-)", "res" };
Console.WriteLine("\r\n" + "Введен массив: ");
foreach (string i in arrayOne)
    Console.Write($"{i}, ");
string[] arrayTwo = new string[arrayOne.Length];

void ResultArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
ResultArray(arrayOne, arrayTwo);
Console.WriteLine("\r\n"+ "\r\n" + "Массив результат: ");
PrintArray(arrayTwo);
Console.WriteLine();

