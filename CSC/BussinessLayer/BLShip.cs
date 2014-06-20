// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BLShip.cs" company="">
//   
// </copyright>
// <summary>
//   The bl ship.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BussinessLayer
{
    using System.Collections.Generic;

    using DataAccessLayer;

    using ObjectLayer;

    /// <summary>
    /// The bl ship.
    /// </summary>
    public class BLShip
    {
        #region Public Methods and Operators

        /// <summary>
        /// The get ships.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<Ship> GetShips()
        {
            var port = new DALShip();
            return port.GetShips();
        }

        #endregion
    }
}