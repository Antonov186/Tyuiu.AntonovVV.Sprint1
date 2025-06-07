using Tyuiu.AntonovVV.Sprint1.Task7.V11.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double wait = 1.751;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}