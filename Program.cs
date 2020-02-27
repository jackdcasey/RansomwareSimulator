using System;
using System.Text;
using System.Linq;

namespace RansomwareSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            byte[] introBytes = Resources.GetStream("intro.txt").ToByteArray();
            string intro = Encoding.UTF8.GetString(introBytes, 0, introBytes.Length);

            Console.Clear();
            Console.WriteLine(intro);

            while (run)
            {
                Console.WriteLine();
                Console.WriteLine("Please select an option:");
                Console.WriteLine();

                Console.WriteLine("1: Run simulation");
                Console.WriteLine("2: Clean up old simulations");
                Console.WriteLine("3: Exit");

                Console.WriteLine();

                ConsoleKeyInfo consoleKey = Console.ReadKey(true);

                Console.WriteLine();
                Console.WriteLine();

                switch (consoleKey.KeyChar)
                {
                    case ('1'):
                        try
                        {
                            var createdFiles = FileGenerator.GenerateFiles(Paths.TestFolder, "SourcePDF.pdf", "TestFile", 15).Result;

                            var encryptedFiles = FileEncryptor.EncryptFiles(createdFiles).Result;

                            Cleanup.DeleteParentDirectory(encryptedFiles.First());

                            Console.WriteLine("Completed!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exception during test: \n\n{ex.Message}");
                            Console.WriteLine();
                            Console.WriteLine(ex.StackTrace);
                        }
                        break;

                    case ('2'):
                        try
                        {
                            Cleanup.Clean(Paths.Desktop, String.Concat(Paths.TestFolderRoot, "*"));

                            Console.WriteLine("Completed!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exception during cleanup: \n\n{ex.Message}");
                            Console.WriteLine();
                            Console.WriteLine(ex.StackTrace);
                        }
                        break;

                    case ('3'):
                        Console.WriteLine("Exiting");
                        run = false;
                        break;
                }
            }
        }
    }
}
