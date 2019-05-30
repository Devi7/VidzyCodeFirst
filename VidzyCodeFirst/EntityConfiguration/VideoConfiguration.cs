using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst.EntityConfiguration
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {

        public VideoConfiguration()
        {
            ToTable("Videos");
            HasKey(v => v.Id);

            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(v => v.Genre)
                .WithMany(g => g.Videos)
                .HasForeignKey(v => v.GenreId);

            Property(v => v.Classification)
                .HasColumnType("tinyint");
        }


    }
}
