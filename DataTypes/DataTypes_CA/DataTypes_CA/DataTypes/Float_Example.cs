// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

namespace DataTypes_CA.DataTypes
{
    /// <summary>
    ///Examples related to the Float data type.
    /// </summary>
    internal class Float_Example
    {
        #region Simple examples

        /// <summary>
        /// Displays simple Float examples in the console.
        /// </summary>
        internal static void RunExample()
        {
            float a = 5.75f;
            float b = 2.5f;

            float x = 1.0f / 3.0f;
            float y = 0.3333333f;

            float posInf = float.PositiveInfinity;
            float negInf = float.NegativeInfinity;
            float nan = float.NaN;

            // Type conversion
            double largeValue = 1.2345678910111213;
            float smallValue = (float)largeValue; // Explicit conversion

            // Size of float is 4 Bytes = 32 bits
            float sizeOfFloat = sizeof(float);

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

            Console.WriteLine("Converted float value: " + smallValue);

            // Handling rounding errors
            float num1 = 0.1f;
            float num2 = 0.2f;
            float sum = num1 + num2;
            Console.WriteLine("Sum is approximately 0.3: " + (Math.Abs(sum - 0.3f) < 0.00001f));

            Console.WriteLine($"Size of a float: {sizeOfFloat}");
        }

        #endregion Simple examples

        #region Advanced examples

        /// <summary>
        /// Runs more advanced examples with Float data type.
        /// </summary>
        internal static void RunAdvancedExample()
        {
        }

        #endregion Advanced examples
    }
}