// Пользователь вводит с клавиатуры М чисел.
// Посчитайте сколько чисел больше 0 ввел пользователь.
// 0, 7, -3, 4 -> 2

int Promt(string message)                           
{
    Console.Write(message + " >");                  
    return Convert.ToInt32(Console.ReadLine());     
}

int[] CreateArray (int length)
{
    int[] numbers = new int [length];
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
    return numbers;
}

int PositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) {sum ++;}
    }
    return sum;
}

void PrintArray (int[] array)                  
{
     for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}      

int length = Promt("Ведите число: ");
int[] array = CreateArray(length);
PrintArray(array);
Console.WriteLine($"Количество введенных положительных чисел равно {PositiveSum(array)}");