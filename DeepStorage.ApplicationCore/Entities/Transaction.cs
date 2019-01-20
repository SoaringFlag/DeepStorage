using System;

namespace DeepStorage.ApplicationCore.Entities
{
    public class Transaction : BaseEntity
    {
        public DateTime CreatedDateTime { get; set; }

        public DateTime LastModifiedDateTime { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }

        public decimal Amount { get; set; }

        public long AmountTypeId { get; set; }

        public AmountType AmountType { get; set; }
    }
}
