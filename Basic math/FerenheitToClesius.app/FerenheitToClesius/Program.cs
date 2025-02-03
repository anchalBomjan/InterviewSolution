namespace FerenheitToClesius
{
    public  class Program
    {

        // static  methods is declared beacuse  we can directly call all the methods
        // without creating an object
        public static  double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit-32)*5/9;
        }

        public static  double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
       public  static void Main(string[] args)
        {

            Console.WriteLine("Enter temperature");
            if(!double.TryParse(Console.ReadLine(),out  double temperature))
            {
                Console.WriteLine("Invalide input.Please enter the valid number");
                return;
            }

            Console.WriteLine("Convert to (C)elsius or (F)ehrenheit?");
            char choice = char.ToUpper(Console.ReadKey().KeyChar);
            if (choice == 'C')
            {
                Console.WriteLine($"{temperature}°F is {FahrenheitToCelsius(temperature):0.00}°C");
            }

            else if (choice == 'F')
            {
                Console.WriteLine($"{temperature}°C is {CelsiusToFahrenheit(temperature):0.00}°F");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'C' or 'F'.");
            }
        }

    }
    
}
