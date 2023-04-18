Console.WriteLine(heron(9, 6,7));

static double heron(double a, double b, double c)
{
    double p = (a + b + c) / 2.0;
    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    return Math.Round(area, 2);
}