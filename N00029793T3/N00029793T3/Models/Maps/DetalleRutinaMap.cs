using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace N00029793T3.Models.Maps
{
    public class DetalleRutinaMap : IEntityTypeConfiguration<DetalleRutina>
    {
        public void Configure(EntityTypeBuilder<DetalleRutina> builder)
        {
            builder.ToTable("DetalleRutina");
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.ejercicio)
                .WithMany()
                .HasForeignKey(o => o.IdEjercicio);

        }
    }
}
