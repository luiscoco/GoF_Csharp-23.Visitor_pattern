using System;

// Client code
class Program
{
    static void Main(string[] args)
    {
        var shapes = new IShape[] { new Circle(), new Square() };
        var areaVisitor = new AreaVisitor();

        foreach (var shape in shapes)
        {
            shape.Accept(areaVisitor);
        }
    }
}

// Shape hierarchy
interface IShape
{
    void Accept(IVisitor visitor);
}

class Circle : IShape
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitCircle(this);
    }
}

class Square : IShape
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitSquare(this);
    }
}

// Visitor interface
interface IVisitor
{
    void VisitCircle(Circle circle);
    void VisitSquare(Square square);
}

// Concrete visitor implementation
class AreaVisitor : IVisitor
{
    public void VisitCircle(Circle circle)
    {
        Console.WriteLine("Calculating area of Circle");
    }

    public void VisitSquare(Square square)
    {
        Console.WriteLine("Calculating area of Square");
    }
}

