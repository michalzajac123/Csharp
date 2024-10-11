using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy
{
    class Person
    {
       public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string Fullname=> $"{FirstName} {LastName}";

        public Person (string firstName, string lastName, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }


    class Employee : Person
    {
        public string jobTitle { get; set; }
        public decimal Salaray { get; set; }
        public Employee(string firstName,string lastName, byte age, string jobTitle,decimal salary) :base(firstName,lastName,age)
        {
            this.jobTitle = jobTitle;
            Salaray = salary;
        }
        public string Introduction()
        {
            return "Hello my name is " + Fullname + " " + Age;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee employee = new Employee("James","Bond",45,"Spy",1000000);
            Console.WriteLine(employee.Introduction());
            Console.WriteLine(employee.Salaray);

        }
    }
}
