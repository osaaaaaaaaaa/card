using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Program
    {
        const int FormCntMax = 4;

        static void Main(string[] args)
        {
            Card card = new Card();

            // 1~4の値を入力するフォーム
            for(int i = 0; i < FormCntMax; i++)
            {
                card.InputNumbers(i+1);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n\n##### ENTERで終了 #####");
            Console.ReadLine();
        }
    }
}
