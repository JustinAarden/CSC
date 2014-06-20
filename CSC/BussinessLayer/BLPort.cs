// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BLPort.cs" company="">
//   
// </copyright>
// <summary>
//   The bl port.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BussinessLayer
{
    using System.Collections.Generic;

    using DataAccessLayer;

    using ObjectLayer;

    /// <summary>
    /// The bl port.
    /// </summary>
    public class BLPort
    {
        #region Public Methods and Operators

        /// <summary>
        /// The get ports.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<Port> GetPorts()
        {
            var port = new DALPort();
            return port.GetPorts();
        }

        #endregion
    }
}