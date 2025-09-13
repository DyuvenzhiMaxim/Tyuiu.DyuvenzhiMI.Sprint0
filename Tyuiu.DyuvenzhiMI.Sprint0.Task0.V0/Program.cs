using Tyuiu.DyuvenzhiMI.Sprint0.Task0.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int t = 3;
        int l = 3;

        int sum = ClassWork.Add(t, l);
        Console.WriteLine("Сумма = " + sum);
        Console.ReadKey();
    }
}