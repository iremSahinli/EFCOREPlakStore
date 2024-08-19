using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plak_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_DAL.Mapping
{
    public class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(a => a.AlbumId);

            builder.Property(a => a.AlbumAdi)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(a => a.CikisTarihi)
            .IsRequired()
            .HasColumnType("date");

            builder.Property(a => a.Fiyat)
            .IsRequired();

            builder.Property(a => a.IndirimOrani)
            .IsRequired(false);

            builder.Property(a => a.SatisDurumu)
            .IsRequired();


            //Admin Album İlişkisi:
            builder.HasOne(a => a.Admin)
            .WithMany(ad => ad.Albums)
            .HasForeignKey(a => a.AdminId);

        }
    }
}
