using System.ComponentModel.DataAnnotations.Schema;

namespace dapper_core_lab.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        [Column(TypeName="decimal(18,0)")]
        public decimal Price { get; set; }
    }
}