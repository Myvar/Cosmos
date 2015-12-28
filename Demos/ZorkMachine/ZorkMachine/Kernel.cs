using System;
using System.Collections.Generic;
using System.Text;
using ZorkMachine.Internals;
using Sys = Cosmos.System;

namespace ZorkMachine
{
    public class Kernel : Sys.Kernel
    {
        public ZorkEngine ze = new ZorkEngine();

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("ZorkMachine");

            ZorkStream zs = new ZorkStream(new byte[] { 0X03, 0X20 });
            Console.WriteLine(zs.ReadShort());
        }

        protected override void Run()
        {
            
        }
    }
}
