using Microsoft.EntityFrameworkCore;

namespace YourNamespace
{
    public class FoodDeliveryDbContext : DbContext
    {
        public DbSet<Adresa_Client> AdreseClienti { get; set; }
        public DbSet<Adresa> Adrese { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<MeniuItem> MeniuriItemuri { get; set; }
        public DbSet<OrderMeniuItem> OrdineMeniuriItemuri { get; set; }
        public DbSet<OrderStatus> StatusuriComenzi { get; set; }
        public DbSet<Order> Comenzi { get; set; }
        public DbSet<Restaurant> Restaurante { get; set; }
        public DbSet<SoferComanda> SoferiComenzi { get; set; }
        public DbSet<Tara> Tari { get; set; }

using System;
using System.Data.SqlClient;

namespace FoodDeliveryApp
{
    class Program
    { 
        static string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            try
            {
               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine("Connection to the database successful.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Adresa_Client>()
                .HasKey(ac => new { ac.AdresaId, ac.ClientId });

            modelBuilder.Entity<Adresa_Client>()
                .HasOne(ac => ac.Adresa)
                .WithMany(a => a.AdreseClienti)
                .HasForeignKey(ac => ac.AdresaId);

            modelBuilder.Entity<Adresa_Client>()
                .HasOne(ac => ac.Client)
                .WithMany(c => c.AdreseClienti)
                .HasForeignKey(ac => ac.ClientId);

            
        }
    } 
}
}
