using System;

namespace NumberBaseTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberTranslator translator = new NumberTranslator();
            Reader reader = new Reader();
            Messanger messanger = new Messanger();
            messanger.printMessage(translator.translateNumber(reader.readConsole()));
        }
    }

    class Reader
    {
            public int[] readConsole()
        {
            int[] arrayForTranslate = new int[2];
            int numberBase;
            int numberToTranslate;
            Console.WriteLine("Enter a number for translate");
            numberToTranslate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter base for translate from 3 to 20");
            numberBase = Convert.ToInt32(Console.ReadLine());
            if(numberBase <3 || numberBase > 20)
            {
                Console.WriteLine("Please enter valid number");
                numberBase = Convert.ToInt32(Console.ReadLine());
            }
            arrayForTranslate[0] = numberToTranslate;
            arrayForTranslate[1] = numberBase;
            return arrayForTranslate;
        }
    }

    class NumberTranslator
    {
        public int [] translateNumber(int [] number)
        {
            int [] result = new int [3];
            result[0] = (int)(Math.Floor(Math.Log(number[0]) / Math.Log(number[1])) + 1);
            result[1] = number[0];
            result[2] = number[1];
            return result;   
        }
    }

    class Messanger
    {
        public void printMessage(int [] result)
        {
            Console.WriteLine($"The Number of digits  of Number {result[1]} in base {result[2]} is {result[0]}");
        }
    }
}
