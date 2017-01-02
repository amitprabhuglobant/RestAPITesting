using RestClientLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestClientLibrary
{
    public class ProductClient : BaseClient
    {
        public List<ProductDTO> GetAllProducts()
        {
            return new List<ProductDTO>();
        }

        public ProductDTO GetProductsByID(int ProductID)
        {
            var prod = new ProductDTO();
            prod.ProductID = ProductID;
            return prod;
        }

        public bool AddNewProduct(ProductDTO ProductItem)
        {
            return true;
        }

        public bool ModifyProduct(ProductDTO ProductItem)
        {
            return true;
        }

        public bool DeleteProduct(ProductDTO ProductItem)
        {
            return true;
        }
    }
}
