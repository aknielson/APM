﻿using System;
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
        
        public IEnumerable<Product> Get(string search)
        {
            var productRepository = new ProductRepository();
            var retVal = productRepository.Retrieve().Where(pr => pr.ProductCode.Contains(search));
            return retVal;
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
