using System;
using System.Text;
//using Test;
//using Test1;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //System.Text.StringBuilder stringBuilder1 = new System.Text.StringBuilder();

            //Test.Person person = new Test.Person();
            //Animal animal = new Animal();
            //Bird bird = new Bird();
            //Eagle eagle = new Eagle();

            Developer dev = new Developer();
            Person p = new Person();
            p.Name = "Memmed";
            p.Surname = "Necefov";
            p.setEmail("memmed90@gmail.com");
            p.setPassword("MemmedYek");
            p.Age = 12;

            Animal animal = new Animal();

            Console.WriteLine(p.getFullInfo());

            //Console.WriteLine(p.CheckPassword("MemmedYek"));

        }
    }

}
