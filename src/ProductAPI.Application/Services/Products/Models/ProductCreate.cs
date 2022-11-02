using ProductAPI.Application.Common;
using ProductAPI.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Application.Services.Products.Models
{
    public class ProductCreate : BaseEntityMapper<Product>
    {
        public ProductCreate(Product Entity) : base(new Product())
        {
            Articles = new List<ProductCreate_Article>();
        }
        [Key]
        public Guid ProductId { get => BaseEntity.Id; set => BaseEntity.Id = value; }
        public string ProductName { get => BaseEntity.ProductName; set => BaseEntity.ProductName = value; }
        public int ProductYear { get => BaseEntity.ProductYear; set => BaseEntity.ProductYear = value; }
        public int ChannelId { get => BaseEntity.ChannelId; set => BaseEntity.ChannelId = value; }
        public Guid SizeScaleId { get => BaseEntity.SizeScaleId; set => BaseEntity.SizeScaleId = value; }

        public List<ProductCreate_Article> Articles { get; set; }


    }
    public class ProductCreate_Article{
        
        public Guid ArticleId { get; set; }
        public Guid ColorId { get; set; }
    }
}
