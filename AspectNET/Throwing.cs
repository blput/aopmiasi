using NConcern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AspectNET
{
    public class ThrowingTesting : IAspect
    {
        public IEnumerable<IAdvice> Advise(MethodBase method)
        {
            yield return Advice.Basic.After().Throwing(()=>Console.WriteLine("Obsluga wyjatku z aspektu"));
        }
    }
}
