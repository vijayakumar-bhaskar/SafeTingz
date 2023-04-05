namespace SafeTingz
{
    using System;
    using System.IO;
    public class FileIO : IFileIO
    {
        public string _filePath;
        public string Data;

        public FileIO()
        {
            // empty constructor
        }

        public void GetFilePathFromUser()
        {
            Console.WriteLine("Please enter the text file path: ");
            _filePath = Console.ReadLine();
        }

        public void ReadFile()
        {
            try
            {
                using (StreamReader sr = File.OpenText(_filePath))
                {
                    Data = File.ReadAllText(_filePath);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("File not found");
            }
            
        }
        
    }
}