using System;
using System.Data.Entity;
using System.Linq;

namespace ConsoleMVC
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                var count = context.Albums.Count();

                Console.WriteLine(count);

                context.Albums.Add(new Album() { Price = 9.99m, Title = "wish" });
                context.SaveChanges();

                count = context.Albums.Count();
                Console.WriteLine(count);
                Console.ReadLine();
            }
        }
    }

    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
    }

    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}