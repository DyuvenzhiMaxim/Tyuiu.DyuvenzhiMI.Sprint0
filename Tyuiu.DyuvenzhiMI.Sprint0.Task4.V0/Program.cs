using Tyuiu.DyuvenzhiMI.Sprint0.Task4.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        //Пример линейной стуктуры программы
        //Вызов метода сложения Addiction
        Console.WriteLine(DataService.Addition(1, 5));

        //Вызов метода вычитания Subtraction
        Console.WriteLine(DataService.Subtraction(15, 5));

        //Вызов метода умножения Multiplication
        Console.WriteLine(DataService.Multiplication(10, 10));

        //Вызов метода деления Division
        Console.WriteLine(DataService.Division(5, 5));

        Console.ReadKey();
    }
}