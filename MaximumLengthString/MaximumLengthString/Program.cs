using System;

namespace MaximumLengthString
{
    class Programm
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Please enter a string");
            }
            string argc = args[0];
            int output = 0;
            int tempOutput = 0;
            char tempChar = (char)0;
            for(int i=0; i < argc.Length; i++)
            {
                if (argc[i] != tempChar)
                {
                    tempOutput++;
                }
                else
                {
                    tempOutput = 0;
                }
                if(output < tempOutput)
                {
                    output = tempOutput;
                }
                tempChar = argc[i];

            }
            Console.WriteLine(output);
        }
    }
}
