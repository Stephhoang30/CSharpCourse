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
            // định nghĩa một biểu thức lambda và gán biến action
            var action = () => Console.WriteLine("Hello Ha Phuong");

            action();

            // câu lệnh lambda tìm giá trị max trong ba số
            var findMax = (int a, int b, int c) =>
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

        }
    }
}

