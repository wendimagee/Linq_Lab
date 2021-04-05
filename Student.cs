using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool CanDrive => Age >= 16;
        //when you set a lambda on a variable, it sets up a function it'll call anytime you wanna change it
        //this will create a listener for age to change
        public bool IsTeenager => Age < 20 && Age > 12;
        public bool IsDrinkingAge => Age >= 21;

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
