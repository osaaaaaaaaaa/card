using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isEnd = false;
            while (!isEnd)
            {
                Card card = new Card();

                // 値を入力するフォーム
                card.InputNumbers();

                // ペアを探し、結果を表示する
                card.JudgePair();

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nこのあとはどうする...？ [1:もう一度あそぶ , 0:やめる]");
                    Console.Write(">> ");
                    bool isSuccess = int.TryParse(Console.ReadLine(), out int selectNum);    // 入力内容をintに変換

                    // intに変換できた
                    if (isSuccess && selectNum == 0 || selectNum == 1 )
                    {
                        switch (selectNum)
                        {
                            case 0:
                                isEnd = true;
                                break;
                            case 1:
                                Console.Clear();
                                break;
                        }

                        break;
                    }
                    // 正しく入力できていない場合
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n*** ERROR ***\n");
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n\n##### ENTERで終了 #####");
            Console.ReadLine();
        }
    }
}
