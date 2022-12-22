namespace SalonKrasoti
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Категория услуги")]
    public partial class Категория_услуги
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Категория_услуги()
        {
            Услуги = new HashSet<Услуги>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [StringLength(50)]
        public string Фото { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Услуги> Услуги { get; set; }
    }
}
