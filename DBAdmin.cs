namespace UTS_Business_Programming
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBAdmin : DbContext
    {
        public DBAdmin()
            : base("name=DBAdmin")
        {
        }

        public virtual DbSet<FoodList> FoodLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodList>()
                .Property(e => e.Food_ID)
                .IsUnicode(false);

            modelBuilder.Entity<FoodList>()
                .Property(e => e.Nama)
                .IsUnicode(false);

            modelBuilder.Entity<FoodList>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<FoodList>()
                .Property(e => e.Qty)
                .IsUnicode(false);

            modelBuilder.Entity<FoodList>()
                .Property(e => e.Harga)
                .IsUnicode(false);

            modelBuilder.Entity<FoodList>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
