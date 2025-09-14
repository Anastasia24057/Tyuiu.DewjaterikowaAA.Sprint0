using Tyuiu.DewjaterikowaAA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServiceTest.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
    }
}
