using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeFactory.Classes
{
    public abstract class Author
    {
        protected abstract Document WriteDocument(string type);
        public Document SendDocument(string type)
        {
            Document document = WriteDocument(type);
            document.Write();
            return document;
        }
    }
}
