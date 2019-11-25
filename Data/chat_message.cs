namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.chat_message")]
    public partial class chat_message
    {
        public int id { get; set; }

        [Column("chat_message")]
        [StringLength(255)]
        public string chat_message1 { get; set; }

        public int from_Employeeid { get; set; }

        public int status { get; set; }

        public int to_Employeeid { get; set; }

        public DateTime? ts { get; set; }
    }
}
