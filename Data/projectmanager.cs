namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.projectmanager")]
    public partial class projectmanager
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

        [StringLength(255)]
        public string Service { get; set; }
    }
}
