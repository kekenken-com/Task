using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題3
{
    internal class Program
    {
        static void Main(string[] args)
        {            //入力した整数が奇数か偶数か判定し、結果を表示させる
            try
            {
                Console.WriteLine("入力した整数を奇数か偶数か判定します");
                int input3 = int.Parse(Console.ReadLine());
                if (input3 % 2 == 0)
                {
                    Console.WriteLine(input3 + "は偶数");
                }
                else
                {
                    Console.WriteLine(input3 + "は奇数");
                }
            }
            catch (Exception b)
            {
                Console.WriteLine("整数以外の文字が入力されました");
            }
        }
    }
}
