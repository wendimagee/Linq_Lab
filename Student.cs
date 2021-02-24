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
        //when you set a lambda on a variable, it sets upa function itll call anytime you wanna change it
        //this will create a listener for age to change

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
