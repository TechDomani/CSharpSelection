

using System.Linq;

namespace CSharpSelection
{
	public static class SelectionExamples
	{
		public static void ConditionalOperations(bool hasBrothers, bool hasSisters)
		{
			// Conditional OR
			if (hasBrothers || hasSisters)
			{
				Console.WriteLine("You have siblings");
			}
			// Conditional AND
			if (hasBrothers && hasSisters)
			{
				Console.WriteLine("You have both brothers and sisters");
			}
			// Conditional XOR
			if (hasBrothers ^ hasSisters)
			{
				Console.WriteLine("You have brothers or sisters but not both");
			}
			// Conditional NOT
			if (!hasBrothers)
			{
				Console.WriteLine("You do not have brothers");
			}
			if (!hasSisters)
			{
				Console.WriteLine("You do not have sisters");
			}
			if (!hasBrothers && !hasSisters)
			{
				Console.WriteLine("You are an only child");
			}

		}
		public static string AssignLetterGrade(int mark)
		{
			if (mark < 0 || mark > 100)
			{
				throw new ArgumentOutOfRangeException(nameof(mark), "Mark should be between 0 and 100");
			}
			string grade;
			if (mark > 80)
			{
				grade = "Distinction";
			}
			else if (mark > 70)
			{
				grade = "Merit";
			}
			else if (mark >= 60)
			{
				grade = "Pass";
			}
			else
			{
				grade = "Fail";
			}
			return grade;
		}

		public static string LiftTakeoff(int numberOfPassengers, double averageWeightInPounds)
		{
			// Use of constants
			const double PoundsToKg = 0.454d;
			const int LiftCapacity = 600;

			double weightInKg = averageWeightInPounds * PoundsToKg;
			double totalWeight = weightInKg * numberOfPassengers;

			// Ternary operator
			string message = totalWeight < LiftCapacity ? "Lift good to go" : "Too many people in lift";
			return message;
        }

        // A switch statement is more efficient
		// The compiler will optimize it to a lookup table
		// whereas with if/else statements it cannot
		// However it will probably make little difference if the number of cases is small
        public static decimal DetermineTip(string service)
		{
			decimal tip;
			service = service.ToLower();
			switch (service)
			{
				case "excellent":
					tip = 0.2m;
					break;
				case "good":
					tip = 0.15m;
					break;
				case "ok":
					tip = 0.1m;
					break;
				default:
					tip = 0m;
					break;
			}
			return tip;
		}

		public enum ServiceLevel
		{
			Excellent,
			Good,
			Ok,
			Rubbish
		}
		public static decimal DetermineTip(ServiceLevel service)
		{
			decimal tip;
			switch (service)
			{
				case ServiceLevel.Excellent:
					tip = 0.2m;
					break;
				case ServiceLevel.Good:
					tip = 0.15m;
					break;
				case ServiceLevel.Ok:
					tip = 0.1m;
					break;
				default:
					tip = 0m;
					break;
			}
			return tip;
		}

	}
}
