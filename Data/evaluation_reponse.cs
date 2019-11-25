namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.evaluation_reponse")]
    public partial class evaluation_reponse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public evaluation_reponse()
        {
            evaluation_fiche1 = new HashSet<evaluation_fiche>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string commentaire { get; set; }

        public int note { get; set; }

        public int question1 { get; set; }

        public int question2 { get; set; }

        public int question3 { get; set; }

        public int? evaluation_fiche_id { get; set; }

        public virtual evaluation_fiche evaluation_fiche { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluation_fiche> evaluation_fiche1 { get; set; }
    }
}
