using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkMachine.Internals.Opcodes
{
    public class Call : Opcode
    {
        public override bool IsMe(byte a)
        {
            return a == 224;
        }

        public override Opcode Parse(ZorkStream z)
        {
            var re = new Call();

            return re;
        }
    }
}
