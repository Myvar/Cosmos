using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkMachine.Internals
{
    public class StoryFile
    {
        #region Static    
        public static StoryFile Read(byte[] raw)
        {
            return new StoryFile(raw);
        }

        public static StoryFile Read(string file)
        {
            return Read(File.ReadAllBytes(file));
        }
        #endregion

        public byte[] rawData { get; set; }

        public Header Header { get; set; }
        public List<iast> OpCodes { get; set; }


        public StoryFile(byte[] raw)
        {
            rawData = raw;
            Header = new Header(raw);
        }

        public override string ToString()
        {
            return "Vertion: " + Header.Vertion
                + "\n" + "StatuslineType:" + BoolToString(Header.StatuslineType)
                + "\n" + "MultipleDisks:" + BoolToString(Header.MultipleDisks)
                + "\n" + "StatusLineNot:" + BoolToString(Header.StatusLineNot)
                + "\n" + "ScreenSplitting:" + BoolToString(Header.ScreenSplitting)
                + "\n" + "variablePitch:" + BoolToString(Header.variablePitch);
        }

        private string BoolToString(bool b)
        {
            return b ? "True" : "False";
        }
    }
}
