namespace SalonKrasoti
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Услуги
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Услуги()
        {
            Предстоящие_записи = new HashSet<Предстоящие_записи>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(100)]
        public string Описание { get; set; }

        public decimal Цена { get; set; }

        [Required]
        [StringLength(50)]
        public string Фото { get; set; }

        public int IDКатегорииУслуги { get; set; }

        public virtual Категория_услуги Категория_услуги { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Предстоящие_записи> Предстоящие_записи { get; set; }
    }
}
