using ProductAPI.Core.Common;

namespace ProductAPI.Core.Entities
{
    internal class Article : BaseAuditableEntity
    {
        public Guid ColourId { get; set; }
    }
}
