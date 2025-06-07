using Tyuiu.AntonovVV.Sprint1.Task6.V12.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool result = ds.CheckLastWordRepetiton("Ýòî òåñò òåñò");
            Assert.IsTrue(result);
        }
    }
}