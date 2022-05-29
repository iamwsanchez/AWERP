using AWEntities.Production;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWDAL.Production
{
    public class ProductCategoryDB
    {
        public List<ProductCategory> Get()
        {
            List<ProductCategory> categories = new List<ProductCategory>();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AwConnectionString"].ConnectionString))
                {
                    //connection.Open();
                    SqlCommand command = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.Text,
                        CommandText = "SELECT * FROM Production.ProductCategory"
                    };
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    var query = from item in dt.AsEnumerable()
                                select new ProductCategory
                                {
                                    ProductCategoryID = Convert.ToInt32(item["ProductCategoryID"]),
                                    Name = Convert.ToString(item["Name"]),
                                    rowguid = new Guid(Convert.ToString(item["rowguid"])),
                                    ModifiedDate = Convert.ToDateTime(item["ModifiedDate"])
                                };
                    categories = query.ToList();
                }
            }
            catch(Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return categories;
        }
    }
}
