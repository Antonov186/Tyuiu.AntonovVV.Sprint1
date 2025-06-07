using Tyuiu.AntonovVV.Sprint1.Task0.V29.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(32, res);
        }
    }
}