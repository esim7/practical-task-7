using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_7
{
    class MethodException
    {
        public string Name { get; set; }

        public void FirstMethod()
        {
            try
            {
                SecondMethod(Name);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вызвано исключение: {exception.Message}");
            }
        }

        public void SecondMethod(string Name)
        {
            string name = Name;
            if (name == "Makishev")
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine("Все прошло ОК");
            }
        }
    }
}
