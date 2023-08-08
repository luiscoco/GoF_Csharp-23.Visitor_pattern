# GoF_Csharp-23.Visitor_pattern

The Visitor Pattern is a behavioral design pattern that allows you to define new operations to be performed on the elements of a class hierarchy without
changing the classes themselves. It's a way to separate the algorithm from the objects it operates on.

In simpler terms, imagine you have a set of different classes representing shapes (e.g., Circle, Square, Triangle), and you want to add a new operation
(e.g., calculate area) to each shape without modifying the shape classes. The Visitor Pattern would enable you to achieve this by defining a visitor
interface with methods for each shape type and implementing those methods for the specific operations you want to perform.

```csharp
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
```

## How to setup Github actions

![Csharp Github actions](https://github.com/luiscoco/GoF_Csharp-16.Iterator_pattern/assets/32194879/1263a83b-d11c-4a48-ad5c-c22eecd42836)


