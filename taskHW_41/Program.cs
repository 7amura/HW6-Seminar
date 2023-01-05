// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите элемнты M: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(' ', ','), int.Parse);

// int count = 0;
// void CountNum(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Кол-во элементов > 0: {count}");
// }
// CountNum(arr);



Console.WriteLine("Введите элемнты M: ");
string[] list = (Console.ReadLine()!).Split(' ', ',');

void SumPosNumbers(string[] listNums)
{
    int count = 0;
    Console.Write(" Введен след список чисел: ");
    foreach ( string el in listNums)
    {
        if(int.Parse(el) > 0) count ++;
        Console.Write($"{el}");
    }
    Console.WriteLine($"\n Кол-во чисел > 0 = {count}");
}
SumPosNumbers(list);

