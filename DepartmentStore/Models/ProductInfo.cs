namespace DepartmentStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductInfo")]
    public partial class ProductInfo
    {
        [Key]
        [Column(Order = 0)]
        public int product_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shop_id { get; set; }

        public virtual ShopInfo ShopInfo { get; set; }
    }
}
