using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Proxy.HelloProxy();
            var result = p.GetGreeting();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
