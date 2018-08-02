using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeFactory.Classes
{
    class Student : Author
    {
        protected override Document WriteDocument(string type)
        {
            Console.WriteLine("I need to do this.");
            Console.WriteLine("My life depends on it.");
            return StudentFactory.CreateDocument(type);
        }
    }
}
