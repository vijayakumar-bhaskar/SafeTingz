namespace SafeTingz
{
    using System;
    using System.IO;
    public class UserCredentials : IUserCredentials
    {
        public byte Offset;

        public UserCredentials()
        {
            //Empty constructor
        }

        public void GetCredentials()
        {
            Console.WriteLine("Please enter the offset: ");
            Offset = Convert.ToByte(Console.ReadLine());
            

        }
    }
}