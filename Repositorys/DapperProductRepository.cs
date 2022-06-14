using System.Collections.Generic;
using System.Data;
using Dapper;
using dapper_core_lab.Models;

namespace dapper_core_lab.Repositorys
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public DapperProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public void Create(Product product)
        {
            _conn.Execute(@"
                INSERT INTO Products ([Name], Price)
                VALUES (@Name, @Price)
            ", product);
        }

        public void Delete(int id)
        {
            _conn.Execute(@"
                DELETE FROM Products
                WHERE Id=@id
            ", new { id });
        }

        public IEnumerable<Product> GetAll()
        {
            return _conn.Query<Product>("SELECT * FROM Products");
        }

        public Product GetById(int id)
        {
            return _conn.QueryFirstOrDefault<Product>("SELECT TOP 1 * FROM Products WHERE Id=@id", new { id });
        }

        public void Update(Product product)
        {
            _conn.Execute(@"
                UPDATE Products
                SET Name=@Name, Price=@Price
                WHERE Id=@Id
            ", product);
        }
    }
}