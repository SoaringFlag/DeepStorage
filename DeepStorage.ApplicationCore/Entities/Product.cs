namespace DeepStorage.ApplicationCore.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public long ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }
    }
}
