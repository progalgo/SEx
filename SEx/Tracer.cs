using System;

namespace SEx
{
    class Tracer
    {
        private static void WriteState(State state)
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
