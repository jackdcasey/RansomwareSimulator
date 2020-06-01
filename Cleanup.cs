using System;
using System.IO;
using System.Linq;

namespace RansomwareSimulator
{
    class Cleanup
    {
        public static void Clean(string directory, string directoryPattern)
        {
            Console.WriteLine("Starting cleanup");

            string[] directoriesToClean = Directory.EnumerateDirectories(directory, directoryPattern).ToArray();

            int len = directoriesToClean.Length;
            Console.WriteLine($"{len} {(len == 1 ? "directory" : "directories")} to remove");

            foreach (string dir in directoriesToClean)
            {
                Console.WriteLine($"Removing {dir}");
                Directory.Delete(dir, true);
            }

            Console.WriteLine("Cleanup complete");
        }

        public static void DeleteParentDirectory(string file)
        {
            string directory = Path.GetDirectoryName(file);

            Console.WriteLine($"Removing {directory}");

            Directory.Delete(directory, true);
        }
    }
}
