﻿using System;
using System.Collections.Generic;
using System.Linq;
//using Features.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) =>
            {
                int temp = x + y;
                return temp;
            };

            Action<int> write = x => Console.WriteLine(x);

            write(square(add(3,5)));

            //Employee[] developers = new Employee[]
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name= "Scott" },
                new Employee { Id = 2, Name= "Chris" }
            };

            //List<Employee> sales = new List<Employee>()
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            foreach (var employee in developers.Where(
                            e => e.Name.StartsWith("S")
                ))
            {
                Console.WriteLine(employee.Name);
            }
            Console.ReadLine();
        }

  
        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
