using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeFactory.Classes
{
    class StudentFactory
    {
        public static Document CreateDocument(string documentType)
        {
            Console.WriteLine($"Starts frantically writing");
            Document document = null;
            switch (documentType.ToLower())
            {
                case "due soon":
                    document = new Report();
                    document.Introduction = "Eye report";
                    document.Content = "Eyes are made of cells";
                    document.Conclusion = "Eyes are cool";
                    break;
                case "graduate soon":
                    document = new Resume();
                    document.Introduction = "I'm graduating";
                    document.Content = "I have no work experience";
                    document.Conclusion = "I am in debt, give me money";
                    break;
                default:
                    break;
            }
            return document;
        }
    }
}
