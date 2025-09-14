using Tyuiu.DyuvenzhiMI.Sprint0.Task6.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

        //Пример циклического алгоритма находящийся в библиотеке классов в методе AdditionArray
        Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

        //Пример циклического алгоритма находящийся в библиотеке классов в методе SubtractionArray
        Console.WriteLine("Сумма элементов массива = " + DataService.SubtractionArray(numsArray));

        //Пример циклического алгоритма находящийся в библиотеке классов в методе MultiplicationArray
        Console.WriteLine("Сумма элементов массива = " + DataService.MultiplicationArray(numsArray));

        Console.ReadKey();
    }
}