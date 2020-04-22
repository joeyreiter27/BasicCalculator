using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{

    /// <summary>
    /// Type of operation the calculator can perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Adds two values together
        /// </summary>
        Add,
        /// <summary>
        /// Minuses two values
        /// </summary>
        Minus,
        /// <summary>
        /// Divides two values
        /// </summary>
        Divide,
        /// <summary>
        /// Multiplies two values
        /// </summary>
        Multiply
    }
}
