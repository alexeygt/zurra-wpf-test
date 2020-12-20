using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZurraTests
{
    [TestClass]
    public class FakeTest
    {
        [TestMethod]
        public void FakeTestMethodSuccess()
        {
            ConsoleOutput.Instance.WriteLine("This is a fake Zurra test that succeeds", OutputLevel.Information);
        }

        [TestMethod]
        public void FakeTestMethodFail()
        {
            ConsoleOutput.Instance.WriteLine("This is a fake Zurra test that fails for no reason", OutputLevel.Information);
            Assert.Fail("This is a fake Zurra test that fails");
        }
    }
}
