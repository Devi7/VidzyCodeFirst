﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst
{
    
    public enum Classification : byte
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3
    }

    public class Video
    {
        public Video()
        {
            Tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public Classification Classification { get; set; }

    }
}
