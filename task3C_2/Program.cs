// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int N = ReadInt("Введите число:");
for (int i = 1; i < N+1; i++)
{
   System.Console.WriteLine( i*i*i);
}
