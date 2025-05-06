using System.Data.Entity;  // Esto es para EF 6.x

namespace TienditaMVC.Models
{
    public class HotelDBContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Huesped> Huespedes { get; set; }
        public DbSet<Articulo> Articulos { get; set; }

        public HotelDBContext() : base("HotelDBConnection")
        {
        }
    }
}
