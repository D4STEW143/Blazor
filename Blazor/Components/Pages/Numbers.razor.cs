using System.Numerics;
using System.Collections.Generic;
namespace Blazor.Components.Pages {
	public partial class Numbers {
		UInt128 input_factorial;
		BigInteger result_factorial;

		int input_fibonacci;
		List<BigInteger> Result_fibonacci = new List<BigInteger> { };
		string result_fibonacci = string.Empty;


		void Factorial() {
			result_factorial = 1;
			for (UInt128 i = 1; i <= input_factorial; i++) {
				result_factorial *= i;
			}
		}

		void Fibonacci() {
			BigInteger a = 0, b = 1;
			Result_fibonacci.Add(a);
			Result_fibonacci.Add(b);
			for (int i = 1; i <= input_fibonacci - 1; i++) {
				BigInteger i_temp = a;
				a = b;
				b = i_temp + b;
				Result_fibonacci.Add(b);
			}
			string s_temp = string.Join(" - ", Result_fibonacci.ConvertAll(i => i.ToString()));
			result_fibonacci = string.Empty;
			result_fibonacci += s_temp;
		}

	}
}
