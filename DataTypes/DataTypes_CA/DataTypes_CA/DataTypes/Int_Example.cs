// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

namespace DataTypes_CA.DataTypes
{
    /// <summary>
    /// Examples related to the Int data type.
    /// </summary>
    internal class Int_Example
    {
        #region Simple examples

        /// <summary>
        /// Displays simple integer examples in the console.
        /// </summary>
        internal static void RunExample()
        {

            // Signed integer
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;

            int testValue = 100;
            long longValue = testValue; // Implicit cast
            short shortValue = (short)testValue; // Explicit cast

            // Size of integer is 4 Bytes = 32 bits
            int sizeOfInt = sizeof(int);

            Console.WriteLine(Helpers.GetConsoleOutputHeader());

            Console.WriteLine($"{nameof(minValue)} = '{minValue}'");
            Console.WriteLine($"{nameof(maxValue)} = '{maxValue}'");
            Console.WriteLine($"{nameof(testValue)} as int: '{testValue}'");
            Console.WriteLine($"After implicit cast as long (64-bit value): '{longValue}'");
            Console.WriteLine($"After explicit cast as short: '{shortValue}'");

            Console.WriteLine($"Size of a short: {sizeOfInt}");
        }

        #endregion Simple examples

        #region Advanced examples

        /// <summary>
        /// Runs more advanced examples with integer data type.
        /// </summary>
        internal static void RunAdvancedExample()
        {
        }

        #endregion Advanced examples
    }
}