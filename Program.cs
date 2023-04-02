/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int [] array;
int count = 0;
Console.WriteLine("Введите цифры через зяпятую/пробел/точку");
array = Console.ReadLine()!.Split(' ', ',', '.').Where(x=>int.TryParse(x, out _)).Select(x=>int.Parse(x)).ToArray();
for (int i = 0; i < array.Length; i++)
{if (array[i]>0){count++;}
    
}
Console.WriteLine($"В ввели {count} чисел/числа больше 0");