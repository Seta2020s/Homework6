// Напишите программу,которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2, и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =9 -> (-0,5; -0,5) 

double[] ReadDoubleArrayFromInput(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();
    string[] numbersString = input.Split(' ');
    double[] array = Array.ConvertAll(numbersString, double.Parse);
    return array;
}

double[] FindIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return new double[] { x, y };
}

void PrintPoint(double[] point)
{
    Console.WriteLine($"Точка пересечения: ({point[0]}, {point[1]})");
}

double[] kAndB1 = ReadDoubleArrayFromInput("Введите значение k1 и b1 через пробел: ");
double[] kAndB2 = ReadDoubleArrayFromInput("Введите значение k2 и b2 через пробел: ");

double[] intersectionPoint = FindIntersectionPoint(kAndB1[0], kAndB1[1], kAndB2[0], kAndB2[1]);
PrintPoint(intersectionPoint);