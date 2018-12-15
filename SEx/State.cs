using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEx
{
    struct State
    {
        public int count;
        public int @switch;

        public override bool Equals(object obj)
        {
            if (!(obj is State))
            {
                return false;
            }

            var state = (State)obj;
            return count == state.count;
        }

        public override int GetHashCode()
        {
            return 1110609940 + count.GetHashCode();
        }

        public static bool operator ==(State state1, State state2)
        {
            return state1.Equals(state2);
        }

        public static bool operator !=(State state1, State state2)
        {
            return !(state1 == state2);
        }
    }
}
