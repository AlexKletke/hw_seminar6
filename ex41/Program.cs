//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
using System.Linq;

Console.WriteLine("enter any numbers separated by a space: ");
string message = Console.ReadLine();
var massive = message.Split(" ")
                .ToArray();
/*for(int i = 0; i < massive.Length; i++)
{
    Console.WriteLine(massive[i]);
}*/
int[] array = new int[massive.Length];

for(int i = 0; i < massive.Length; i++)
{
    array[i] = Convert.ToInt32(massive[i]);
}
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.Write($"you have entered positive numbers = {count}");



