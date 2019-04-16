using System;

namespace ReverseBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = 33;

            outputBitsString("Original bit string: ", num);
            outputBitsString("Reversed bit string: ", reverseBits(num));
        }

        public static uint reverseBits(uint n)
        {
            uint result = 0;
            for (var i = 0; i < 32; i++)
            {
                result <<= 1;
                uint val = (uint)Math.Pow(2, i);
                if ((n & val) > 0)
                    result += 1;

            }
            return result;
        }

        public static void outputBitsString(string msg, uint num)
        {
            string output = Convert.ToString(num, 2).PadLeft(32, '0'); ;
            Console.WriteLine(msg + output);
        }
    }
}

//////////////////////////////////////////////////////////////
//
// Sample run:
//
// Original bit string: 00000000000000000000000000100001
// Reversed bit string: 10000100000000000000000000000000
