using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson57
    {
        static void Main()
        {
            //// định nghĩa một biểu thức lambda và gán biến action
            //var action = () => Console.WriteLine("Hello Ha Phuong");

            //action();

            //// câu lệnh lambda tìm giá trị max trong ba số
            //var findMax = int (int a, int b, int c) =>
            //{
            //    int max = a;
            //    if (max < b)
            //    {
            //        max = b;
            //    }  
            //    if (max < c)
            //    {
            //        max = c;    
            //    }
            //    return max;
            //};  

            //int maxValue = findMax(1, 2, 3);
            //Console.WriteLine($"Max value in (1, 2, 3): {maxValue}");

            //int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

            //var countOddNumber = int (int[] arr) =>
            //{
            //    int count = 0;
            //    foreach (int item in arr)
            //    {
            //        if (item % 2 != 0)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //};

            //var result = countOddNumber(numbers);
            //Console.WriteLine($"Number of odd element in array: {result}");

            Console.WriteLine("==================================================");

            // định nghĩa một biểu thức lambda và gán biến action
            Action<string> action = (msg) => Console.WriteLine(msg);
            action("Hello Ha Phuong");

            // câu lệnh lambda tìm giá trị max trong ba số
            Func<int, int, int, int> findMax = (a, b, c) =>
            {
                int max = a;
                if (max < b)
                {
                    max = b;
                }  
                if (max < c)
                {
                    max = c;  
                }
                return max;
            };  

            int maxValue = findMax(1, 2, 3);
            Console.WriteLine($"Max value in (1, 2, 3): {maxValue}");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9,  10, 11, 12 };

            Func<int[], int> countOddNumber = (arr) =>
            {
                int count = 0;
                foreach (int item in arr)
                {  
                    if (item % 2 != 0)
                    {
                        count++;
                    }
                }
                return count;
            };

            var result = countOddNumber(numbers);
            Console.WriteLine($"Number of odd element in array: {result}");
        }
    }
}

