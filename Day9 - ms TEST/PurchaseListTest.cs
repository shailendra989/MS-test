

namespace PurchaseListTest
{
    [TestClass]
    public class PurchaseListTest
    {
        [TestMethod]
        public void TestGetPriceSoldOnce()
        {
            // Arrange
            List<int> prices1 = new List<int> { 5, 5, 4, 7, 4, 1, 11 };
            List<int> prices2 = new List<int> { 10, 20, 30, 40, 50 };
            List<int> prices3 = new List<int> { 1, 2, 3, 1, 2, 3, 4 };
            List<int> prices4 = new List<int> { 1 };

            // Act
            int result1 = PurchaseList.GetPriceSoldOnce(prices1);
            int result2 = PurchaseList.GetPriceSoldOnce(prices2);
            int result3 = PurchaseList.GetPriceSoldOnce(prices3);
            int result4 = PurchaseList.GetPriceSoldOnce(prices4);

            // Assert
            Assert.AreEqual(result1, 7);
            Assert.AreEqual(result2, 10);
            Assert.AreEqual(result3, 4);
            Assert.AreEqual(result4, 1);
        }

        [TestMethod]
        public void TestGetPriceSoldMoreThanOnce()
        {
            // Arrange
            List<int> prices1 = new List<int> { 5, 5, 4, 7, 4, 1, 11 };
            List<int> prices2 = new List<int> { 10, 20, 30, 40, 50 };
            List<int> prices3 = new List<int> { 1, 2, 3, 1, 2, 3, 4 };
            List<int> prices4 = new List<int> { 1 };

            // Act
            int result1 = PurchaseList.GetPriceSoldMoreThanOnce(prices1);
            int result2 = PurchaseList.GetPriceSoldMoreThanOnce(prices2);
            int result3 = PurchaseList.GetPriceSoldMoreThanOnce(prices3);
            int result4 = PurchaseList.GetPriceSoldMoreThanOnce(prices4);

            // Assert
            Assert.AreEqual(result1, 5);
            Assert.AreEqual(result2, -1);
            Assert.AreEqual(result3, 1);
            Assert.AreEqual(result4, -1);
        }
    }
}
