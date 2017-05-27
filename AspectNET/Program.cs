using NConcern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Aspect.Weave<Logging>(method => method.DeclaringType == typeof(ExampleClass));
            Aspect.Weave<Printing>(method => method.DeclaringType == typeof(ExampleClass));
            Aspect.Weave<ThrowingTesting>(method => method.DeclaringType == typeof(ExampleClass));
            ExampleClass p = new ExampleClass();


            
                p.Show("example");
            Console.WriteLine("Dalsza obsluga programu");



            Console.ReadKey();
        }
    }
}
