// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\
// ||                                                    || \\
// ||    <Author>       Majk Ritcherd       </Author>    || \\
// ||                                                    || \\
// ||~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|| \\

using System.Text;

namespace DataTypes_CA
{
    /// <summary>
    /// Helper methods.
    /// </summary>
    internal static class Helpers
    {
        /// <summary>
        /// Gets Output header.
        /// </summary>
        /// <returns></returns>
        internal static string GetConsoleOutputHeader()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Output");
            sb.AppendLine("-------------------");

            return sb.ToString();
        }
    }
}