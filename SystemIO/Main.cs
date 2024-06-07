using System;
using System.IO; // Required for File and Directory classes

namespace SystemIO
{
    class FileOperations
    {
        static void Main(string[] args)
        {
            // _File Operations_
            string path = "filetest.txt";                   // Specify the path of the file

            /*
            // DELETE a file
            File.Delete(path);                          // Delete the file at the specified path

            // CREATE a file
            File.Create(path);                          // Create a file at the specified path

            // READ a file
            string content = File.ReadAllText(path);    // Read the content of the file at the specified path
            Console.WriteLine(content);                 // Write the content to the console

            // WRITE to a file
            string text = "Hello, World!";              // Specify the text to write to the file
            File.WriteAllText(path, text);              // Write the text to the file at the specified path
            Console.ReadKey();

            // APPEND to a file
            string newText = "Hello, again!";           // Specify the text to append to the file
            File.AppendAllText(path, newText);          // Append the text to the file at the specified path
            Console.ReadKey();

            // COPY a file
            string newPath = "test2.txt";               // Specify the path of the new file
            File.Copy(path, newPath);                   // Copy the file at the specified path to the new path

            // MOVE a file
            string movePath = "test3.txt";              // Specify the path of the new file
            File.Move(path, movePath);                  // Move the file at the specified path to the new path

            // CHECK if a file exists
            bool exists = File.Exists(path);            // Check if a file exists at the specified path
            Console.WriteLine(exists);                  // Write the result to the console

            // ...                                      // Other file operations
            */


            /* 
               Example of using several methods
               to check if a file exists and copy
               it to a new path.

               FileStream makes it possible to read
               and write to a file in a stream of
               bytes when the file is opened.

               Don't forget to Close() the file stream
               when it is no longer needed.
            */
            static void CopyOrCreateFile(string sourcePath, string destPath, string content)
            {
                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, destPath);
                    
                }
                else
                {
                    Console.WriteLine("File does not exist");
                    FileStream fs = File.Create(sourcePath);
                    fs.Close();
                    Console.WriteLine("Created file");
                    File.WriteAllText(sourcePath, content);
                }
            }
            //CopyOrCreateFile(path, "filetest2.txt", "Hello, World!");


            // _Folder Operations_

            string path2 = "testFolder";              // Specify the path of the folder
            string fileName = "test.txt";            // Specify the name of the file

            // CREATE a folder if it doesn't exist yet
            if (Directory.Exists(path2))
            {
                Console.WriteLine("Ordner existiert");
            }
            else
            {
                Directory.CreateDirectory(path2);
                Console.WriteLine("Ordner existierte nicht und wurde neu erstellt");
            }

            // GET files in a folder
            var filesInDir = Directory.GetFiles(path2);
            for (int i = 0; i < filesInDir.Length; i++)
            {
                Console.WriteLine(filesInDir[i]);
            }

            // GET folders in a folder
            var dirsInDir = Directory.GetFiles(path2);
            for (int i = 0; i < dirsInDir.Length; i++)
            {
                Console.WriteLine(dirsInDir[i]);
            }
        }
    }
}
