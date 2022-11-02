﻿using System;

namespace ProductAPI.Core.Common
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime? CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }
    }
}
    