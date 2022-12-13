// Напишите программу, которая найдет точку пересечения двух прямых, заданных
// уравнениями y = k1*x + b1, y = k2*x + b2. Значения задаются пользователем.


int Promt(string message)                     
{
    Console.Write(message + " ");                  
    return Convert.ToInt32(Console.ReadLine());     
}

void Tochka(double k1, double k2, double b1, double b2)
{
    double x = 1;
    double y = 1;
     x = (b2 - b1)/(k1 - k2);
     y = (b2*k1 - b1*k2)/(k1 - k2);
     Console.WriteLine($"Точка пересечения двух прямых равна ({x}, {y})");    
}

double k1 = Promt("Введите значение К1: ");
double k2 = Promt("Введите значение К2: ");
double b1 = Promt("Введите значение b1: ");
double b2 = Promt("Введите значение b2: ");
Tochka(k1, k2, b1, b2);