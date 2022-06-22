using System;
using System.IO;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(StrReader.SumAsync());
        }
    }
    class StrReader
    {
        public static async Task<string> ReaderHAsync()
        {

            return await Task.Run(() =>
            {
                string word1;
                StreamReader sr = new StreamReader("D:\\hello.txt");
                word1 = sr.ReadLine();
                sr.Close();
                return word1;
            });
        }
        public static async Task<string> ReaderWAsync()
        {

            return await Task.Run(() =>
            {
                string word2;
                StreamReader sr = new StreamReader("D:\\world.txt");
                word2 = sr.ReadLine();
                sr.Close();
                return word2;
            });
        }
        public static async Task<string> SumAsync()
        {
            string phraze = await ReaderHAsync()+ await ReaderWAsync();
            return phraze;
        }
    }
}
