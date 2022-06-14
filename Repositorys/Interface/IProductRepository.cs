using System.Collections.Generic;
using dapper_core_lab.Models;

namespace dapper_core_lab.Repositorys
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Update(Product product);
        void Delete(int id);

        Product GetById(int id);

        IEnumerable<Product> GetAll();
    }
}