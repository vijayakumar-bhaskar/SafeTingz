using System.IO;
using System.Reflection;
using NUnit.Framework;
using SafeTingz;

namespace UnitTests
{
    [TestFixture]
    public class TestFileIo
    {
        [Test]
        public void TestReadFile()
        {
            FileIO fileIo = new FileIO();
            fileIo._filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"/../../TestDocuments/MiniTestFile.txt";
            fileIo.ReadFile();
            Assert.NotNull(fileIo.Data);
        }
    }
}