using System;

namespace SmallTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            while (true)
            {
                Console.WriteLine("請選擇功能：");
                Console.WriteLine("1 | 計算資料夾檔名中的數字");
                Console.Write("\n請輸入： ");
                string input = Console.ReadLine();
                if (input.Trim().ToUpper() == "EXIT") break; // 結束程式
                int select;
                int.TryParse(input, out select);

                switch (select)
                {
                    case 1: // 進入CalcFilename
                        FunCalcFilename();
                        break;
                    default:
                        break;


                }

                Console.WriteLine("");
            }
        }

        static void FunCalcFilename()
        {
            while (true)
            {
                Console.WriteLine("\n[資料夾檔名計算功能]");
                Console.WriteLine("請輸入資料夾路徑： (輸入exit退出)");
                Console.Write("請輸入： ");
                string input = Console.ReadLine();
                if (input.Trim().ToUpper() == "EXIT") break;

                if (input != "")
                {
                    CalcFilename calcFilename = new CalcFilename(input);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"總金額為￥ {calcFilename.total} 元");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }


            }
        }
    }
}
