using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkMachine.Internals
{
    public class Header
    {

        //public
        public short Vertion { get; set; }
        //flags 1
        public bool StatuslineType { get; set; }
        public bool MultipleDisks { get; set; }
        public bool StatusLineNot { get; set; }
        public bool ScreenSplitting { get; set; }
        public bool variablePitch { get; set; }

        public short HighMemory { get; set; }
        public short ProgramCounter { get; set; }

        //private
        private byte[] _raw;

        public Header(byte[] raw)
        {
            _raw = raw;
            Parse();
        }

        private void Parse()
        {
            ZorkStream zs = new ZorkStream(_raw);
            Vertion = zs.ReadShort();
            //flags 1
            var b = zs.ReadByte();
            StatuslineType = GetBit(b, 1);
            MultipleDisks = GetBit(b, 2);
            StatusLineNot = GetBit(b, 4);
            ScreenSplitting = GetBit(b, 5);
            variablePitch = GetBit(b, 6);
        }

        private bool GetBit(byte b , int bitNumber)
        {
           return (b & (1 << bitNumber - 1)) != 0;
        }
    }
}
