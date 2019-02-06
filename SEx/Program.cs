using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Executor executor = new Executor();
            Tracer tracer = new Tracer();
            executor.StateChanged += tracer;

            executor.Step();
            executor.Step();
            executor.Step();
            executor.Step();

        }
    }
}
