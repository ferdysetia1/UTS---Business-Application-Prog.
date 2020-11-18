namespace UTS_Business_Programming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodList")]
    public partial class FoodList
    {
        [Key]
        [StringLength(50)]
        public string Food_ID { get; set; }

        [StringLength(50)]
        public string Nama { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Qty { get; set; }

        [StringLength(50)]
        public string Harga { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Gambar { get; set; }
    }
}
