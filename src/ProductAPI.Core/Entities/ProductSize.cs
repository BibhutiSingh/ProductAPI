using ProductAPI.Core.Common;
using System;

namespace ProductAPI.Core.Entities
{
    public class ProductSize: BaseAuditableEntity
    {
        public string SizeName { get; set; }
    }
}
