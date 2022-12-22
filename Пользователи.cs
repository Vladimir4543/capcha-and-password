namespace SalonKrasoti
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователи
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пользователи()
        {
            Сотрудники = new HashSet<Сотрудники>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Логин { get; set; }

        [Required]
        [StringLength(20)]
        public string Пароль { get; set; }

        public int IDРоли { get; set; }

        public virtual Роль Роль { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудники> Сотрудники { get; set; }
    }
}
