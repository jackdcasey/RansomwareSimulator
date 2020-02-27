using System;
using System.IO;

namespace RansomwareSimulator
{
    public static class Extensions
    {
        public static byte[] ToByteArray(this Stream stream)
        {
            using (stream)
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                     stream.CopyTo(memStream);
                     return memStream.ToArray();
                }
            }
        }
    }
}
