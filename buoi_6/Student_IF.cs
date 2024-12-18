namespace buoi_6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_IF
    {
        [StringLength(50)]
        public string Student_Name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Student_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        public int? Class_ID { get; set; }

        public bool Gender { get; set; }

        public virtual CLass CLass { get; set; }
    }
}
