using Tyuiu.ShakirovaGM.Sprint2.Task6.V4.Lib;
namespace Tyuiu.ShakirovaGM.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            Assert.AreEqual("����", ds.FindCardSuit(1));
            Assert.AreEqual("�����", ds.FindCardSuit(2));
            Assert.AreEqual("�����", ds.FindCardSuit(3));
            Assert.AreEqual("�����", ds.FindCardSuit(4));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(5);
            });
        }
    }
}