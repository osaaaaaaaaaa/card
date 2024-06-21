using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Program
    {
        // フォームの数
        const int FormCntMax = 4;

        static void Main(string[] args)
        {
            bool isEnd = false;
            while (!isEnd)
            {
                Card card = new Card();

                // 1~4の値を入力するフォーム
                for (int i = 0; i < FormCntMax; i++)
                {
                    card.InputNumbers(i + 1);
                }

                // ペアを探し、結果を表示する
                card.JudgePair();

                bool isSuccess = false;
                while (!isSuccess)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nこのあとはどうする...？ [1:もう一度あそぶ , 0:やめる]");
                    Console.Write(">> ");
                    isSuccess = int.TryParse(Console.ReadLine(), out int selectNum);    // 入力内容をintに変換

                    // 正しく入力できた && やめる場合
                    if (isSuccess && selectNum == 0)
                    {
                        isEnd = true;
                    }
                    // 正しく入力できていない場合
                    else if(!isSuccess)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n*** ERROR ***\n");
                    }
                    else
                    {
                        Console.Write("\n\n################################################\n\n\n");
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n\n##### ENTERで終了 #####");
            Console.ReadLine();
        }
    }
}
