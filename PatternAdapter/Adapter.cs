using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    /// <summary>
    /// Адаптер делает интерфейс Адаптируемого класса совместимым с целевым интерфейсом.
    /// </summary>
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public string SomeMethod()
        {
            return _adaptee.SomeMethodFoo();
        }

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
    }
}
