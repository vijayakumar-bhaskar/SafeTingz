namespace SafeTingz
{
    using System;
    using System.Text;
    public class Encryption
    {
        public string EncryptedData;
        public Encryption()
        {
            //Empty Constructor
        }

        public void Encrypt(string data,int offset)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char eachChar in data)
            {
                sb.Append((char)((offset + eachChar) % 255));
            }

            EncryptedData = sb.ToString();
        }
    }
}