using System.ComponentModel.DataAnnotations;

namespace Service.KeyValueApi.Models
{
	public class KeyValueList
	{
		[Required]
		public KeyValueItem[] Items { get; set; }
	}
}