namespace UnitConverterLib;

public class UnitConverter
{
    public double Convert(double value, string fromUnit, string toUnit)
    {
        if (fromUnit == toUnit)
        {
            return value;
        }
        // Conversion logic
        if (fromUnit == "meters" && toUnit == "kilometers")
        {
            return value / 1000;
        }
        else if (fromUnit == "kilometers" && toUnit == "meters")
        {
            return value * 1000;
        }
        else if (fromUnit == "grams" && toUnit == "kilograms")
        {
            return value / 1000;
        }
        else if (fromUnit == "kilograms" && toUnit == "grams")
        {
            return value * 1000;
        }

        throw new NotSupportedException($"Conversion from {fromUnit} to {toUnit} is not supported.");
    }
}

