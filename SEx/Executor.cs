using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEx
{
    using TransitionFunc = Func<State, State>;

    class Executor
    {
        public State State { get; private set; } = new State { Switch = 1 };

        public Ruleset Ruleset { get; } = new Ruleset();

        public TransitionFunc TransitionFunc { get { return Ruleset; } }

        public event EventHandler<EventArgs> StateChanged;

        public void Step()
        {
            State = TransitionFunc(State);
            StateChanged?.Invoke(this, new EventArgs());
        }

        public void Run()
        {
            while (true)
            {
                Step();
            }
        }
    }
}
