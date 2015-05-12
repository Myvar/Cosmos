using System;

namespace Emile.TestApp
{
    public unsafe static class ReallySimpleAllocator
    {
        public static int* MemStartlocation;
        public static int Length;

        private enum Flags
        {
            Allocated = 1,
            Free  = 2
        }

        private class Header
        {
            public int* PreviousBlockPointer { get; set; }
            public int* NextBlockPointer { get; set; }
            public int Size { get; set; }
            public Flags Flag { get; set; }
        }

        public static void Initialize(int* startAddress, int length)
        {
            MemStartlocation = startAddress;
            Length = length;
        }

        public static int* Allocate(int length)
        {
            int* ret = (int*)0;

            //get firstMetaData
            var b = BytesToInt(new byte[] { (byte)*MemStartlocation, (byte)*(MemStartlocation + 1), (byte)*(MemStartlocation + 2), (byte)*(MemStartlocation + 3) });

            //do we have at least one block
            if (b == 0)//no
            {
                int* loc = MemStartlocation + 16;//fist block
                WrightHeader(MemStartlocation, new Header() { NextBlockPointer = loc + length, PreviousBlockPointer = (int*)0, Size = length , Flag = Flags.Allocated});
                ret = loc;
            }
            else // yes
            {

            }

            return ret;
        }

     


        public static void Free(int* pointer)
        {
            throw new NotImplementedException();
        }

        private static byte[] IntToBytes(int x)
        {
            var bytes = new byte[4];
            bytes[0] = (byte)(x);
            bytes[1] = (byte)(x >> 8);
            bytes[2] = (byte)(x >> 16);
            bytes[3] = (byte)(x >> 24);
            return bytes;
        }

        private static int BytesToInt(byte[] bytes)
        {
            int x;
            x  = (bytes[0]);
            x += (bytes[1] << 8);
            x += (bytes[2] << 16);
            x += (bytes[3] << 24);
            return x;
        }

        private static void WrightHeader(int* loc, Header head)
        {
            //im just gona do this manualy to avoid confustion for now
            var next = IntToBytes((int)head.NextBlockPointer);
            var prev = IntToBytes((int)head.PreviousBlockPointer);
            var size = IntToBytes(head.Size);
            var flag = IntToBytes((int)head.Flag);

            //next
            *(loc) = next[0];
            *(loc + 1) = next[1];
            *(loc + 2) = next[2];
            *(loc + 3) = next[3];

            //prev
            *(loc + (1 * 4)) = prev[0];
            *(loc + (1 * 4) + 1) = prev[1];
            *(loc + (1 * 4) + 2) = prev[2];
            *(loc + (1 * 4) + 3) = prev[3];

            //size
            *(loc + (2 * 4)) = size[0];
            *(loc + (2 * 4) + 1) = size[1];
            *(loc + (2 * 4) + 2) = size[2];
            *(loc + (2 * 4) + 3) = size[3];

            //flag
            *(loc + (3 * 4)) = flag[0];
            *(loc + (3 * 4) + 1) = flag[1];
            *(loc + (3 * 4) + 2) = flag[2];
            *(loc + (3 * 4) + 3) = flag[3];

        }


    }



}
