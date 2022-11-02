using ProductAPI.Core.Common;
using System;

namespace ProductAPI.Core.Entities
{
    public class Product : BaseAuditableEntity
    {
        public Product()
        {
            ProductArticles = new HashSet<ProductArticle>();
            ProductSizes=new HashSet<ProductSize>();
        }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int ProductYear { get; set; }
        public int ChannelId { get; set; }
        public Guid SizeScaleId { get; set; }

        public virtual ICollection<ProductArticle> ProductArticles { get; set; }
        public virtual ICollection<ProductSize> ProductSizes { get; set; }
    }
}
