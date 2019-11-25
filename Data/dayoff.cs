namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.dayoff")]
    public partial class dayoff
    {
        public int id { get; set; }

        public DateTime? debut { get; set; }

        public DateTime? fin { get; set; }

        public int nbjrs { get; set; }
    }
}
