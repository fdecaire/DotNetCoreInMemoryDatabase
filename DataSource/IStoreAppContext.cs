using System;
using DataSource.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataSource
{
	public interface IStoreAppContext : IDisposable
	{
		DbSet<Product> Products { get; }
	}
}
