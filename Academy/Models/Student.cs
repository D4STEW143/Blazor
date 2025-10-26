﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models {
	public class Student {
		[Key] public int stud_id { get; set; }
		[Required] public string last_name { get; set; }
		[Required] public string first_name { get; set; }
		public string? middle_name { get; set; }
		[Required] public DateTime birth_date { get; set; }
		public string? email { get; set; }
		public string? phone { get; set; }
		public byte[]? photo { get; set; }
		public int? group {  get; set; }
	}
}
