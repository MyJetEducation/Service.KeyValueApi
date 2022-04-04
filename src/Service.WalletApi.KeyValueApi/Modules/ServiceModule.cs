using Autofac;
using MyJetWallet.ApiSecurityManager.Autofac;
using MyJetWallet.Sdk.RestApiTrace;
using MyJetWallet.Sdk.Service;
using Service.KeyValue.Client;

namespace Service.WalletApi.KeyValueApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			// second parameter is null because we do not store api keys yet for wallet api
			builder.RegisterEncryptionServiceClient(ApplicationEnvironment.AppName, () => Program.Settings.MyNoSqlWriterUrl);

			builder.RegisterKeyValueClient(Program.Settings.KeyValueServiceUrl);

			if (Program.Settings.EnableApiTrace)
			{
				builder
					.RegisterInstance(new ApiTraceManager(Program.Settings.ElkLogs, "api-trace",
						Program.LoggerFactory.CreateLogger("ApiTraceManager")))
					.As<IApiTraceManager>()
					.As<IStartable>()
					.AutoActivate()
					.SingleInstance();
			}
		}
	}
}