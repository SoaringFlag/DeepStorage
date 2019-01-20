using System;

namespace DeepStorage.ApplicationCore.Entities
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; }

        public long? SubTypeId { get; set; }

        public ProductType SubType { get; set; }
    }
}
