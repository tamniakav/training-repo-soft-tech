using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int position = input[input.Length - 1];
            int[] gameField = new int[input.Length - 1];

            for (int i = 0; i < input.Length - 1; i++)
            {
                gameField[i] = input[i];
            }

            int count = 0;

            while (true)
            {
                for (int i = 0; i < gameField.Length; i++)
                {
                    gameField[i]--;
                }
                
                if (gameField[position] == 0)
                {
                    break;
                }

                count++;

                for (int i = 0; i < gameField.Length; i++)
                {
                    if (gameField[i] == 0)
                    {
                        gameField[i] = input[i];
                    }
                }

                position = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", gameField));
            Console.WriteLine(count);
        }
    }
}
