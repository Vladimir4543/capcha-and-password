namespace SalonKrasoti
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Клиент
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Клиент()
        {
            Предстоящие_записи = new HashSet<Предстоящие_записи>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(30)]
        public string Имя { get; set; }

        [StringLength(30)]
        public string Отчество { get; set; }

        [Required]
        [StringLength(30)]
        public string НомерТелефона { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Предстоящие_записи> Предстоящие_записи { get; set; }
    }
}
