namespace SalonKrasoti
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудники
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудники()
        {
            Отчеты = new HashSet<Отчеты>();
            Предстоящие_записи = new HashSet<Предстоящие_записи>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(30)]
        public string Имя { get; set; }

        [StringLength(30)]
        public string Отчество { get; set; }

        [Required]
        [StringLength(30)]
        public string Должность { get; set; }

        [Required]
        [StringLength(20)]
        public string НомерТелефона { get; set; }

        [StringLength(50)]
        public string Фото { get; set; }

        public int IDПользователя { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Отчеты> Отчеты { get; set; }

        public virtual Пользователи Пользователи { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Предстоящие_записи> Предстоящие_записи { get; set; }
    }
}
