using System.Collections.Generic;
using System.Xml.Linq;
using VisitorMethodDesignPattern;

List<IDocumentElement> elements = new List<IDocumentElement> { new Paragraph(), new Table() };

IVisitor renderVisitor = new RenderVisitor();
IVisitor wordCountVisitor = new WordCountVisitor();

foreach (var element in elements)
{
    element.Accept(renderVisitor);
    element.Accept(wordCountVisitor);
}