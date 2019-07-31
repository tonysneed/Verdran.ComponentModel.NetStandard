using ClassLibrary2;
using Newtonsoft.Json;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = JsonConvert.SerializeObject(new Foo { Id = 1 });
            Console.WriteLine(json);
        }
    }
}
