// Задача 1.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


int ReadINt(string message)
{
    Console.WriteLine(message);                         
    int number = Convert.ToInt32(Console.ReadLine());    
    return number;  
}

bool Validate5sign(int number)
{
    if (number < 9999 || number > 1000000)
    {
        System.Console.WriteLine("Вы ввели не пятизначное число");
        return false;
    }
    else
    {
        return true;
    } 
}

int num = ReadINt("Введите пятизначное число"); int num1 = 0;

if (Validate5sign(num))
{
num1 = num%10*10000 + (num/10)%10*1000+ (num/100)%10*100+ (num/1000)%10*10 + (num/10000)%10;
System.Console.WriteLine(num1);

if(num == num1)
{
    System.Console.WriteLine($"Число {num} палиндром!");
}
else
{
    System.Console.WriteLine($"Число {num} не палиндром!");
}
}








