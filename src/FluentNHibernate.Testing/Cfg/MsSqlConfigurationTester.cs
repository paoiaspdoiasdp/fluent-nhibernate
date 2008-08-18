using FluentNHibernate.Cfg;
using NHibernate;
using NUnit.Framework;

namespace FluentNHibernate.Testing.Cfg
{
	[TestFixture]
	public class MsSqlConfigurationTester
	{
		[Test]
		public void MsSql7_should_default_to_the_Sql7_dialect()
		{
			MsSqlConfiguration.MsSql7.ToProperties()["dialect"].ShouldEqual("NHibernate.Dialect.MsSql7Dialect, " + typeof(ISession).Assembly.FullName);
		}

		[Test]
		public void MsSql2000_should_default_to_the_Sql2000_dialect()
		{
			MsSqlConfiguration.MsSql2000.ToProperties()["dialect"].ShouldEqual("NHibernate.Dialect.MsSql2000Dialect, " + typeof(ISession).Assembly.FullName);
		}

		[Test]
		public void MsSql2005_should_default_to_the_Sql2005_dialect()
		{
			MsSqlConfiguration.MsSql2005.ToProperties()["dialect"].ShouldEqual("NHibernate.Dialect.MsSql2005Dialect, " + typeof(ISession).Assembly.FullName);
		}

		[Test]
		public void MsSqlCe_should_default_to_the_Sql2005_dialect()
		{
			MsSqlConfiguration.MsSqlCe.ToProperties()["dialect"].ShouldEqual("NHibernate.Dialect.MsSqlCeDialect, " + typeof(ISession).Assembly.FullName);
		}

		[Test]
		public void MsSql_driver_should_default_to_the_SqlClientDriver()
		{
			MsSqlConfiguration.MsSql2000.ToProperties()["connection.driver_class"].ShouldEqual("NHibernate.Driver.SqlClientDriver, " + typeof(ISession).Assembly.FullName);
		}
	}
}