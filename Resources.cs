using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.FileProviders;

namespace RansomwareSimulator
{
   static class Resources
   {
       public static Stream GetStream(string filename)
       {
           string sourceFile = String.Concat("static.", filename);

           var embeddedProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly());
           return embeddedProvider.GetFileInfo(sourceFile).CreateReadStream();
       }
   }
}
