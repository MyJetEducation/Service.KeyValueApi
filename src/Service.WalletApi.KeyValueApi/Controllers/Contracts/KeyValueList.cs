using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.KeyValueApi.Controllers.Contracts
{
	public class KeyValueList
	{
		[Required]
		public KeyValueItem[] Items { get; set; }
	}
}