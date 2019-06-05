using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirst.EntityConfiguration
{
    class GenreConfiguration : EntityTypeConfiguration<Genre>
    {

        public GenreConfiguration()
        {
            ToTable("Genres");
            HasKey(v => v.Id);

            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
