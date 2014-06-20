// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Database.cs" company="">
//   
// </copyright>
// <summary>
//   Class used for the database interaction in the application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DataAccessLayer
{
    using System;
    using System.Data;
    using System.Diagnostics;

    using MySql.Data.MySqlClient;

    /// <summary>
    ///     Class used for the database interaction in the application.
    /// </summary>
    public class Database : IDisposable
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database()
        {
            string connectionString;
            connectionString = "SERVER=" + "127.0.0.1" + ";" + "DATABASE=" + "CSC" + ";" + "UID=" + "root" + ";"
                               + "PASSWORD=" + "root" + ";";
            this.Connection = new MySqlConnection(connectionString);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the command.
        /// </summary>
        public MySqlCommand Command { get; private set; }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        public MySqlConnection Connection { get; private set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Binds a parameter to the command with the given value.
        /// </summary>
        /// <param name="parameterName">
        /// The parameter Name.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public void AddParameter(string parameterName, object value)
        {
            this.AddParameter(parameterName, value, default(MySqlDbType));
        }

        /// <summary>
        /// Binds a parameter to the command with the given value and type.
        /// </summary>
        /// <param name="parameterName">
        /// The parameter Name.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
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
        /// Creates an command and binds it to the connection.
        /// </summary>
        /// <param name="commandText">
        /// The command Text.
        /// </param>
        public void CreateCommand(string commandText)
        {
            Debug.WriteLine(commandText);

            this.Command = this.Connection.CreateCommand();
            this.Command.CommandText = commandText;
        }

        /// <summary>
        /// The dispose.
        /// </summary>
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

        #endregion
    }
}