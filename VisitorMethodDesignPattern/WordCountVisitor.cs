using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorMethodDesignPattern
{
    public class WordCountVisitor : IVisitor
    {
        public void VisitParagraph(Paragraph paragraph)
        {
            Console.WriteLine("Counting words in Paragraph");
        }

        public void VisitTable(Table table)
        {
            Console.WriteLine("Counting words in Table");
        }
    }
}
