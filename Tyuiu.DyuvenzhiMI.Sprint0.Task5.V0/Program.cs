using Tyuiu.DyuvenzhiMI.Sprint0.Task5.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        //Пример линейной структуры
        Console.WriteLine("A + B = " + DataService.Addition(1, 5));
        Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
        Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

        //Пример разветвляющейся структуры в библиотеке классов в методе Division
        Console.WriteLine("A / B = " + DataService.Division(5, 0));

        Console.ReadKey();
    }
}