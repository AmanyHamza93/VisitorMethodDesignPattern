using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorMethodDesignPattern
{
    public interface IVisitor
    {
        void VisitParagraph(Paragraph paragraph);
        void VisitTable(Table table);
    }
}
