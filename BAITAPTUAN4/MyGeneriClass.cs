using System;
using System.Text;

namespace BAITAPTUAN4
{
    public class MyGeneriClass<T> where T : IComparable<T>
    {
        // Phương thức in mảng
        public void PrintArray(T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        // Phương thức sắp xếp (Bubble Sort)
        public T[] Sort(T[] inputArray)
        {
            int n = inputArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (inputArray[j].CompareTo(inputArray[j + 1]) > 0)
                    {
                        T temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                    }
                }
            }

            return inputArray;
        }
    }
}