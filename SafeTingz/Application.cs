namespace SafeTingz
{
    using System;
    internal class Application
    {
        public static void Main(string[] args)
        {
            FileIO fileParser = new FileIO();
            fileParser.GetFilePathFromUser();
            fileParser.ReadFile();
            Console.WriteLine(fileParser.Data);
        }
    }
}