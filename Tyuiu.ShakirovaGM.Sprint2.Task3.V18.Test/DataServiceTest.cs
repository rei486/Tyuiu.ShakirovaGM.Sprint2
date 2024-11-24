using Tyuiu.ShakirovaGM.Sprint2.Task3.V18.Lib;
namespace Tyuiu.ShakirovaGM.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
           
            double res = ds.Calculate(x);
            double wait = 36;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;

            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -6;

            double res = ds.Calculate(x);
            double wait = 0.848;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -25;

            double res = ds.Calculate(x);
            double wait = -274.96;
            Assert.AreEqual(wait, res);
        }
    }
}