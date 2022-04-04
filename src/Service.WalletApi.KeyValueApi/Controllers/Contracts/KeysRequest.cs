using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.KeyValueApi.Controllers.Contracts
{
	public class KeysRequest
	{
		[Required]
		public string[] Keys { get; set; }
	}
}