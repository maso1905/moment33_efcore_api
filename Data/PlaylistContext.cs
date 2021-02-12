using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moment3._3.Models;

namespace moment3._3.Data
{
    public class PlaylistContext : DbContext
    {
        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base(options)
        {
        }

        public DbSet<Playlist> playlists { get; set; }
    }
}
