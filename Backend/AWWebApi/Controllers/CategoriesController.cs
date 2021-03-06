using AWBLL.Production;
using AWEntities.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AWWebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly ProductCategoryBll categoryBll;
        public CategoriesController()
        {
            categoryBll = new ProductCategoryBll();
        }
        // GET api/<controller>
        public List<ProductCategory> Get()
        {
            return categoryBll.Get();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}