// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int x1 = ReadInt("Введите X1");
int y1 = ReadInt("Введите y1");
int z1 = ReadInt("Введите z1");

int x2 = ReadInt("Введите x2");
int y2 = ReadInt("Введите y2");
int z2 = ReadInt("Введите z2");

double DistX = x1 - x2;
double Disty = y1 - y2;
double Distz = z1 - z2;

double Dist = Math.Sqrt ((DistX * DistX + Disty * Disty + Distz * Distz));
System.Console.WriteLine($"Расстояние равно {Dist:f2}");
