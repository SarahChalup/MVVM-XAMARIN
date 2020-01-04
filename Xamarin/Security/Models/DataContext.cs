namespace Security.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Security.Models.Usuario> Usuarios { get; set; }

        // public System.Data.Entity.DbSet<Appi.Models.Usuario> Users { get; set; }
    }
}