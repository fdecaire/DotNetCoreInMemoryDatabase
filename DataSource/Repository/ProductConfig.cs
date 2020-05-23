using DataSource.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataSource.Repository
{
	public static class ProductConfig
	{
		public static void AddProduct(this ModelBuilder modelBuilder, string schema)
		{
			modelBuilder.Entity<Product>(entity =>
			{
				entity.ToTable("Product", schema);

				entity.HasKey(p => p.Id);

				entity.Property(e => e.Name)
					.HasColumnName("Name")
					.IsRequired(false);

				entity.Property(e => e.Price)
					.HasColumnName("Price")
					.IsRequired(false);
			});
		}
	}
}
