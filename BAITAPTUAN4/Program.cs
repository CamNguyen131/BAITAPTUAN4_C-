using System;
using System.Text;

namespace BAITAPTUAN4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyGeneriClass<int> intObj = new MyGeneriClass<int>();
            int[] arrInt = { 5, 2, 9, 1 };

            Console.WriteLine("Mảng int trước khi sắp xếp:");
            intObj.PrintArray(arrInt);

            intObj.Sort(arrInt);

            Console.WriteLine("Mảng int sau khi sắp xếp:");
            intObj.PrintArray(arrInt);

            Console.ReadKey();
        }
    }
}