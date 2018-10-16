namespace teste.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

     public partial class Tarefa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string titulo { get; set; }

        public string descricao { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? data_conclusao { get; set; }

        public int status { get; set; }

        public int Id_Lista { get; set; }

        public virtual Lista Lista { get; set; }
    }
}
