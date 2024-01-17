using System;
using System.Collections.Generic;

namespace SEx
{
    using TransitionFunc = Func<State, State>;

    class Ruleset
    {
        readonly Dictionary<int, TransitionFunc> rules = new()
        {
            { 1, (a) => { return new State { Count = a.Count + 1, Switch = 2 }; } },
            { 2, (a) => { return new State { Count = a.Count - 1, Switch = 1 }; } }
        };

        public TransitionFunc GetFunc()
        {
            return (a) => { return rules[a.Switch](a); };
        }

        public static implicit operator TransitionFunc(Ruleset ruleset)
        {
            return ruleset.GetFunc();
        }
    }
}
