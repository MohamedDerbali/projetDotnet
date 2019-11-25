namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.task")]
    public partial class task
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        public int? empss_id { get; set; }

        public int? prj_id { get; set; }

        public virtual employee employee { get; set; }

        public virtual project project { get; set; }
    }
}
