namespace teste.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class Listas_Tarefas : DbContext
    {
        public Listas_Tarefas()
            : base("name=Listas_Tarefas")
        {
        }

        public virtual DbSet<Lista> Listas { get; set; }
        public virtual DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Lista>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Lista>()
                .HasMany(e => e.Tarefas)
                .WithRequired(e => e.Lista)
                .HasForeignKey(e => e.Id_Lista)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tarefa>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Tarefa>()
                .Property(e => e.descricao)
                .IsUnicode(false);
        }
    }
}
