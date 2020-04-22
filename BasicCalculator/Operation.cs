using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// Holds information about a single calculator operation
    /// </summary>
    class Operation
    {

        #region Public Properties

        /// <summary>
        /// The left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// The right side of the oepration
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// the type of operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// The inner operation to be performed initiall before this operation
        /// </summary>
        public Operation InnerOperation { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {

            // Creates empty strings instead of having nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
        #endregion
    }
}
