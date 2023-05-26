using System;
using System.IO;


namespace FilesRenamer
{

    class Program
    {

        static void Main(string[] args)
        {
            string path = args[0];//"c:\"
            string pattern = args[1];//@"*.cs.txt";
            string textToReplace = args[2]; //@".cs.txt";
            string replacement = args[3];//".cs";

            RenameFiles(path, pattern, textToReplace, replacement);
            Console.ReadKey();
        }

        static void RenameFiles(string path, string pattern, string textToReplace, string replacement)
        {
            string[] files = Directory.GetFiles(path, pattern, SearchOption.AllDirectories);
            foreach (var file in files)
            {
                string destPath = file.Replace(textToReplace, replacement);
                File.Move(file, destPath);
                Console.WriteLine(destPath);
            }

        }


    }


}