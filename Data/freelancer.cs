namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.freelancer")]
    public partial class freelancer
    {
        public int id { get; set; }

        [StringLength(255)]
        public string Fname { get; set; }

        [StringLength(255)]
        public string Lname { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        public int hrs { get; set; }

        public long salary { get; set; }
    }
}
