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

            StoryFile f = new StoryFile(new byte[] { 0x03, 0X00, 0X00, 0X22, 0X37, 0X09, 0X37, 0Xd9, 0X28, 0X5a, 0X03, 0Xc6, 0X02, 0Xb4, 0X21, 0X87, 0X00, 0X00, 0X38, 0X37, 0X31, 0X31, 0X32, 0X34, 0X01, 0Xf4, 0X65, 0Xfc, 0Xd8, 0X70, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00, 0X00 });
            Console.WriteLine(f.ToString());
                       
        }

        protected override void Run()
        {
            
        }
    }
}
