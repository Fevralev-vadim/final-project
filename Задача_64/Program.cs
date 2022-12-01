// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
String NaturalNumbers(int N)
{
    if (N == 1) return N.ToString();
    return $"{N}, {NaturalNumbers(N - 1)}";
}


int[] data = new int[] { 5, 8 };
foreach (int item in data)
{
    Console.WriteLine($"N = {item,2} ->  \"{NaturalNumbers(item)}\"");
}