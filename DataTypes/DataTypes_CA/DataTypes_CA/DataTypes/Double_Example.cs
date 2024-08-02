// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

namespace DataTypes_CA.DataTypes
{
    /// <summary>
    /// Examples related to the Double data type.
    /// </summary>
    internal class Double_Example
    {
        #region Simple examples

        /// <summary>
        /// Displays simple Double examples in the console.
        /// </summary>
        internal static void RunExample()
        {
            double a = 5.75d;
            double b = 2.5d;

            double x = 1.0d / 3.0d;
            double y = 0.3333333333333333d;

            double posInf = float.PositiveInfinity;
            double negInf = float.NegativeInfinity;
            double nan = float.NaN;

            // Type conversion
            float smallValue = 5.5f;
            double largeValue = smallValue; // Implicit conversion

            decimal decValue = 1.234567891011121314m;
            double fromDec = (double)decValue; // Explicit conversion

            // Size of double is 8 Bytes = 64 bits
            double sizeOfDouble = sizeof(double);

            Console.WriteLine(Helpers.GetConsoleOutputHeader());

            // Arithmetic operations
            Console.WriteLine("Sum: " + (a + b));        // 8.25
            Console.WriteLine("Difference: " + (a - b)); // 3.25
            Console.WriteLine("Product: " + (a * b));    // 14.375
            Console.WriteLine("Quotient: " + (a / b));   // 2.3

            // Comparison operations
            Console.WriteLine("x and y are approximately equal: " + (Math.Abs(x - y) < 0.000001f));

            // Special values
            Console.WriteLine("Positive Infinity: " + posInf);
            Console.WriteLine("Negative Infinity: " + negInf);
            Console.WriteLine("NaN: " + nan);

            Console.WriteLine("Converted double value: " + largeValue);
            Console.WriteLine("Converted from decimal: " + fromDec);

            // Handling rounding errors
            double num1 = 0.1d;
            double num2 = 0.2d;
            double sum = num1 + num2;
            Console.WriteLine("Sum is approximately 0.3: " + (Math.Abs(sum - 0.3d) < 0.000000000000001d));

            Console.WriteLine($"Size of a double: {sizeOfDouble}");
        }

        #endregion Simple examples

        #region Advanced examples

        /// <summary>
        /// Runs more advanced examples with Double data type.
        /// </summary>
        internal static void RunAdvancedExamples()
        {

        }

        #endregion Advanced examples
    }
}
