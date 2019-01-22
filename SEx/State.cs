using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEx
{
    struct State : IEquatable<State>
    {
        public int count;
        public int @switch;

        public override bool Equals(object obj)
        {
            return obj is State && Equals((State)obj);
        }

        public bool Equals(State other)
        {
            return count == other.count &&
                   @switch == other.@switch;
        }

        public override int GetHashCode()
        {
            var hashCode = -703402107;
            hashCode = hashCode * -1521134295 + count.GetHashCode();
            hashCode = hashCode * -1521134295 + @switch.GetHashCode();
            return hashCode;
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
