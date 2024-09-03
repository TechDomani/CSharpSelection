using System.Diagnostics;

namespace CSharpSelection
{
	internal class Program
	{
		static void Main()
		{
			Console.WriteLine("# Assign Letter Grade");
			string grade = SelectionExamples.AssignLetterGrade(90);
			Console.WriteLine($"Your grade was a {grade}\n");
			//// Can use Debug.Assert to check return values
			Debug.Assert(SelectionExamples.AssignLetterGrade(70) == "Merit", "Merit expected");

			//Console.WriteLine("# Conditional Operations");
			//SelectionExamples.ConditionalOperations(false, true);
			//Console.WriteLine();

			//Console.WriteLine("# Check for valid Input");
			//InputNumber();
			//Console.WriteLine();

			//Console.WriteLine("# Lift Takeoff");
			///string message = SelectionExamples.LiftTakeoff(5, 142d);
			//Console.WriteLine($"{message}\n");

			//Console.WriteLine("# Determine tip");
			//decimal tip = SelectionExamples.DetermineTip("Good");
			//Console.WriteLine($"The tip will be {tip}\n");

			//Console.WriteLine("# Determine tip with enum");
			//decimal tip2 = SelectionExamples.DetermineTip(SelectionExamples.ServiceLevel.Good);
			//Console.WriteLine($"The tip will be {tip2}\n");

			//Console.WriteLine("# Generating a random number");
			//RandomExample();
		}

		static void RandomExample()
		{
			Random random = new();
			int num = random.Next(10);
			Console.WriteLine($"Your random number is {num}\n");
		}

		static void InputNumber()
		{
			Console.WriteLine("Please enter a number between one and fifty");
			string? strNum = Console.ReadLine();
			if (int.TryParse(strNum, out int val))
			{
				if (val > 0 && val < 51)
				{
					Console.WriteLine("Your number is valid");
				}
				else
				{
					Console.WriteLine("Your number must be between one and fifty");
				}
			}
			else
			{
				Console.WriteLine("You did not enter a valid number");
			}			
		}
	}
}