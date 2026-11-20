
using Microsoft.Data.SqlClient;
using SmartInventory.Models;
using System.Data;

namespace SmartInventory.Data
{
    public class ProductRepository
    {
        private readonly SqlConnectionFactory _connectionFactory;

        public ProductRepository(SqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        // READ: Get all products
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection con = _connectionFactory.CreateConnection())
            {
                string query = "SELECT * FROM Products";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductID = Convert.ToInt32(reader["ProductID"]),
                                ProductName = reader["ProductName"].ToString()!,
                                Category = reader["Category"].ToString()!,
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                Price = Convert.ToDecimal(reader["Price"])
                            });
                        }
                    }
                }
            }

            return products;
        }

        // CREATE: Add a new product
        public void AddProduct(Product product)
        {
            using (SqlConnection con = _connectionFactory.CreateConnection())
            {
                string query = @"INSERT INTO Products
                                (ProductName, Category, Quantity, Price)
                                VALUES
                                (@ProductName, @Category, @Quantity, @Price)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ProductName", SqlDbType.VarChar, 100).Value = product.ProductName;
                    cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = product.Category;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = product.Quantity;
                    cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // UPDATE: Edit an existing product
        public void UpdateProduct(Product product)
        {
            using (SqlConnection con = _connectionFactory.CreateConnection())
            {
                string query = @"UPDATE Products SET
                                ProductName = @ProductName,
                                Category = @Category,
                                Quantity = @Quantity,
                                Price = @Price
                                WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = product.ProductID;
                    cmd.Parameters.Add("@ProductName", SqlDbType.VarChar, 100).Value = product.ProductName;
                    cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = product.Category;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = product.Quantity;

                    SqlParameter priceParameter = cmd.Parameters.Add("@Price", SqlDbType.Decimal);
                    priceParameter.Precision = 10;
                    priceParameter.Scale = 2;
                    priceParameter.Value = product.Price;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE: Remove a product
        public void DeleteProduct(int id)
        {
            using (SqlConnection con = _connectionFactory.CreateConnection())
            {
                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = id;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // READ: Get a single product by ID
        public Product? GetProductById(int id)
        {
            using (SqlConnection con = _connectionFactory.CreateConnection())
            {
                string query = "SELECT * FROM Products WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = id;

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                ProductID = Convert.ToInt32(reader["ProductID"]),
                                ProductName = reader["ProductName"].ToString()!,
                                Category = reader["Category"].ToString()!,
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                Price = Convert.ToDecimal(reader["Price"])
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
