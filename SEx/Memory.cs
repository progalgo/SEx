using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEx
{
    class Memory
    {
        readonly byte[] bytes;

        public Memory(uint size)
        {
            bytes = new byte[size];
        }

        public byte? Read(uint address)
        {
            return address < bytes.Length ? bytes[address] : (byte?)null;
        }
    }
}
