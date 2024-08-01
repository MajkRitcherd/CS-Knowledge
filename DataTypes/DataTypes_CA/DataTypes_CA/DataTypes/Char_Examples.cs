// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

namespace DataTypes_CA.DataTypes
{
    /// <summary>
    /// Examples related to the Char data type.
    /// </summary>
    internal class Char_Examples
    {
        #region Simple examples

        /// <summary>
        /// Displays simple character examples in the console.
        /// </summary>
        internal static void RunExample()
        {
            // Single characters enclosed by single quote
            char letter = 'A';
            char digit = '1';

            // In C#, we cannot directly use numbers to represent a char
            //  Explicit cast is needed
            char letterA = (char)65; // Equals to 'A'

            // Size of char is 2 Bytes = 16 bits
            int sizeOfChar = sizeof(char);

            Console.WriteLine(Helpers.GetConsoleOutputHeader());

            Console.WriteLine($"{nameof(letter)} = '{letter}'");
            Console.WriteLine($"{nameof(digit)} = '{digit}'");
            Console.WriteLine($"{nameof(letterA)} = '{letterA}'");

            Console.WriteLine($"Size of a char: {sizeOfChar}");
        }

        /// <summary>
        /// Shows simple operations done on character's using mathematical examples.
        /// </summary>
        internal static void RunMathematicalOperationsExample()
        {
            // Let's create character 'a' (ASCII code: 97) by summing 2 characters
            //  and character 'P' (ASCII code: 80) by subtracting 2 characters
            char char40 = (char)40;   // '('
            char char57 = (char)57;   // '9'
            char char120 = (char)120; // 'x'

            char a = (char)(char40 + char57);
            char P = (char)(char120 - char40);

            Console.WriteLine(Helpers.GetConsoleOutputHeader());

            Console.WriteLine($"{nameof(char40)} = '{char40}'");
            Console.WriteLine($"{nameof(char57)} = '{char57}'");
            Console.WriteLine($"{nameof(char120)} = '{char120}'");

            Console.WriteLine($"Character after sum is: '{a}' (ASCII code: {(int)a})");
            Console.WriteLine($"Character after subtraction is: '{P}' (ASCII code: {(int)P})");
        }

        #endregion Simple examples

        #region Advanced examples

        /// <summary>
        /// Runs more advanced examples with char data type.
        /// </summary>
        internal static void RunAdvancedExample()
        {
        }

        #endregion Advanced examples
    }
}