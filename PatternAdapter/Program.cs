using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // объект, который нужно использовать
            Adaptee adaptee = new Adaptee();
            // адаптер, через который идет работа с объектом
            Adapter adapter = new Adapter(adaptee);

            Console.WriteLine(adapter.SomeMethod());
        }
    }
}
