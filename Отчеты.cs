namespace SalonKrasoti
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Отчеты
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [StringLength(70)]
        public string РасходныеМатериалы { get; set; }

        public decimal ДенежныеРасходы { get; set; }

        public int IDСотрудника { get; set; }

        public virtual Сотрудники Сотрудники { get; set; }
    }
}
