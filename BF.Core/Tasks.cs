namespace BF.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tasks")]
    public partial class Tasks
    {
        public int ID { get; set; }

        [Column("Quote Type")]
        [Required]
        [StringLength(50)]
        public string Quote_Type { get; set; }

        [Column("Quote#")]
        public int? Quote_ { get; set; }

        [Column("Task")]
        [Required]
        [StringLength(100)]
        public string Task1 { get; set; }

        [Column("Due Date", TypeName = "date")]
        public DateTime Due_Date { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [Column("Task Type")]
        [Required]
        [StringLength(50)]
        public string Task_Type { get; set; }

        public int? Priority2 { get; set; }

        [Column("Secret Santa")]
        public string Secret_Santa { get; set; }
    }
}
