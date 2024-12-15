using System.IO;


namespace SimpleFileIOApp
{
    internal class Program
    {

        static void WriteFile(string Filename) 
        {
            File.WriteAllText(Filename, "Hello World!");
        }

        static void ReadFile(string Filename) 
        {
            //File.ReadAllText(Filename);
            Console.WriteLine(File.ReadAllText(Filename));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to my simple fileIO practice app");

            string Filename = @"C:mydoc.txt";

            WriteFile(Filename);

            ReadFile(Filename);

            Console.Read();
        }
    }
}
