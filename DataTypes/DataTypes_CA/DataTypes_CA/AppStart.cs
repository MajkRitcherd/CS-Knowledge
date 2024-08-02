// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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
            Prepare();

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
            //Char_Examples.RunAdvancedExample();

            // -----------------------------------------------
            //                     SHORT
            // -----------------------------------------------
            //Short_Example.RunExample();
            //Short_Example.RunAdvancedExample();

            // -----------------------------------------------
            //                     INT
            // -----------------------------------------------
            //Int_Example.RunExample();
            //Int_Example.RunAdvancedExample();

            // -----------------------------------------------
            //                     LONG
            // -----------------------------------------------
            //Long_Example.RunExample();
            //Long_Example.RunAdvancedExample();

            // -----------------------------------------------
            //                     FLOAT
            // -----------------------------------------------
            //Float_Example.RunExample();
            //Float_Example.RunAdvancedExample();

            // -----------------------------------------------
            //                     DOUBLE
            // -----------------------------------------------
            //Double_Example.RunExample();
            //Double_Example.RunAdvancedExamples();
        }

        /// <summary>
        /// Prepares the app.
        /// </summary>
        private static void Prepare()
        {
            // Set invariant culture
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        }
    }
}