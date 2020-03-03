namespace lei200409681.Models.ApplicationModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_Number { get; set; }

        public int? Customer_ID { get; set; }

        [StringLength(50)]
        public string Customer_Name { get; set; }

        public int? Sale { get; set; }
    }
}
