namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.timesheet")]
    public partial class timesheet
    {
        public int id { get; set; }

        public DateTime? finisdate { get; set; }

        public DateTime? jrferie { get; set; }

        public DateTime? startingdate { get; set; }
    }
}
