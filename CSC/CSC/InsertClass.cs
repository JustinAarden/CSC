using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
namespace CSC
{
    using System.Data;

    using ObjectLayer;

    public  class InsertClass : IDisposable
    {

        public InsertClass()
         {
                     string connectionString;
        connectionString = "SERVER=" +"127.0.0.1" + ";" + "DATABASE=" + 
		"CSC" + ";" + "UID=" + "root"+ ";" + "PASSWORD=" + "root" + ";";
        this.Connection = new MySqlConnection(connectionString);
         }
        public MySqlCommand Command { get; private set; }

        public MySqlConnection Connection { get; private set; }

       public void AddParameter(string parameterName, object value)
        {
            this.AddParameter(parameterName, value, default(MySqlDbType));
        }

        /// <summary>
        ///     Binds a parameter to the command with the given value and type.
        /// </summary>
        public void AddParameter(string parameterName, object value, MySqlDbType type)
        {
            var parameter = new MySqlParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;
            this.Command.Parameters.Add(parameter);
        }

        /// <summary>
        ///     Closes the database connection.
        /// </summary>
        public void CloseConnection()
        {
            if (this.Connection.State != ConnectionState.Closed)
            {
                this.Connection.Close();
            }
        }

        /// <summary>
        ///     Creates an command and binds it to the connection.
        /// </summary>
        public void CreateCommand(string commandText)
        {
            this.Command = this.Connection.CreateCommand();
            this.Command.CommandText = commandText;
        }

        public void Dispose()
        {
            this.CloseConnection();
        }

        /// <summary>
        ///     Opens the database connection.
        /// </summary>
        public void OpenConnection()
        {
            if (this.Connection.State != ConnectionState.Open)
            {
                this.Connection.Open();
            }
        }



        public void AddCompanies(string companynamein)
        {
            using (var db = new InsertClass())
            {
                db.OpenConnection();
                db.CreateCommand("INSERT INTO Company(id,Maincompany_ID,Name) VALUES (@id,@maincompany,@name)");
                db.AddParameter("@name", companynamein);
                db.AddParameter("@id", "");
                db.AddParameter("@maincompany", "");

                db.Command.ExecuteNonQuery();
            }

        }


        public void AddContainer(string containertype,string weight, string companyname,string port,string ship)
        {

            using (var db = new InsertClass())
            {
                db.OpenConnection();
                db.CreateCommand("INSERT INTO CONTAINER (id, Company_ID, GPS_ID,Ship_ID,Port_ID,Weight,Type,transported)SELECT @id AS id, company.id, 1 AS GPS_ID, ship.id,port.id, @weight AS Weight, @type As type, 0 as transported FROM Company,Port,Ship WHERE Company.name = @companyname AND Port.Name = @port AND Ship.Type = @ship");
                //WITHOUT SHIP db.CreateCommand("INSERT INTO CONTAINER (id, Company_ID, GPS_ID,Ship_ID,Port_ID,Weight,Type,transported)SELECT @id AS id, company.id, 1 AS GPS_ID, 1 AS Ship_ID,port.id, @weight AS Weight, @type As type, 0 as transported FROM Company,Port,Ship WHERE Company.name = @companyname AND Port.Name = @port");
                db.AddParameter("@id", "");
                db.AddParameter("@type", containertype);
                db.AddParameter("@ship", ship);
                db.AddParameter("@port", port);
                db.AddParameter("@weight", weight);
                db.AddParameter("@companyname", companyname);

                db.Command.ExecuteNonQuery();
            }

        }
    }
}
