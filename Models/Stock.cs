using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Stock
    {
        public int Id
        {
            get;
            set;
        }

        public string Symbol { get; set; } = null!;
        public string CompanyName { get; set; } = null!;

        public string MyProperty { get; set; } = null!;

        public decimal Purchase { get; set; }

        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = null!;

        public long MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}
