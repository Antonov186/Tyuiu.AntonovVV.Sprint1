using Tyuiu.AntonovVV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 3, x2 = 6, y1 = 2, y2 = 6;
            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int wait = 5;

            Assert.AreEqual(res, wait);
        }
    }
}