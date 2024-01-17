using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SEx
{
    public struct State : IEquatable<State>
    {
        public int Count { get; set; }
        public int Switch { get; set; }

        public override readonly bool Equals(object obj)
        {
            return obj is State state && Equals(state);
        }

        public readonly bool Equals(State other)
        {
            return Count == other.Count &&
                   Switch == other.Switch;
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Count, Switch);
        }

        public static bool operator ==(State left, State right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(State left, State right)
        {
            return !(left == right);
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
