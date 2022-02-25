using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.KeyValueApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("KeyValueApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("KeyValueApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("KeyValueApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("KeyValueApi.JwtAudience")]
		public string JwtAudience { get; set; }

		[YamlProperty("KeyValueApi.KeyValueServiceUrl")]
		public string KeyValueServiceUrl { get; set; }
	}
}