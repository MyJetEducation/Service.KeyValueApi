using Autofac;
using MyJetWallet.Sdk.Authorization.NoSql;
using MyJetWallet.Sdk.NoSql;
using MyNoSqlServer.DataReader;

namespace Service.WalletApi.KeyValueApi.Modules
{
	public class ClientsModule : Module
	{
		protected override void Load(ContainerBuilder builder) => RegisterAuthServices(builder);

		protected void RegisterAuthServices(ContainerBuilder builder)
		{
			IMyNoSqlSubscriber authNoSql = builder.CreateNoSqlClient(() => Program.Settings.AuthMyNoSqlReaderHostPort);
			builder.RegisterMyNoSqlReader<ShortRootSessionNoSqlEntity>(authNoSql, ShortRootSessionNoSqlEntity.TableName);
		}
	}
}