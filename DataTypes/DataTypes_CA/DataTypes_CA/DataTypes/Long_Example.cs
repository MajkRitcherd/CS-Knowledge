// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

namespace DataTypes_CA.DataTypes
{
    /// <summary>
    /// Examples related to the long data type.
    /// </summary>
    internal class Long_Example
    {
        #region Simple examples

        /// <summary>
        /// Displays simple long examples in the console.
        /// </summary>
        internal static void RunExample()
        {

            // Signed long
            long minValue = long.MinValue;
            long maxValue = long.MaxValue;

            long testValue = 100;
            Int128 int128Value = testValue; // Implicit cast
            short shortValue = (short)testValue; // Explicit cast

            // Size of long is 8 Bytes = 64 bits
            int sizeOfLong = sizeof(long);

            Console.WriteLine(Helpers.GetConsoleOutputHeader());

            Console.WriteLine($"{nameof(minValue)} = '{minValue}'");
            Console.WriteLine($"{nameof(maxValue)} = '{maxValue}'");
            Console.WriteLine($"{nameof(testValue)} as int: '{testValue}'");
            Console.WriteLine($"After implicit cast as long (64-bit value): '{int128Value}'");
            Console.WriteLine($"After explicit cast as short: '{shortValue}'");

            Console.WriteLine($"Size of a long: {sizeOfLong}");
        }

        #endregion Simple examples

        #region Advanced examples

        /// <summary>
        /// Runs more advanced examples with long data type.
        /// </summary>
        internal static void RunAdvancedExample()
        {
        }

        #endregion Advanced examples
    }

}
