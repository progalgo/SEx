using System;
using System.Collections.Generic;

namespace SEx
{
    using TransitionFunc = Func<State, State>;

    class Ruleset
    {
        readonly Dictionary<int, TransitionFunc> Rules = new Dictionary<int, TransitionFunc>
        {
            { 1, (a) => { return new State { count = a.count + 1 }; } },
            { 2, (a) => { return new State { count = a.count-1 }; } }
        };

        public TransitionFunc GetFunc()
        {
            return (a) => { return Rules[a.@switch](a); };
        }

        public static implicit operator TransitionFunc(Ruleset ruleset)
        {
            return ruleset.GetFunc();
        }
    }
}
