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

            Console.WriteLine("Test File: Minizork");
            Console.WriteLine("File Info:");

            StoryFile f = new StoryFile(new byte[] { 0X03, 0X00, 0X02 });
            Console.WriteLine(f.ToString());
                       
        }

        protected override void Run()
        {
            
        }
    }
}
