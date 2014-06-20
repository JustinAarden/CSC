// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DALPort.cs" company="">
//   
// </copyright>
// <summary>
//   The dal port.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System.Collections.Generic;

    using MySql.Data.MySqlClient;

    using ObjectLayer;

    /// <summary>
    /// The dal port.
    /// </summary>
    public class DALPort
    {
        #region Public Methods and Operators

        /// <summary>
        /// The get ports from Database.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Port> GetPorts()
        {
            var Portlist = new List<Port>();

            using (var db = new Database())
            {
                Port ports = null;
                db.OpenConnection();
                db.CreateCommand("Select Name from Port");
                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    ports = new Port();
                    ports.name = (string)dr["name"];
                    Portlist.Add(ports);
                }
            }

            return Portlist;
        }

        #endregion
    }
}