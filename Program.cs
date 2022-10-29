using System;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            double lastNum = 0;

            while (true)
            {
                Console.Write("Введите число: ");
                string line = Console.ReadLine();

                if (int.TryParse(line, out int intNum))
                {
                    Console.WriteLine($"Символ соответствующий вашему числу: {(char)intNum}");
                    lastNum = intNum;
                }
                else if (double.TryParse(line, out double doubleNum))
                {
                    if (doubleNum == lastNum)
                        break;
                    lastNum = doubleNum;
                }
                else if (line == "q")
                    break;
            }
        }
    }
}
