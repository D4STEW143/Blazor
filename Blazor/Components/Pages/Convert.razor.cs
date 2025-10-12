using System.Text.RegularExpressions;

namespace Blazor.Components.Pages {
	public partial class Convert {
		string s_input { get; set; }
		public enum Systems {
			Binary, Octal, Decimal, Hexadecimal, Unknown
		}

		public Systems SystemDetection() {
			string input = s_input;
			if (string.IsNullOrEmpty(input)) { return Systems.Unknown; }
			input = input.Trim().ToUpper();
			if (Regex.IsMatch(input, @"^(0x)?[0-9A-F]+$")) {
				if (input.StartsWith("0X") || Regex.IsMatch(input, @"[A-F]")) {
					return Systems.Hexadecimal;
				}
			}
			if (Regex.IsMatch(input, @"^(0B)?[01]+$")) { return Systems.Binary; }
			if (Regex.IsMatch(input, @"^[0-7]+$")) { return Systems.Octal; }
			if (Regex.IsMatch(input, @"^\d+$")) { return Systems.Decimal; }
			return Systems.Unknown;
		}
	}
}
