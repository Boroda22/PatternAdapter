using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    /// <summary>
    /// Адаптируемый класс, который нужно адаптировать для использования
    /// класс содержит некоторое полезное поведение, но его
    /// интерфейс несовместим  с существующим клиентским кодом. Адаптируемый
    /// класс нуждается в некоторой доработке,  прежде чем клиентский код сможет
    /// его использовать.
    /// </summary>
    class Adaptee
    {
        public string SomeMethodFoo()
        {
            return "Hi, I am a student";
        }
    }
}
