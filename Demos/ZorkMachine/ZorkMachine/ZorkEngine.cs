using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorkMachine.Internals;

namespace ZorkMachine
{
    public class ZorkEngine
    {
        //public
        public byte[] Memmory;
        public byte[] Stack;

        //private
        private int _MemmorySize = 30 * 1000;
        private int _StackSize = 100 * 1000;

        private StoryFile _sf;

        public ZorkEngine()
        {
            Memmory = new byte[_MemmorySize];
            Stack = new byte[_StackSize];
        }

        public void Execute(byte[] zorkFile)
        {
            Reset();
            _sf = StoryFile.Read(zorkFile);
            LoadStoryFile(_sf);
            Resolve(_sf.OpCodes);
        }

        public void Reset()
        {

        }

        private void LoadStoryFile(StoryFile f)
        {

        }

        private void Resolve(List<iast> Ops)
        {

        }

    }
}
