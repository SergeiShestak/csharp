using System;

namespace GetStartedDebugging
{
    class ArrayExample
    {
        static void Main(string[] args)
        {
            char[] letters = { 's', 'i', 'a', 'r', 'h', 'e', 'i', ',', 's', 'h', 'e', 's', 't', 'a', 'k' };
            String name = "";
            int[] a = new int[15];
            for(int i=0;i<letters.Length; i++)
            {
                name += letters[i];
                a[i] = i + 1;
                SendMessage(name, a[i]);
            }
            Console.ReadKey();
        }

        static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Hello," + name + "! Count " + msg);
        }
    }

}