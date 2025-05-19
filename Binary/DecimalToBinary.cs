using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class DecimalToBinary
    {
        public static void Run()
        {
            Console.WriteLine("Decimal to Binary Converter");
            Console.WriteLine("Enter you IP-address");
            string decimalinput = Console.ReadLine();
            string output = ConvertDecimalToBinary($"{decimalinput}");

            Console.WriteLine(output);
        }

        public static string ConvertDecimalToBinary(string decimalIP)
        {
            string[] octets = decimalIP.Split('.');
            string binaryholder = "";
            if (octets.Length != 4)
            {
                Console.WriteLine("Invalid IP address format. Please enter a valid IP address.");
                return string.Empty;
            }
            foreach (string octet in octets)
            {
                if (!int.TryParse(octet, out int decimalValue) || decimalValue < 0 || decimalValue > 255)
                {
                    Console.WriteLine("Invalid IP address format. Please enter a valid IP address.");
                    return string.Empty;
                }

                string tempholder = "";

                while (decimalValue > 0)
                {
                    int remainder = decimalValue % 2;
                    tempholder += remainder.ToString();
                    decimalValue /= 2;
                }

                tempholder = new string(tempholder.Reverse().ToArray()).PadLeft(8, '0');
                binaryholder += tempholder + ".";
            }
            binaryholder = binaryholder.TrimEnd('.');
            return binaryholder.ToString();
        }
    }
}