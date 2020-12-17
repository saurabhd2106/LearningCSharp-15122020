using LearningCSharp.Day3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearningMSTest
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.EngineSize = 7892374;
        }
    }
}
