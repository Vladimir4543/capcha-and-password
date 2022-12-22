using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SalonKrasoti
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Категория_услуги> Категория_услуги { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Отчеты> Отчеты { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Предстоящие_записи> Предстоящие_записи { get; set; }
        public virtual DbSet<Роль> Роль { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Услуги> Услуги { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Категория_услуги>()
                .HasMany(e => e.Услуги)
                .WithRequired(e => e.Категория_услуги)
                .HasForeignKey(e => e.IDКатегорииУслуги)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Клиент>()
                .HasMany(e => e.Предстоящие_записи)
                .WithRequired(e => e.Клиент)
                .HasForeignKey(e => e.IDКлиента)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Отчеты>()
                .Property(e => e.ДенежныеРасходы)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Пользователи>()
                .HasMany(e => e.Сотрудники)
                .WithRequired(e => e.Пользователи)
                .HasForeignKey(e => e.IDПользователя)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Роль>()
                .HasMany(e => e.Пользователи)
                .WithRequired(e => e.Роль)
                .HasForeignKey(e => e.IDРоли)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудники>()
                .HasMany(e => e.Отчеты)
                .WithRequired(e => e.Сотрудники)
                .HasForeignKey(e => e.IDСотрудника)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудники>()
                .HasMany(e => e.Предстоящие_записи)
                .WithRequired(e => e.Сотрудники)
                .HasForeignKey(e => e.IDСотрудника)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Услуги>()
                .Property(e => e.Цена)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Услуги>()
                .HasMany(e => e.Предстоящие_записи)
                .WithRequired(e => e.Услуги)
                .HasForeignKey(e => e.IDУслуги)
                .WillCascadeOnDelete(false);
        }
    }
}
