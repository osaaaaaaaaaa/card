﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    internal class Card
    {
        // 入力情報
        public List<int> numbers { get; private set; } = new List<int>();

        /// <summary>
        /// コンストラクター
        /// </summary>
        public Card() { 
            numbers = new List<int>();
        }

        /// <summary>
        /// 入力処理
        /// </summary>
        /// <param name="inputNum">入力情報</param>
        public void InputNumbers(int i)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[{0}]１～４の数字を入力してください   > ",i);
                bool isSuccess = int.TryParse(Console.ReadLine(), out int inputNum);

                if (isSuccess && inputNum > 0 && inputNum < 5)
                {
                    numbers.Add(inputNum);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n*** ERROR ***\n");
                }
            }
        }

        /// <summary>
        /// ペアになるカードの判定処理
        /// </summary>
        public void JudgePair()
        {
            string result = "ノーペア";
            bool isEnd = false;
            int i = 0;

            while (!isEnd && i < numbers.Count)
            {
                // リストの中から同じ値の要素を探し、カウントする(自身も含まれる)
                int pairCnt = numbers.FindAll(item => item == numbers[i]).Count();

                switch (pairCnt)
                {
                    case 1:// １つ見つけた
                        break;
                    case 2:// ２つ見つけた

                        // 自身と異なる値を持つ要素を探す
                        int notPairNum = numbers.Find(item => item != numbers[i]);
                        // notPairNumと同じ値を持つ要素があるかどうか(自身を除く)
                        bool isHit = numbers.FindAll(item => item == notPairNum).Count() - 1 > 0;
                        isEnd = true;
                        if (!isHit)
                        {
                            result = "ワンペア";
                        }
                        else
                        {
                            result = "ツーペア";
                        }
                        break;
                    case 3:// ３つ見つけた
                        isEnd = true;
                        result = "スリーカード";
                        break;
                    case 4:// ４つ見つけた
                        isEnd = true;
                        result = "フォーカード";
                        break;
                }

                i++;
            }

            Console.WriteLine("結果：" + result);
        }
    }
}
