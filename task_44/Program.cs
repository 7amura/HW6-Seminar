// Задача 44: 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Enter the number: ");
int num = int.Parse(Console.ReadLine()!);
int[] listFib = new int[num];
// string listFib = String.Empty;
listFib[0] = 0; Console.Write(listFib[0]);
listFib[1] = 1; Console.Write(listFib[1]);

for ( int i = 2; i < listFib.Length; i++)
{
    listFib[i] = listFib[i - 1]+ listFib[i - 2];
    Console.Write(listFib[i]);
}


// Правило чисел Фибоначчи!!!
// if (num[i] == 0, num[i] == 1) return num[i]
// else return num[int -1] + num[int -2] 