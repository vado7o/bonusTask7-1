// Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них.

Console.Clear();
Console.WriteLine("Программа, создающая массив из 10-ти случайных чисел и выводящая максимальное из них");

List<int> array = new List<int>();
Random rnd = new Random();
int max = -9;

Console.WriteLine("\nВ созданном массиве: ");
for(int index = 0; index < 10; index++) {
    int nextRnd = rnd.Next(-9, 10); 
    array.Add(nextRnd);
    if(nextRnd > max) max = nextRnd;
    if(index == 0) { 
        Console.Write("[" + array[index] + ", "); 
    } else if(index == 9) {
        Console.Write(array[index] + "]");
        } else Console.Write(array[index] + ", ");
}

Console.Write(" самое большое число - " + max + "!");