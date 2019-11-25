namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.planification")]
    public partial class planification
    {
        [Key]
        public long Planification_ID { get; set; }

        public long? Planification_Capacite { get; set; }

        public long? Planification_Ddebut { get; set; }

        [StringLength(255)]
        public string Planification_Prix { get; set; }

        public int? formation_id_formation { get; set; }

        public virtual formation formation { get; set; }
    }
}
