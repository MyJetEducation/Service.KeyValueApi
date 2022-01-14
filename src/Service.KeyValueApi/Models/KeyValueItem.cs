using System.ComponentModel.DataAnnotations;
using Service.KeyValue.Grpc.Models;

namespace Service.KeyValueApi.Models
{
	public class KeyValueItem
	{
		public KeyValueItem(KeyValueGrpcModel model)
		{
			Key = model.Key;
			Value = model.Value;
		}

		public KeyValueItem()
		{
		}

		[Required]
		public string Key { get; set; }

		[Required]
		public string Value { get; set; }
	}
}