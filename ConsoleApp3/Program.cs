using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter minNumber: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter maxNumber: ");
            int maxNumber = int.Parse(Console.ReadLine());

            if (minNumber > maxNumber)
            {
                Console.WriteLine("minNumber should be lower than the maxNumber");
                return;
            }


            int[] frequency = new int[maxNumber - minNumber + 1];
            

            Random random = new Random();


            for (int i = 0; i < 1000; i++)
            {
                int number = random.Next(minNumber, maxNumber + 1);
                frequency[number - minNumber]++;
            }

            Console.WriteLine("\nNumber\t\tFrequency");
            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine((i + minNumber) + "\t\t" + frequency[i]);
            }

        }
    }
}