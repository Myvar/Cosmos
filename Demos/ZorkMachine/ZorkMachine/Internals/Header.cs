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
        public byte Flags1 { get; set; }

        //flags 1
        public bool StatuslineType { get; set; }
        public bool MultipleDisks { get; set; }
        public bool StatusLineNot { get; set; }
        public bool ScreenSplitting { get; set; }
        public bool variablePitch { get; set; }

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
            BitArray flags = new BitArray(zs.ReadByte());
            StatuslineType = flags[1];
            MultipleDisks = flags[2];
            StatusLineNot = flags[4];
            ScreenSplitting = flags[5];
            variablePitch = flags[6];
        }
    }
}
