using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

//            InvokeDoWork();
//            Console.ReadLine();
        }

        static void InvokeDoWork()
        {
            var msg = DoWork();
            Console.WriteLine(msg);
        }

        [DllImport("InvokableLib.dll", EntryPoint = "GetString")]
        static extern string DoWork();
    }
}
