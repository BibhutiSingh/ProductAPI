using ProductAPI.Core.Common;
using System;

namespace ProductAPI.Core.Entities
{
    public class Product : BaseAuditableEntity
    {
        public string ProductName { get; set; }
        public int ProductYear { get; set; }
        public int ChannelId { get; set; }
        public Guid SizeScaleId { get; set; }


    }
}
