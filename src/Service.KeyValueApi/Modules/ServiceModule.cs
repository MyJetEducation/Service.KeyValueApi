using Autofac;
using Service.KeyValue.Client;

namespace Service.KeyValueApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterKeyValueClient(Program.Settings.KeyValueServiceUrl);
		}
	}
}