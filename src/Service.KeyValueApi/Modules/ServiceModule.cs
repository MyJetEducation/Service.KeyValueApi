using Autofac;
using Microsoft.Extensions.Logging;
using Service.KeyValue.Client;
using Service.UserInfo.Crud.Client;

namespace Service.KeyValueApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterUserInfoCrudClient(Program.Settings.UserInfoCrudServiceUrl, Program.LogFactory.CreateLogger(typeof(UserInfoCrudClientFactory)));
			builder.RegisterKeyValueClient(Program.Settings.KeyValueServiceUrl);
		}
	}
}