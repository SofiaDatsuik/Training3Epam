
using EpamDatsuikTask3.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Run();
            var listTasks = new ListTasks();
            listTasks.Run();
           Console.ReadLine();
        }
    }
}
