using Autofac;
using Service.KeyValue.Client;
using Service.UserInfo.Crud.Client;

namespace Service.KeyValueApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterUserInfoCrudClient(Program.Settings.UserInfoCrudServiceUrl);
			builder.RegisterKeyValueClient(Program.Settings.KeyValueServiceUrl);
		}
	}
}