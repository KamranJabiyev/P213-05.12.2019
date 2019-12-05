using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Animal
    {
        protected internal string name;
    }

    internal class Bird : Animal { }

    internal class Eagle : Bird { }
}
