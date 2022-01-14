using System.ComponentModel.DataAnnotations;

namespace Service.KeyValueApi.Models
{
	public class KeysRequest
	{
		[Required]
		public string[] Keys { get; set; }
	}
}