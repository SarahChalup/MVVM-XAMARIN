namespace apiPhoneBook.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Appi.Models.User> Users { get; set; }
    }
}