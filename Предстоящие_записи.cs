namespace SalonKrasoti
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Предстоящие записи")]
    public partial class Предстоящие_записи
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата { get; set; }

        [Required]
        [StringLength(50)]
        public string Время { get; set; }

        public int IDКлиента { get; set; }

        public int IDСотрудника { get; set; }

        public int IDУслуги { get; set; }

        public virtual Клиент Клиент { get; set; }

        public virtual Сотрудники Сотрудники { get; set; }

        public virtual Услуги Услуги { get; set; }
    }
}
