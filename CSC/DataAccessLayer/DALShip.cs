// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DALShip.cs" company="">
//   
// </copyright>
// <summary>
//   The dal ship.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DataAccessLayer
{
    using System.Collections.Generic;

    using MySql.Data.MySqlClient;

    using ObjectLayer;

    /// <summary>
    ///     The dal ship.
    /// </summary>
    public class DALShip
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The get ships from database.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Ship> GetShips()
        {
            var shiplist = new List<Ship>();

            using (var db = new Database())
            {
                Ship ships = null;
                db.OpenConnection();
                db.CreateCommand("Select * FROM ship");
                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    ships = new Ship();
                    ships.type = (string)dr["type"];
                    ships.height = (int)dr["height"];
                    ships.length = (int)dr["Length"];
                    ships.width = (int)dr["width"];
                    ships.power = (int)dr["poweroutlet"];
                    shiplist.Add(ships);
                }
            }

            return shiplist;
        }

        #endregion
    }
}