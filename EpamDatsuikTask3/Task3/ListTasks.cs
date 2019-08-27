using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamDatsuikTask3.Task1
{
    public class ListTasks : IRunnable
    {
        private List<string> CreateList()
        {
            List<string> randomList = new List<string>();
            Random random = new Random();
            for (int i = 0; i < random.Next(1, 99); i++)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                var stringChars = new char[4];
                for (int f = 0; f < stringChars.Length; f++)
                {
                    stringChars[f] = chars[random.Next(chars.Length)];
                }
                var finalString = new String(stringChars).ToUpper();
                randomList.Add(finalString);
            }
            return randomList;
        }
        public IEnumerable<string> RemoveDistinctAndWithZ()
        {
            CreateList().RemoveAll(str => str.StartsWith("Z"));
            return CreateList().Distinct();
        
    }
        public void DisplayPage(int numberOfPage)
        {
            var page = CreateList()
                .Skip((numberOfPage - 1) * 5)
                .Take(5);
            Console.WriteLine("Page {0}.", numberOfPage);
            foreach (var item in page)
            {
                Console.WriteLine(item + ", ");
            }
        }
       public void Run()
        {
            Console.WriteLine("Task 3\n");
            var randomList = CreateList();
            Console.WriteLine("List before changing:");
            Console.WriteLine("Size of list: {0}", randomList.Count);
            foreach (var item in randomList)
            {
                Console.Write(item + ", ");
            }
            var tempList = RemoveDistinctAndWithZ();
            randomList = tempList.ToList();
            tempList = randomList.OrderByDescending(str => str);
            randomList = tempList.ToList();
            Console.WriteLine("  " + "List after changing:");
            Console.WriteLine("Size of list: {0}", randomList.Count);
            foreach (var item in randomList)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n" + "Write a number of page:");
            bool check = Int32.TryParse(Console.ReadLine(), out int page);
            if (!check)
            {
                Console.WriteLine("Invalid data!");
                Console.ReadKey();
                Environment.Exit(-1);
            }
            else
            {
                DisplayPage(page);
            }
        }
    }

    }

