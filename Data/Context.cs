namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<chat_message> chat_message { get; set; }
        public virtual DbSet<dayoff> dayoff { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<evaluation_fiche> evaluation_fiche { get; set; }
        public virtual DbSet<evaluation_reponse> evaluation_reponse { get; set; }
        public virtual DbSet<formateur> formateur { get; set; }
        public virtual DbSet<formation> formation { get; set; }
        public virtual DbSet<freelancer> freelancer { get; set; }
        public virtual DbSet<humanressources> humanressources { get; set; }
        public virtual DbSet<planification> planification { get; set; }
        public virtual DbSet<project> project { get; set; }
        public virtual DbSet<projectmanager> projectmanager { get; set; }
        public virtual DbSet<task> task { get; set; }
        public virtual DbSet<timesheet> timesheet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chat_message>()
                .Property(e => e.chat_message1)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.Speciality)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.competence)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.fullName)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.job)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.evaluation_fiche)
                .WithOptional(e => e.employee)
                .HasForeignKey(e => e.id_manager_id);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.evaluation_fiche1)
                .WithOptional(e => e.employee1)
                .HasForeignKey(e => e.id_Employer_id);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.task)
                .WithOptional(e => e.employee)
                .HasForeignKey(e => e.empss_id);

            modelBuilder.Entity<evaluation_fiche>()
                .Property(e => e.commentaire)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation_fiche>()
                .Property(e => e.critere)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation_fiche>()
                .Property(e => e.question1)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation_fiche>()
                .Property(e => e.question2)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation_fiche>()
                .Property(e => e.question3)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation_fiche>()
                .Property(e => e.sujet)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation_fiche>()
                .HasMany(e => e.evaluation_reponse)
                .WithOptional(e => e.evaluation_fiche)
                .HasForeignKey(e => e.evaluation_fiche_id);

            modelBuilder.Entity<evaluation_reponse>()
                .Property(e => e.commentaire)
                .IsUnicode(false);

            modelBuilder.Entity<evaluation_reponse>()
                .HasMany(e => e.evaluation_fiche1)
                .WithOptional(e => e.evaluation_reponse1)
                .HasForeignKey(e => e.Evaluation_Reponse_id);

            modelBuilder.Entity<formateur>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.specialite)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .HasMany(e => e.formation)
                .WithOptional(e => e.formateur)
                .HasForeignKey(e => e.idFormateur);

            modelBuilder.Entity<formation>()
                .Property(e => e.Formation_Nom)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .HasMany(e => e.planification)
                .WithOptional(e => e.formation)
                .HasForeignKey(e => e.formation_id_formation);

            modelBuilder.Entity<formation>()
                .HasMany(e => e.employee)
                .WithMany(e => e.formation)
                .Map(m => m.ToTable("formation_employee").MapRightKey("employes_id"));

            modelBuilder.Entity<freelancer>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<freelancer>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<freelancer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<freelancer>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<humanressources>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<humanressources>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<humanressources>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<humanressources>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<humanressources>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<planification>()
                .Property(e => e.Planification_Prix)
                .IsUnicode(false);

            modelBuilder.Entity<project>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<project>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<project>()
                .HasMany(e => e.task)
                .WithOptional(e => e.project)
                .HasForeignKey(e => e.prj_id);

            modelBuilder.Entity<projectmanager>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<projectmanager>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<projectmanager>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<projectmanager>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<projectmanager>()
                .Property(e => e.Service)
                .IsUnicode(false);

            modelBuilder.Entity<task>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<task>()
                .Property(e => e.state)
                .IsUnicode(false);
        }
    }
}
