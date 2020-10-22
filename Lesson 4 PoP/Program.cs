using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_PoP
{
    class Program
    {
        private static void Main(string[] args)
        {
            //string message = Sum1toN_v2();
            //Console.WriteLine(message);

            //Sum1toN();

            //StarTriangle();

            //MirrorStarTriangle();

            //HW 1
            //Diamond();
            
            //HW 2
            Console.Write("String to encode: ");
            string stringToEncode = Console.ReadLine();

            string encodedString = Encode(stringToEncode);
            Console.WriteLine($"Encoded string: {encodedString}");

            string decodedString = Decode(encodedString);
            Console.WriteLine($"Decoded string: {decodedString}");

            Console.ReadKey();
        }

        //Homework 1
        private static void Diamond()
        {
            Console.Write("n = ");
            int r = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i <= r; i++)
            {
                for (int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if(j>((2*i-1)/2)+1)
                    {
                        Console.Write(j-2-counter);
                        counter+=2;
                    }
                    else
                    {
                        Console.Write(j);
                    }                    
                }
                counter = 0;
                Console.WriteLine();
            }

            for (int i = r - 1; i >= 1; i--)
            {
                for (int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j > ((2 * i - 1) / 2) + 1)
                    {
                        Console.Write(j - 2 - counter);
                        counter += 2;
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                counter = 0;
                Console.WriteLine();
            }
        }

        //Homework 2
        private static char[] alphabet = { 'a', 'b', 'c','d', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static char[] secret = { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' };

        /// <summary>
        /// Encode a string
        /// </summary>
        /// <param name="inputString">string to encode</param>
        /// <returns>string encoded</returns>
        private static string Encode(string inputString)
        {
            string result = "";
            foreach (char character in inputString)
            {
                int index = IndexOf(character, alphabet);
                result += secret[index];
            }
            return result;
        }

        /// <summary>
        /// Decode a string
        /// </summary>
        /// <param name="encodedString">Encoded string</param>
        /// <returns>Decoded string</returns>
        private static string Decode(string encodedString)
        {
            string result = "";
            foreach (char character in encodedString)
            {
                int index = IndexOf(character, secret);
                result += alphabet[index];
            }
            return result;
        }

        /// <summary>
        /// Find the index of each character in the alphabet
        /// </summary>
        /// <param name="letter">Letter whose index is to be found</param>
        /// <param name="array">Alphabet</param>
        /// <returns>Index of a character</returns>
        private static int IndexOf(char letter, char[] array)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (array[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }

        //Task 2
        private static void StarTriangle()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private static void MirrorStarTriangle()
        {
            Console.Write("n = ");
            int r = int.Parse(Console.ReadLine());

            for (int i = 0; i <= r; i++)
            {
                for (int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = r - 1; i >= 1; i--)
            {
                for (int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Task 1
        private static void Sum1toN()
        {
            Console.Write("n = ");

            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int sum = 1;

            Console.Write("The sum 1");
            while (number < n)
            {
                number++;
                sum += number;
                Console.Write($"+{number}");
            }
            Console.WriteLine(" = {0}", sum);
        }

        private static string Sum1toN_v2()
        {
            Console.Write("n = ");

            int n = int.Parse(Console.ReadLine());

            int number = 1;
            int sum = 1;

            string message = "The sum 1";

            while (number < n)
            {
                number++;
                sum += number;
                message += $"+{number}";
            }
            message += $" = {sum}";

            return message;
        }
    }
}
