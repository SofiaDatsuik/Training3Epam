using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamDatsuikTask3.Task1
{
    public class Person: IPrintable<Person>, IRunnable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }

        public Person(string name, int age, IEnumerable<string> phoneNumbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = phoneNumbers;
        }

        public Person()
        {
        }

        public void PrintListFirstTask()
        {
            var personsList = CreateList();
            foreach( var item in personsList)
            { 
                Console.WriteLine("Person`s name " + item.Name + " and age " + item.Age);
            }
        }

        public List<Person> CreateList()
        {
            var phoneNumbersFirstPerson = new List<string>() { "+380971324113", "+380976324113", "+380978824113", "+380977824113" };
            var phoneNumbersSecondPerson = new List<string>() { "+380971324116", "+380976324163", "+380978824613", "+380977824113" };
            var phoneNumbersThirdthPerson = new List<string>() { "+380976324113", "+380736324113", "+380678824113", "+380687824113" };
            var phoneNumbersForthPerson = new List<string>() { "+380678324113", "+380675324113", "+380978111113", "+380984824113" };
            var phoneNumbersFifthPerson = new List<string>() { "+380965324113", "+380985674113", "+380968624113", "+380987824113" };
            var list = new List<Person>();
            list.Add(new Person(Name = "Inna", Age = 33, PhoneNumbers = phoneNumbersFifthPerson));
            list.Add(new Person(Name = "Alina", Age = 20, PhoneNumbers = phoneNumbersSecondPerson));
            list.Add(new Person(Name = "Viktoia", Age = 21, PhoneNumbers = phoneNumbersThirdthPerson));
            list.Add(new Person(Name = "Iryna", Age = 22, PhoneNumbers = phoneNumbersForthPerson));
            list.Add(new Person(Name = "Taras", Age = 19, PhoneNumbers = phoneNumbersFifthPerson));
            return list;
        }

        public List<Person> AddItem()
        {
            var item = CreateList();
            var phoneNumbersFirstPerson = new List<string>() { "+380971324114", "+380976324112", "+380957824113" };
            var phoneNumbersSecondPerson = new List<string>() { "+380971324165", "+380976324143", "+380978824613", "+380977824111" };
            var Persons = new List<Person>{ new Person(Name = "Victor", Age = 31, PhoneNumbers = phoneNumbersFirstPerson),
            new Person(Name = "Oleksiy", Age = 22, PhoneNumbers = phoneNumbersSecondPerson)};
            item.AddRange(Persons);
          
            return item;
        }
        public void PrintListSecondTask()
        {
            var personsList = AddItem();
            foreach (var item in personsList)
            {
                foreach (var phone in item.PhoneNumbers )
                {
                  Console.Write(" : PhoneNumbers : " + phone + "\n");
                }
               
            }
        }

        public void Run()
        {
            Console.WriteLine("Training 3\n Task 1");
            Console.WriteLine("List persons before changing:");
            PrintListFirstTask();
            Console.WriteLine("Task2 \n" + "List persons after changing:");
            PrintListSecondTask();
        }
    }
}
