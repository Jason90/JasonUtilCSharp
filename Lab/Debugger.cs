using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab
{
    public class DebuggerLab
    {
        static void debuger()
        {
            Console.WriteLine("This message is readable by the end user.");
            Trace.WriteLine("This is a trace message when tracing the app.");
            Debug.WriteLine("This is a debug message just for developers.");
        }
    }
}