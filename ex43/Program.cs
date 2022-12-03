// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1  и   y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
int GetIntFromConsole (string message)
{
    Write(message);
    return int.Parse(ReadLine());
}
WriteLine("there are 2 straight lines in the plane given by the equations");
WriteLine("y = k1 * x + b1  and  y = k2 * x + b2");
double k1 = GetIntFromConsole("enter k1: ");
double b1 = GetIntFromConsole("enter b1: ");
double k2 = GetIntFromConsole("enter k2 is not = k1: ");
double b2 = GetIntFromConsole("enter b2: ");
/*double IntersectionPoints(double x, double y)
{
    double x = 0;
    double y = 0;
    y = k1 * x + b1;
    x = (b2-b1) / (k1 - k2);
    return x;
    return y;
}
double x = IntersectionPoints(x);
double y = IntersectionPoints(y);*/
double x = (b2-b1) / (k1 - k2);
double y = k1 * x + b1;
WriteLine($"coordinates of the intersection point of 2 lines in space: ({x}; {y})");
