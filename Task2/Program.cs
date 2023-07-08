using Task2.Classes;

var point = new Point(4, 0);
var point1 = new Point(1, 0);
Console.WriteLine(point.Distance(point1));
Console.WriteLine(point.ToString());
var circle = new Circle(2, 0, 5);
var circle1 = new Circle(12, 0, 3);
circle1.SetCenterXY(10, 0);
Console.WriteLine(circle.Distance(circle1));
Console.WriteLine(circle1.ToString());