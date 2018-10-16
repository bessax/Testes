namespace teste.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lista")]
    public partial class Lista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lista()
        {
            Tarefas = new List<Tarefa>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public List<Tarefa> Tarefas { get; set; }

        public void AddTarefa(Tarefa item)
        {
            item.Lista = this;            
            this.Tarefas.Add(item);
            
        }
    }
}
