using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkMachine.Internals
{
    public class Operand
    {
        public byte Operands_1 { get; set; }
        public byte Operands_2 { get; set; }
    }

    public abstract class Opcode
    {
        public byte Opcode_1 { get; set; }
        public byte Opcode_2 { get; set; }
        public byte TypesOperands_1 { get; set; }
        public byte TypesOperands_2 { get; set; }
        public Operand[] Operands { get; set; } = new Operand[8];
        public byte StoreVriable { get; set; }
        public byte BranchOffset_1 { get; set; }
        public byte BranchOffset_2 { get; set; }
        public string TextToPrint { get; set; }



        public abstract void IsMe();
        public abstract Opcode Parse();
    }


    /*
        All the Opcodes
    */

    //public class 
}
