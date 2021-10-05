using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SEx
{
    public struct State : IEquatable<State>
    {
        public int Count { get; set; }
        public int Switch { get; set; }

        public override bool Equals(object obj)
        {
            return obj is State state && Equals(state);
        }

        public bool Equals(State other)
        {
            return Count == other.Count &&
                   Switch == other.Switch;
        }

        public override int GetHashCode()
        {
            var hashCode = -703402107;
            hashCode = hashCode * -1521134295 + Count.GetHashCode();
            hashCode = hashCode * -1521134295 + Switch.GetHashCode();
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

        public override string ToString()
        {
            Type myType = GetType();
            var obj = this;
            var props = myType.GetProperties();

            object val(PropertyInfo info)
            {
                return new KeyValuePair<string, object>(info.Name, info.GetValue(obj));
            }

            return string.Join(", ", props.Select(val));
        }
    }
}
