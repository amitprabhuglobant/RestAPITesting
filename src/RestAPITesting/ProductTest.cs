namespace RestAPITesting
{
    using NUnit.Framework;
    using RestClientLibrary;
    using RestClientLibrary.DTO;

    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void GetAllProductsTest()
        {
            var client = new ProductClient();
            var results = client.GetAllProducts();
            Assert.AreEqual(results.Count, 0);
        }

        [Test]
        public void GetProductsTest()
        {
            var client = new ProductClient();
            var results = client.GetProductsByID(1);            
            Assert.AreEqual(results.ProductID, 1);
        }
    }
}
