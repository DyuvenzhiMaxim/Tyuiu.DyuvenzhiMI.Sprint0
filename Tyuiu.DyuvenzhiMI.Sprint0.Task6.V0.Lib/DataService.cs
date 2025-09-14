namespace Tyuiu.DyuvenzhiMI.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        //Пример циклической структуры (цикл с параметром) for
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }

        //Пример циклической структуры (цикл с параметром) while
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;
        }

        //Пример циклической структуры (цикл с параметром) do while
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total *= numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;
        }
    }
}
