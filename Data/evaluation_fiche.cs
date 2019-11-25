namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetpidevjee.evaluation_fiche")]
    public partial class evaluation_fiche
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public evaluation_fiche()
        {
            evaluation_reponse = new HashSet<evaluation_reponse>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string commentaire { get; set; }

        [StringLength(255)]
        public string critere { get; set; }

        public DateTime? date_ajout { get; set; }

        public DateTime? date_repense_limit { get; set; }

        [StringLength(255)]
        public string question1 { get; set; }

        [StringLength(255)]
        public string question2 { get; set; }

        [StringLength(255)]
        public string question3 { get; set; }

        [StringLength(255)]
        public string sujet { get; set; }

        public int? Evaluation_Reponse_id { get; set; }

        public int? id_Employer_id { get; set; }

        public int? id_manager_id { get; set; }

        public virtual employee employee { get; set; }

        public virtual employee employee1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluation_reponse> evaluation_reponse { get; set; }

        public virtual evaluation_reponse evaluation_reponse1 { get; set; }
    }
}
