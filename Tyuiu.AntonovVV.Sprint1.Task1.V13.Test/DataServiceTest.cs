using Tyuiu.AntonovVV.Sprint1.Task1.V13.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}