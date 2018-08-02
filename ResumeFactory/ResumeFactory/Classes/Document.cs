using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeFactory.Classes
{
    public class Document
    {
        public string Introduction { get; set; }
        public string Content { get; set; }
        public string Conclusion { get; set; }

        public void Write()
        {
            Console.WriteLine("Here is my document");
            Console.WriteLine(Introduction);
            Console.WriteLine(Content);
            Console.WriteLine(Conclusion);
        }
    }
}
