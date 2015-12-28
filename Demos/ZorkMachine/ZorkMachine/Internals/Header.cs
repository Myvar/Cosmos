using System;
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

        //private
        private byte[] _raw;

        public Header(byte[] raw)
        {
            _raw = raw;
        }

        private void Parse()
        {

        }
    }
}
