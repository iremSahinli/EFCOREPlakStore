using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plak_DATA.Entity;


namespace Plak_DAL.Mapping
{
    public class AdminMapping : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
           builder.HasKey(ad => ad.AdminId);

            builder.Property(ad => ad.Ad)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(ad => ad.Sifre)
            .IsRequired()
            .HasMaxLength(8);



        }
    }
}
