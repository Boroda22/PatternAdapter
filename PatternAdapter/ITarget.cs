using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    /// <summary>
    /// Целевой класс объявляет интерфейс, с которым может работать клиентский код.
    /// </summary>
    public interface ITarget
    {
        string SomeMethod();
    }
}
