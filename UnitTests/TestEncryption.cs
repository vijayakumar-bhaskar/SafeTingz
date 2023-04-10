using NUnit.Framework;
using SafeTingz;

namespace UnitTests
{
    [TestFixture]
    public class TestEncryption
    {

        [Test]
        public void TestEncryptionFunction()
        {
            Encryption encryptor = new Encryption();
            encryptor.Encrypt("abcd",1);
            Assert.AreEqual(encryptor.EncryptedData, "bcde");
        }
        
    }
}