// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = ReadInt("b1 ");
double k1 = ReadInt("k1 ");
double b2 = ReadInt("b2 ");
double k2 = ReadInt("k2 ");

Cross( b1,  k1,  b2,  k2);

double ReadInt (string argument)
{
    System.Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}
void Cross(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    x = (b1 - b2) / (-k1 + k2);
    y = k2 * x + b2;
    Console.Write($"Cross coordinate M({x}, {y}) ");
}