using ProductAPI.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAPI.Application.Common
{
    public class BaseEntityMapper<T> where T: BaseAuditableEntity
    {
        T _baseEntity;
        public BaseEntityMapper(T Entity)
        {

            BaseEntity = Entity;

        }
        [NotMapped]
        public T BaseEntity
        {
            get
            { return _baseEntity; }
            private set { _baseEntity = value; }
        }
      
        public DateTime? CreatedOn { get => BaseEntity.CreatedOn; set => BaseEntity.CreatedOn = value; }
        public string CreatedBy { get => BaseEntity.CreatedBy; set => BaseEntity.CreatedBy = value; }
        public DateTime? UpdatedAt { get => BaseEntity.UpdatedOn; set => BaseEntity.CreatedOn = DateTime.Now; }
        public string UpdatedBy { get => BaseEntity.UpdatedBy; set => BaseEntity.UpdatedBy = value; }
    }
}
