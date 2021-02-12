using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moment3._3.Models
{
    public class Playlist
    {
        public int PlaylistId { get; init; }
        public string Artist { get; set; }
        public string SongTitle { get; set; }
        public int Length { get; set; }
        public string Category { get; set; }

    }
}
