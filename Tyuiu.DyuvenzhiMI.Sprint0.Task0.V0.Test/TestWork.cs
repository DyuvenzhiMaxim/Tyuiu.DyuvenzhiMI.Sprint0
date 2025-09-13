using Tyuiu.DyuvenzhiMI.Sprint0.Task0.V0.Lib;
namespace Tyuiu.DyuvenzhiMI.Sprint0.Task0.V0.Test
{
    [TestClass]
    public sealed class TestWork
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            int a = 5;
            int b = 6;

            int res = ClassWork.Add(a,b);

            Assert.AreEqual(11, res);
        }
    }
}
