using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace N00029793T3.Models.Maps
{
    public class RutinaMap : IEntityTypeConfiguration<Rutina>
    {
        public void Configure(EntityTypeBuilder<Rutina> builder)
        {
            builder.ToTable("Rutina");
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.users)
                .WithMany()
                .HasForeignKey(o => o.IdUsuario);


        }
    }
}
