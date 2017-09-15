using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseObjectInit.Framework;
using System.Threading;

namespace RegistrationUsePageObject.Framework
{
    class Utils : BaseObject
    {
        public static int seed = Environment.TickCount;
        public static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
        new Random(Interlocked.Increment(ref seed)));
    }
}
