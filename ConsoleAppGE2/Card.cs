using System;
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
                    this.numbers.Add(inputNum);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n*** ERROR ***\n");
                }
            }
        }
    }
}
