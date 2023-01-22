using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.ValueConverters;
using System.Drawing;
using System.Linq.Expressions;

namespace Persistence.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.HasOne(b => b.BookAuthor)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.IsActive)
                .HasConversion(BooleanConverter2.Convert(trueStr:"yes",falseStr: "no"));
                //.HasConversion<BooleanConverter1>();
        }
    }

   

  
}
