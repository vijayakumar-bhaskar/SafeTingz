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

            UserCredentials credentials = new UserCredentials();
            credentials.GetCredentials();
            Encryption encryption = new Encryption();
            encryption.Encrypt(fileParser.Data,credentials.Offset);
            Console.WriteLine(encryption.EncryptedData);
        }
    }
}