// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DALContainer.cs" company="">
//   
// </copyright>
// <summary>
//   The dal container.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System.Collections.Generic;

    using MySql.Data.MySqlClient;

    using ObjectLayer;

    /// <summary>
    /// The dal container.
    /// </summary>
    public class DALContainer
    {
        #region Public Methods and Operators

        /// <summary>
        /// The get companies from database.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Company> GetCompanies()
        {
            var companylist = new List<Company>();

            using (var db = new Database())
            {
                Company companies = null;
                db.OpenConnection();
                db.CreateCommand("Select * from company");

                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    companies = new Company();
                    companies.id = (int)dr["id"];
                    companies.name = (string)dr["name"];
                    companylist.Add(companies);
                }
            }

            return companylist;
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
        public List<Container> GetContainers(string ship, string port)
        {
            var containerlist = new List<Container>();

            using (var db = new Database())
            {
                Container containers = null;
                db.OpenConnection();
                db.CreateCommand(
                    "Select Container.*,Company.Name AS name,Ship.type AS shiptype from Container,Ship,Port,Company WHERE Ship.Type LIKE @ship AND Port.Name LIKE @port AND Company.ID = Container.Company_ID AND Ship.ID = Container.Ship_ID");
                db.AddParameter("@ship", ship);
                db.AddParameter("@port", port);

                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    containers = new Container();
                    containers.id = (int)dr["id"];
                    containers.type = (string)dr["type"];
                    containers.weight = (int)dr["weight"];
                    containers.onship = (string)dr["shiptype"];
                    containers.companyname = (string)dr["name"];
                    containerlist.Add(containers);
                }
            }

            return containerlist;
        }

        #endregion
    }
}