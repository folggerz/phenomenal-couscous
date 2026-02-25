using System.Linq.Expressions;

namespace Learningdefensiveprog
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Please enter a number.");
				int num1 = int.Parse(Console.ReadLine());

				Console.WriteLine("Please enter next number.");
				int num2 = int.Parse(Console.ReadLine());

				int quotient = num1 / num2;
				int remainder = num1 % num2;

				Console.WriteLine($"{num1} / {num2} = {quotient} R{remainder}");
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("You can't divide by zero. Please try again.");
			}
			catch (FormatException ex)
			{
				Console.WriteLine("The value you entered wasn't a whole number.");
			}
			catch (OverflowException ex)
			{
				Console.WriteLine("The number must be between -2 billion and 2 billion.");

				}
			}
			
		}
	}
