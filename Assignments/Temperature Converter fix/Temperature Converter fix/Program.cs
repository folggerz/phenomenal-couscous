namespace Temperature_Converter_fix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The temperatures need correcting.");
			bool convertAgain = true;
			while (convertAgain)
			{
				Console.WriteLine("Choose a conversion option:\n1- F -> C\n2- C -> F");
				string conversion = Console.ReadLine();

				do while (conversion ==) // Failure to include 'while' initializing do..while loop.
				{
					if (conversion == "1" && conversion == "2")
					{
						break;
					}
					while (convertAgain)
					{
						Console.WriteLine("Choose a conversion option:\n1- F -> C\n2- C -> F");
						conversion = Console.ReadLine();
					} // Failure to wrap text in curly braces. While loop was not initiated.
				} while (true);

				while (true)
				{
					try
					{
						if ((conversion!= "1")) // Conversion to int str needs to be wrapped in double parentheses. Failure to include '!.'
						{
							Console.WriteLine("Please enter a temperature in fahrenheit");
							double temp = Convert.ToDouble(Console.ReadLine());
							double convertedTemp = (5 * temp) - 160 / 9;
							Console.WriteLine($"{temp}°F is equivalent to {convertedTemp}°C");
						
						}
						else if (conversion == "2")
						{
							Console.WriteLine("Please enter a temperature in celsius");
							double temp = double.Parse(Console.WriteLine());
							double convertedTemp = (temp * 9 / 5) + 32;
							Console.WriteLine($"{temp}°C is equivalent to {convertedTemp}°F");
						}
					}
					catch (DivideByZeroException) // Variable 'e' is declared but never used.
					{
						Console.WriteLine("The value you entered is not a number. Press enter to try again.");
						Console.ReadLine();
					}
				}

				while (true)
				{
					Console.WriteLine("Do you want to do another conversion? (y/n)");
					string repeat = Console.ReadLine().ToUpper();

					if (repeat == "y")
					{
						// continue the loop
					}
					else if (repeat == "n")
					{
						Console.WriteLine("Thank you, see you soon!");
						convertAgain = false;
						break;
					}
					else
					{
						continue;
					}
				}
			}
		}
	}
}
