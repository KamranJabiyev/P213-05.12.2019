using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary1
{
    class TestModify
    {
        Eagle e = new Eagle();
        Animal animal = new Animal();
        
        public void Test()
        {
            Console.WriteLine(animal.name);
        }
    }
}
