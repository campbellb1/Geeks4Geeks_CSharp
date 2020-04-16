using System;
using System.Collections;
using System.Collections.Generic;

namespace Geeks4Geeks_Cshp
{
    class Program
    {
        static void Main()
        {
            Console.Write(MinNumJumps(85, 85, 30));
            Console.Read();
        }

        private static void CountCharacters()
        {
            List<string> args = new List<string>();
            string line = "";
            int counter = 0;
            while (!String.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                args.Add(line.ToString());
            }


            var testCases = args[0];
            for (int i = 1; i < int.Parse(testCases) + 1; i++)
            {
                int lowerCaseCount = 0;
                int upperCaseCount = 0;
                int specialCount = 0;
                int numCount = 0;
                foreach (char c in args[i].ToString())
                {
                    if ((int)c > 64 && (int)c < 91)
                    {
                        upperCaseCount++;
                    }
                    else if ((int)c > 96 && (int)c < 123)
                    {
                        lowerCaseCount++;
                    }
                    else if ((int)c > 47 && (int)c < 58)
                    {
                        numCount++;
                    }
                    else
                    {
                        specialCount++;
                    }
                }
                Console.WriteLine(upperCaseCount);
                Console.WriteLine(lowerCaseCount);
                Console.WriteLine(numCount);
                Console.WriteLine(specialCount);
            }
            Console.Read();
        }

        private static void FindArea()
        {
            List<string> args = new List<string>();
            string line = "";
            int counter = 0;
            while (!String.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                args.Add(line.ToString());
            }

            var testCases = args[0];
            for (int i = 1; i < int.Parse(testCases) + 1; i++)
            {
                string[] sides_initial = new string[3];
                sides_initial = args[i].Split(' ');
                double[] sides = Array.ConvertAll(sides_initial, double.Parse);
                //check for impossible triangle.
                int maxSide = 0;

                for (int x = 0; x < sides.Length; x++)
                {
                    if (sides[x] > sides[maxSide])
                    {
                        maxSide = x;
                    }
                }

                double sumOfSides = sides[0] + sides[1] + sides[2];
                if(sides[maxSide] > (sumOfSides - sides[maxSide]))
                {
                    Console.WriteLine("0.000000");
                }
                else
                {
                    double semiPerimeter = sumOfSides / 2.0;
                    double area = (double)(Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2])));
                    Console.WriteLine(area.ToString("0.000000"));
                }
            }
            Console.Read();
        }

        public static int solution(int N)
        {
            int sln = 0;
            int zeroCount = 0;
            int maxCount = 0;
            string binaryString = Convert.ToString(N, 2);
            foreach(char c in binaryString)
            {
                if(c == '0')
                {
                    zeroCount++;
                }
                else if(c == '1')
                {
                    if(maxCount < zeroCount)
                    {
                        maxCount = zeroCount;
                    }
                    zeroCount = 0;
                }
            }
            return maxCount;
        }

        public static int[] ArrayRotator(int[] A, int K)
        {
            int arrayIndex = 0;
            int[] rotatedArray = new int[A.Length];
            for(int i = 0; i < A.Length; i++)
            {
                arrayIndex = i + K;
                while (arrayIndex > A.Length - 1)
                {
                    arrayIndex = arrayIndex - A.Length;
                }

                rotatedArray[arrayIndex] = A[i];
            }
            return rotatedArray;
        }

        public static int FindOddElement(int[] A)
        {
            int oddElement = 0;
            int[] pairedElements = new int[A.Length / 2];
            int[] passedElements = new int[A.Length / 2];
            int pairECounter = 0;
            int passECounter = 0;
            foreach (int x in A)
            {
                if(Array.Exists(passedElements, ele => ele.Equals(x)))
                {
                    pairedElements[pairECounter] = x;
                    pairECounter++;
                    break;
                }
                else
                {
                    passedElements[passECounter] = x;
                    passECounter++;
                }
            }

            for(int x = 0; x < passedElements.Length; x++)
            {
               if(!Array.Exists(pairedElements, ele => ele.Equals(passedElements[x])))
                {
                    oddElement = passedElements[x];
                    break;
                }
            }

            return oddElement;
        }

        public static int FindOddElement_2(int[] A)
        {
            int n = A.Length;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                res = res ^ A[i];
            }
            return res;
        }

        public static int MinNumJumps(int X, int Y, int D)
        {
            //X //start
            //Y //end
            //D //increment

            return (int)Math.Ceiling(((double)(Y - X) / (double)D));
            
        }
    }
}
