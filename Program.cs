using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 32, 45, 9, 17, 20, 78, 91 };

            ////method syntax
            //List<int> odds = nums.Where(x => x % 2 == 1).ToList();

            //foreach(int num in odds)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();
            ////query syntax
            //var odds2 = from num in nums
            //            where num % 2 == 1
            //            select num;
            //foreach (int num in odds2.ToList())
            //{
            //    Console.WriteLine(num);
            //}

            ////find the greatest number
            //int highestNum = nums.Max();
            //Console.WriteLine("Highest number");
            //Console.WriteLine(highestNum);
            //Console.WriteLine();
            //Console.WriteLine("Highest numberunder 20");
            //int under20 = nums.Where(x => x < 20).Max();
            //Console.WriteLine(under20);

            ////count all the even numbers
            //Console.WriteLine();
            //Console.WriteLine("count the even numbers");
            //int totalEvens = nums.Where(x => x % 2 == 0).Count();
            //Console.WriteLine(totalEvens);
            //Console.WriteLine("-----------------------------------");
            Console.WriteLine("For Nums");
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            Console.WriteLine("1. Find Minimum Value");
            int num = nums.Min();
            Console.WriteLine(num);
            Console.WriteLine("2. Find Maximum Value");
            int num1 = nums.Max();
            Console.WriteLine(num1);
            Console.WriteLine("3. Find Maximum Value under 10000");
            int num2 = nums.Where(x => x<10000).Max();
            Console.WriteLine(num2);
            Console.WriteLine("4. Find all values between 10 and 100");
            List<int> nums2 = nums.Where(x => x >=10 && x <= 100).ToList();
           foreach(int number in nums2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("5. Find all values between 100000 and 900000");
            List<int> nums3 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            foreach (int number in nums3)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("6. Count the even numbers");
            int totalEvens = nums.Where(x => x % 2 == 0).Count();
            Console.WriteLine(totalEvens);
            Console.WriteLine();

            Console.WriteLine("For Students");
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13)); students.Add(new Student("Hannah Banana", 21)); students.Add(new Student("Justin", 30)); 
            students.Add(new Student("Sarah", 53)); students.Add(new Student("Hannibal", 15)); students.Add(new Student("Phillip", 16)); 
            students.Add(new Student("Maria", 63)); students.Add(new Student("Abe", 33)); students.Add(new Student("Curtis", 10));

            Console.WriteLine("1. Find the students of drinking age (US)");
            List<Student> drinkers = students.Where(x => x.Age >= 21).ToList();
            foreach(Student stu in drinkers)
            {
                Console.WriteLine(stu.Name);
            }
            Console.WriteLine("2. Find the oldest student");
            Student s = students.OrderByDescending(x => x.Age).First();
            Console.WriteLine(s.Name);
            Console.WriteLine("3. Find the youngest student");
            Student b = students.OrderBy(x => x.Age).First();
            Console.WriteLine(b.Name);
            Console.WriteLine("4. Find the oldest student under 25");
            List<Student> notOldies = students.Where(x => x.Age < 25).ToList();
            Student notOld = notOldies.OrderByDescending(x => x.Age).First();
            Console.WriteLine(notOld.Name);
            Console.WriteLine("5. Find the students over 21 and with even ages");
            List<Student> fiveList = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            foreach(Student f in fiveList)
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine("6. Find all teenagers");
            List<Student> teens = students.Where(x => x.Age > 12 && x.Age < 20).ToList();
            foreach(Student t in teens)
            {
                Console.WriteLine(t.Name);
            }
            Console.WriteLine("7. Find the students whose names start with a vowel");
            List<Student> vowelNames = new List<Student>();
            foreach (Student stud in students)
            {
                if (stud.Name.StartsWith('A')|| stud.Name.StartsWith('E')|| stud.Name.StartsWith('I')|| stud.Name.StartsWith('O')|| stud.Name.StartsWith('U'))
                {
                    vowelNames.Add(stud);
                }
            }
            foreach(Student stus in vowelNames)
            {
                Console.WriteLine(stus.Name);
            }

            //Console.WriteLine("get a list of students that can drive");
            //List<Student> drivers = students.Where(x => x.CanDrive == true).ToList();
            //foreach(Student a in drivers)
            //{
            //    Console.WriteLine(a.Name);
            //}
        }
    }
}
