using ClassRoom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectStuderende
{
    [TestClass]
    public class UnitTestStuderende
    {
        [DataTestMethod]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void TestMethodStuderende≈rstidVinter(int value)
        {
            //Arrenage
            studerende studerende = new studerende("test", value, 1);

            //Act
            string Ârstid = studerende.≈rstid();

            //Assert
            Assert.AreEqual("Vinter", Ârstid);
        }

        
    }
}
