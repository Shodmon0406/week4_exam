using Task3.Classes;

var myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);
Console.WriteLine(myList.Count);
myList.Delete(4);
Console.WriteLine(myList.Contains(4));
myList.ToString();