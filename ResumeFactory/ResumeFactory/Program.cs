using ResumeFactory.Classes;
using System;

namespace ResumeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            EndOfYear1();
            Console.WriteLine();
            EndOfYear4();
            Console.ReadLine();
        }

        static void EndOfYear1()
        {
            Document document = null;
            Student student = new Student();
            document = student.SendDocument("due soon");
        }
        static void EndOfYear4()
        {
            Document document = null;
            Student student = new Student();
            document = student.SendDocument("graduate soon");
        }
    }
}
