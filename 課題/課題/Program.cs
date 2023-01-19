using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //入力した2つの整数を足し算し_結果を表示させる            
            try
            {
                Console.WriteLine("入力した2つの整数を足し算します");
                Console.WriteLine("1つ目の整数を入力してください");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2つ目の整数を入力してください");
                int input2 = int.Parse(Console.ReadLine());
                Console.Write("合計は「");
                Console.Write(input1 + input2);
                Console.WriteLine("」");
            }
            catch (Exception a)
            {
                Console.WriteLine("整数以外の文字が入力されました");
            }        
        }
    }
}
