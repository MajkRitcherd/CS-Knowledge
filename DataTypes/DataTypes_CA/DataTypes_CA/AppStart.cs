// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

using DataTypes_CA.DataTypes;

namespace DataTypes_CA
{
    /// <summary>
    /// Application's start.
    /// </summary>
    internal class AppStart
    {
        /// <summary>
        /// Method called when the application starts.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public static void Main(string[] args)
        {
            // -----------------------------------------------
            //                     BOOL
            // -----------------------------------------------
            Bool_Examples.RunExample();
            //Bool_Examples.RunAdvancedExample();

            // -----------------------------------------------
            //                     CHAR
            // -----------------------------------------------
            //Char_Examples.RunExample();
            //Char_Examples.RunMathematicalOperationsExample();
        }
    }
}