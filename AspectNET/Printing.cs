using NConcern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AspectNET
{

    public class Printing : IAspect
    {
        public IEnumerable<IAdvice> Advise(MethodBase method)
        {
            yield return Advice.Basic.Before(() => Console.WriteLine(string.Format
                                           ("BEFORE Wywolanie metody: {0}", method.Name)));
        }
    }
}
