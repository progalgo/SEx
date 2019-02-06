using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEx
{
    class Tracer
    {
        private void WriteState(State state)
        {
            Console.WriteLine($"New state: {state}");
        }

        private void StateChangeEventHandler(object sender, EventArgs e)
        {
            if (sender is Executor executor)
            {
                WriteState(executor.State);
            }
        }

        public static implicit operator EventHandler<EventArgs>(Tracer tracer)
        {
            return tracer.StateChangeEventHandler;
        }
    }
}
