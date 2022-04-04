using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.KeyValueApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("KeyValueApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("KeyValueApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("KeyValueApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("KeyValueApi.EnableApiTrace")]
		public bool EnableApiTrace { get; set; }

		[YamlProperty("KeyValueApi.MyNoSqlReaderHostPort")]
		public string MyNoSqlReaderHostPort { get; set; }

		[YamlProperty("KeyValueApi.AuthMyNoSqlReaderHostPort")]
		public string AuthMyNoSqlReaderHostPort { get; set; }

		[YamlProperty("KeyValueApi.SessionEncryptionKeyId")]
		public string SessionEncryptionKeyId { get; set; }

		[YamlProperty("KeyValueApi.MyNoSqlWriterUrl")]
		public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("KeyValueApi.KeyValueServiceUrl")]
		public string KeyValueServiceUrl { get; set; }
	}
}