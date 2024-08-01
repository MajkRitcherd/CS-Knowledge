// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

namespace DataTypes_CA.DataTypes
{
    /// <summary>
    /// Examples related to the Short data type.
    /// </summary>
    internal class Short_Example
    {
        #region Simple examples

        /// <summary>
        /// Displays simple short examples in the console.
        /// </summary>
        internal static void RunExample()
        {

            // Signed short
            short minShortValue = short.MinValue;
            short maxShortValue = short.MaxValue;

            short testValue = 100;
            int integer = testValue; // Implicit cast
            char character = (char)testValue; // Explicit cast

            // Size of short is 2 Bytes = 16 bits
            int sizeOfShort = sizeof(short);

            Console.WriteLine(Helpers.GetConsoleOutputHeader());

            Console.WriteLine($"{nameof(minShortValue)} = '{minShortValue}'");
            Console.WriteLine($"{nameof(maxShortValue)} = '{maxShortValue}'");
            Console.WriteLine($"{nameof(testValue)} as short: '{testValue}'");
            Console.WriteLine($"After implicit cast as integer: '{integer}'");
            Console.WriteLine($"After explicit cast as char: '{character}' (ASCII code 100 = 'd')");

            Console.WriteLine($"Size of a short: {sizeOfShort}");
        }

        #endregion Simple examples

        #region Advanced examples

        /// <summary>
        /// Runs more advanced examples with short data type.
        /// </summary>
        internal static void RunAdvancedExample()
        {
        }

        #endregion Advanced examples
    }
}