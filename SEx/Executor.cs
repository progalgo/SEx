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
        public State State { get; private set; } = new State();

        public Ruleset Ruleset { get; }

        public TransitionFunc TransitionFunc { get { return Ruleset; } }

        public void Step()
        {
            State = TransitionFunc(State);
        }

        public void Run()
        {
            while (true)
            {
                State = TransitionFunc(State);
            }
        }
    }
}
