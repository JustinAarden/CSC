// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BLContainer.cs" company="">
//   
// </copyright>
// <summary>
//   The bl container.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BussinessLayer
{
    using System.Collections.Generic;

    using DataAccessLayer;

    using ObjectLayer;

    /// <summary>
    /// The bl container.
    /// </summary>
    public class BLContainer
    {
        #region Public Methods and Operators

        /// <summary>
        /// The get companies.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<Company> GetCompanies()
        {
            var company = new DALContainer();
            return company.GetCompanies();
        }

        /// <summary>
        /// The get containers.
        /// </summary>
        /// <param name="ship">
        /// The ship.
        /// </param>
        /// <param name="port">
        /// The port.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<Container> GetContainers(string ship, string port)
        {
            var container = new DALContainer();
            return container.GetContainers(ship, port);
        }

        #endregion
    }
}