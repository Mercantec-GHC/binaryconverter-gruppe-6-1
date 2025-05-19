using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class BinaryToDecimal
    {
        public static void Run()
        {
            Console.WriteLine("Binary to Decimal Converter");
            Console.Write("Indtast et binært tal: ");
            string binaryInput = Console.ReadLine();

            if (!IsBinary(binaryInput))
            {
                Console.WriteLine("Ugyldigt input! Brug kun 0 og 1.");
                return;
            }

            Console.WriteLine(ConvertBinaryToDecimal(binaryInput));
        }

        public static int ConvertBinaryToDecimal(string binaryString)
        {
            
            List<int> powerOfTwos = new List<int>();
            int value = 1;

            for (int i = 0; i < binaryString.Length; i++)
            {
                powerOfTwos.Insert(0, value);
                value *= 2;
            }
            
            int sum = 0;

            for (int i = 0; i < binaryString.Length; i++)
            {
                Console.WriteLine("i" + i);
                int number = binaryString[i] - '0';
                Console.WriteLine(number);

                int powerOfTwo = powerOfTwos[i];
                Console.WriteLine(powerOfTwo);

                sum += number * powerOfTwo;
            }

            Console.WriteLine($"Eksempel: {binaryString} => {sum}");

            return sum;
        }

        public static bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }
    }
}
