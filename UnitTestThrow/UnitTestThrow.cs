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
            studerende studerende = new studerende("F�dselsm�ned", 13,1);
            
            //Act
            string �rstid = studerende.�rstid();

            //Assert
            Assert.Fail();
        }
    }
}
