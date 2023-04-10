namespace SafeTingz
{
    using System;
    using System.Text;
    public class Encryption : IEncryption
    {
        public string EncryptedData;
        public Encryption()
        {
            //Empty Constructor
        }

        public void Encrypt(string data,int offset)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                char eachChar = data[i];
                sb.Append((char)((offset + eachChar) % 255));
            }

            EncryptedData = sb.ToString();
        }
    }
}