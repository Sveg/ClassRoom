using ClassRoom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestThrow
{
    [TestClass]
    public class UnitTestThrow
    {
        [TestMethod]
        public void TestMethodThrow()
        {
            //Arrange
            studerende studerende = new studerende("Fødselsmåned", 13,1);
            
            //Act
            string årstid = studerende.Årstid();

            //Assert
            Assert.Fail();
        }
    }
}
