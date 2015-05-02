using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC
{
    class Program
    {
        static void Main(string[] args)
        {
        }

       
    }

    public class Album
    {
        public int AlbumId { get; set; }
        public string  Title { get; set; }
        public decimal Price { get; set; }
    }

    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }

}
