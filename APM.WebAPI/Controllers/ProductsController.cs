using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.OData;
using APM.WebAPI.Models;

namespace APM.WebAPI.Controllers
{
    [EnableCors("http://localhost:12978", "*", "*")]
    public class ProductsController : ApiController
    {
        [EnableQuery]
        // GET: api/Products
        public IQueryable Get()
        {
            var productRepository = new ProductRepository();
            return productRepository.Retrieve().AsQueryable();
        }
        
        //public IEnumerable<Product> Get(string search)
        //{
        //    var productRepository = new ProductRepository();
        //    var retVal = productRepository.Retrieve().Where(pr => pr.ProductCode.Contains(search));
        //    return retVal;
        //}

        // GET: api/Products/5
        public Product Get(int id)
        {
            Product product;
            var productRepository = new ProductRepository();

            if (id > 0)
            {
                //bad get all.. doing it because there isn't really a db
                var products = productRepository.Retrieve();
                product = products.FirstOrDefault(p => p.ProductId == id);
            }
            else
            {
                product = productRepository.Create();
            }
            return product;
        }

        // POST: api/Products
        public void Post([FromBody]Product product)
        {

            var productRepository = new ProductRepository();
            productRepository.Save(product);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]Product product)
        {
            var productRepository = new ProductRepository();
            productRepository.Save(1, product);
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
