using System;

namespace MaxLengthString2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a string as argument");
            }
            Reader reader = new Reader();
            Counter counter = new Counter();
            Messanger messanger = new Messanger();
            messanger.printMessage(counter.countLength(reader.readArgs(args))); 

        }
    }

    class Reader
    {
        public string readArgs(String[] args)
        {
            string argc = args[0];
            return argc;
        }
    }

    class Messanger
    {

        public void printMessage(int output)
        {
            Console.WriteLine($"Maximum length of string is:{output}");
        }
    }

    class Counter
    {
        public int countLength(String args)
        {
            
            int output = 0;
            int tempOutput = 0;
            char tempChar = (char)0;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] != tempChar)
                {
                    tempOutput++;
                }
                else
                {
                    tempOutput = 0;
                }
                if (output < tempOutput)
                {
                    output = tempOutput;
                }
                tempChar = args[i];

            }
            return output;
        }
    }
}
