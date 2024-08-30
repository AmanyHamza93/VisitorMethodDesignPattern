using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorMethodDesignPattern
{
    public class Paragraph : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitParagraph(this);
        }
    }
}
