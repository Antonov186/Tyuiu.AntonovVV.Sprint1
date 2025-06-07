using Tyuiu.AntonovVV.Sprint1.Task3.V7.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double verst = 100;
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(106.68, res);
        }
    }
}