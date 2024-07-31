// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

namespace DataTypes_CA.DataTypes
{
    /// <summary>
    /// Examples related to the bool data type.
    /// </summary>
    internal class Bool_Examples
    {
        #region Simple examples

        /// <summary>
        /// Displayes simple bool examples in the console.
        /// </summary>
        internal static void RunExample()
        {
            bool boolT = true;
            bool notBoolT = !boolT;                 // false
            bool isTrue = boolT && boolT;           // true
            bool isNotTrue = notBoolT && notBoolT;  // false
            isTrue = isTrue || notBoolT;            // true
            isNotTrue = notBoolT || notBoolT;       // false

            // Size of a bool is 1 Byte = 8 bits in C#
            int sizeOfBool = sizeof(bool);

            Console.WriteLine(Helpers.GetConsoleOutputHeader());

            Console.WriteLine($"{nameof(boolT)} = '{boolT}'");
            Console.WriteLine($"{nameof(notBoolT)} = '{notBoolT}'");
            Console.WriteLine($"{nameof(isTrue)} = '{isTrue}'");
            Console.WriteLine($"{nameof(isNotTrue)} = '{isNotTrue}'");

            Console.WriteLine($"Size of a bool: {sizeOfBool}");
        }

        #endregion Simple examples

        #region Advanced examples

        /// <summary>
        /// Runs more advanced examples with bool data type.
        /// </summary>
        internal static void RunAdvancedExample()
        {
        }

        #endregion Advanced examples
    }
}