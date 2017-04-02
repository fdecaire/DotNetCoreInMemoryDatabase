using System;
using DataSource;
using DataSource.Domain;
using Microsoft.EntityFrameworkCore;

namespace UnitTests
{
	public class TestDataFixture : IDisposable
	{
		public StoreAppContext Context { get; set; }

		public TestDataFixture()
		{
			var builder = new DbContextOptionsBuilder<StoreAppContext>()
				.UseInMemoryDatabase();
			Context = new StoreAppContext(builder.Options);

			Context.Products.Add(new Product
			{
				Name = "Rice",
				Price = 5.99m
			});
			Context.Products.Add(new Product
			{
				Name = "Bread",
				Price = 2.35m
			});

			Context.SaveChanges();
		}

		public void Dispose()
		{

		}
	}
}
