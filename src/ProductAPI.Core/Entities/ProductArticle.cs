using ProductAPI.Core.Common;

namespace ProductAPI.Core.Entities
{
    public class ProductArticle : BaseAuditableEntity
    {
        public string ArticleName { get; set; }
        public Guid ColourId { get; set; }
        public string    ColourCode { get; set; }
        public string ColourName { get; set; }
    }
}
