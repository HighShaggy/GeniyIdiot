using System;

namespace GeniyIdiot.Common
{
    public class Validation
    {
        public static int GetNumber()
        {
            while (true)
            {
                try
                {
                   
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите число");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введите число");
                }
            }
        }
    }
}
