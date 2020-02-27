using System;
using System.IO;

namespace RansomwareSimulator
{
    static class Paths
    {
        public static string Desktop
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop); }
        }
        public static string TestFolder
        {
            get { return Path.Combine(Desktop, String.Concat( TestFolderRoot, DateTime.Now.ToString("s").Replace(":", String.Empty).Replace("-", String.Empty))); }
        }

        public static string TestFolderRoot
        {
            get { return "RansomwareSimulator"; }
        }
    }
}
