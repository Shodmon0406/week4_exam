using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Classes
{
    internal class MyList<T>
    {
        List<T> list = new List<T>();
        public void Add(T element)
        {
            list.Add(element);
            Console.WriteLine("Element added");
        }
        public void Delete(T element)
        {
            list.Remove(element);
            if (list.Remove(element))
            {
                Console.WriteLine("Element deleting");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
        public int Count => list.Count;
        public bool Contains(T element)
        {
            return list.Contains(element);
        }
        public void ToString()
        {
            int cnt = 0;
            foreach (var el in list)
            {
                cnt++;
                Console.Write(el);
                if (cnt < list.Count)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
