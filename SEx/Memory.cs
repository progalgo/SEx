namespace SEx
{
    class Memory(uint size)
    {
        private readonly byte[] bytes = new byte[size];

        public byte? Read(uint address)
        {
            return address < bytes.Length ? bytes[address] : null;
        }
    }
}
