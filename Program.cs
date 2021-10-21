using System;

namespace codewar
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task1();
            var task1Pass = task1.RunAssertions();
            Console.WriteLine($"Task 1: {(task1Pass ? "Pass" : "Fail")}");

            var task2 = new Task2();
            var task2Pass = task2.RunAssertions();
            Console.WriteLine($"Task 2: {(task2Pass ? "Pass" : "Fail")}");

            var task3 = new Task3();
            var task3Pass = task3.RunAssertions();
            Console.WriteLine($"Task 3: {(task3Pass ? "Pass" : "Fail")}");
        }
    }
}
