using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectNET
{
    public class ExampleClass
    {
        public void Show(String text)
        {
            Console.WriteLine("Metoda Show: AOP " + text);
            throw new Exception();
        }
    }
}
