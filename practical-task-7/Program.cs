using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodException mExcept = new MethodException();
            Console.WriteLine("Введите Имя");
            mExcept.Name = Console.ReadLine();
            mExcept.FirstMethod();
            Console.ReadKey();
        }
    }
}
