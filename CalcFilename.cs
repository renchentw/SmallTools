using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SmallTools
{
    class CalcFilename
    {
        public double total { get; }

        public CalcFilename(string dirPath)
        {
            try
            {
                // 建立指定目錄的實例
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                // 傳回指定目錄中所有檔案清單
                FileInfo[] fileInfo = dir.GetFiles();
                // 遍歷所有檔案，獲取指定的檔案名稱
                foreach (var fileName in fileInfo)
                {
                    string pattern = @"([1-9]\d*\.?\d*)";

                    foreach (Match match in Regex.Matches(fileName.Name, pattern))
                    {
                        double number = 0.0;
                        Double.TryParse(match.Value, out number);
                        total += number;
                        break;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
