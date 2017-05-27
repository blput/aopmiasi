using NConcern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AspectNET
{
    public class Logging : IAspect
    {
        public IEnumerable<IAdvice> Advise(MethodBase method)
        {
            yield return Advice.Basic.After(() => Console.WriteLine(string.Format
                                               ("AFTER Wywolanie metody: {0}", method.Name)));
        }
    }
}
