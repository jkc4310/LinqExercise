using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE: Print the Sum of numbers
            Console.WriteLine("--sum--");
            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");


            //DONE: Print the Average of numbers
            Console.WriteLine("--avg--");
            var avg = numbers.Average();
            Console.WriteLine($"Average: {avg}");


            //DONE: Order numbers in ascending order and print to the console
            Console.WriteLine("--ascending--");
            var sortascending = numbers.OrderBy(num => num);
            foreach (var num in sortascending)
            {
                Console.WriteLine(num);
            }

            //DONE: Order numbers in descending order and print to the console
            Console.WriteLine("--Descending--");
            var sorteddescending = numbers.OrderByDescending(x => x);
            foreach (var x in sorteddescending)
            {
                Console.WriteLine(x);
            }


            //DONE: Print to the console only the numbers greater than 6
            Console.WriteLine("--numbers greater than 6--");
            var oversix = numbers.Where(numbers => numbers > 6);
            foreach (var numbers in oversix)
            {
                Console.WriteLine(numbers);
            }

            //DONE: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            // var only4 = numbers.Take(4);
            Console.WriteLine("--only print 4--");
            foreach (var num in sorteddescending.Take(4)) 
            {
                Console.WriteLine(num);
            }


            //DONE: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("--changed number at index 4 with my age--");
            numbers[4] = 32;
            foreach (var item in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(item);
            }

            // List of employees ****Do not remove this****
                var employees = CreateEmployees();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filtered = employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S'))
                .OrderBy(person => person.FirstName);

            Console.WriteLine("C or S Employees");
            foreach (var employee in filtered)
            {
                Console.WriteLine(employee.FullName);
            }


            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var overTwentySix = employees.Where(person => person.Age > 26)
                .OrderBy(person => person.Age).ThenBy(person => person.FirstName);
            Console.WriteLine("age and first name");
            foreach (var person in overTwentySix)
            {
                Console.WriteLine($"Age: {person.Age} Full Name: {person.FullName} YOE: {person.YearsOfExperience}");
            }

            //DONE: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var yoeEmployees = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var sumOfYOE = yoeEmployees.Sum(employees => employees.YearsOfExperience);
            var avgOfYOE = yoeEmployees.Average(employees => employees.YearsOfExperience);

           
                Console.WriteLine($"Sum {sumOfYOE} Avg {avgOfYOE}");
            



            //DONE: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("First", "lastName", 98, 1)).ToList();

            foreach (var item in employees)
            {
                Console.WriteLine($"{item.FirstName} {item.Age}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
