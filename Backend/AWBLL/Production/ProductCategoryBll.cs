using AWDAL.Production;
using AWEntities.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWBLL.Production
{
    public class ProductCategoryBll
    {
        private readonly ProductCategoryDB dbCategory;
        public ProductCategoryBll()
        {
            dbCategory = new ProductCategoryDB();
        }
        public List<ProductCategory> Get()
        {
            return dbCategory.Get();
        }
    }
}
