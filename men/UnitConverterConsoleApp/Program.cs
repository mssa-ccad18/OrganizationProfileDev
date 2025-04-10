using UnitConverterLib;

class Program
{
    static void Main(string[] args)
    {
        double result = PerformConversion(10, "cm", "inches");
        Console.WriteLine($"10 cm is equal to {result} inches.");
    }

    static double PerformConversion(double value, string fromUnit, string toUnit)
    {
        // Encapsulated conversion logic
        if (fromUnit == "cm" && toUnit == "inches")
        {
            return UnitConverter.CmToInches(value);
        }

        throw new NotSupportedException($"Conversion from {fromUnit} to {toUnit} is not supported.");
    }
}