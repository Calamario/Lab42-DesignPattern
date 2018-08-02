using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeFactory.Classes
{
    public class DocumentFactory
    {
        public Document CreateDocument(string documentType)
        {
            Document document = null;
            switch (documentType.ToLower())
            {
                case "resume":
                    document = new Resume();
                    break;
                case "report":
                    document = new Report();
                    break;
                default:
                    break;
            }
            return document;
        }
    }
}
