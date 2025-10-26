using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models {
	public class Teacher {
		[Key] public short teacher_id { get; set; }
		[Required] public string last_name { get; set; }
		[Required] public string first_name { get; set; }
		[Required] public string middle_name { get; set; }
		[Required] public DateOnly birth_date { get; set; }
		public string? email { get; set; }
		public string? phone { get; set; }
		public byte[]? photo { get; set; }
		[Required] public DateOnly work_since { get; set; }
		[Required] public decimal? rate { get; set; }
	}
}
