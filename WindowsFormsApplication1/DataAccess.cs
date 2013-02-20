using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WindowsFormsApplication1
{
    public static class DataAccess
    {

        public static void LongRunningCall(string test)
        {
            Thread.Sleep(10000);
            throw (new Exception("hi"));
        }
    }
}
