using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace RansomwareSimulator
{
    static class FileGenerator
    {
        public static async Task<string[]> GenerateFiles(string directory, string sourceFile, string testFilename, int count)
        {
            List<string> createdFiles = new List<string>();

            byte[] fileBytes = Resources.GetStream(sourceFile).ToByteArray();

            Console.WriteLine($"Creating: {directory}");

            Directory.CreateDirectory(directory);

            string filenameExt = Path.GetExtension(sourceFile);

            for (int i = 0; i < count; i ++)
            {
                string newFile = String.Concat(testFilename, (i + 1).ToString("D4"), filenameExt);
                string newPath = Path.Combine(directory, newFile);

                Console.WriteLine($"Creating: {newPath}");

                await File.WriteAllBytesAsync(newPath, fileBytes);

                createdFiles.Add(newPath);
            }

            return createdFiles.ToArray();
        }
    }
}
