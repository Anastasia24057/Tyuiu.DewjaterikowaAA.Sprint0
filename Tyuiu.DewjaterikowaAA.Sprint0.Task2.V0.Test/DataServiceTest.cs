using Tyuiu.DewjaterikowaAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Настя";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Настя", res);
        }
    }
}
