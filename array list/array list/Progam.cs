using System;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<string>();
            customList.Add("first");
            customList.Add("second");
            customList.Add("third");
            customList.Add("forth");
            Console.WriteLine("add items");
            foreach(var item in customList)
            {
                Console.WriteLine(item);
            }
        }
    }
}