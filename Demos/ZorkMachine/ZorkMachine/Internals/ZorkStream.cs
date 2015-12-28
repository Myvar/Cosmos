using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkMachine.Internals
{
    public  class ZorkStream
    {
        private List<byte> _buffer = new List<byte>();
        private int _index = -1;

        public ZorkStream(byte[] raw)
        {
            for (int i = 0; i < raw.Length; i++)
            {
                _buffer.Add(raw[i]);
            }
        } 

        public byte ReadByte()
        {
            _index++;
           return _buffer[_index];
        }

        public short ReadShort()
        {
            var a = ReadByte();
            var b = ReadByte();
            return (short)(b | (a << 8));
        }
    }
}
