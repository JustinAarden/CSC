// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Container.cs" company="">
//   
// </copyright>
// <summary>
//   The container.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectLayer
{
    /// <summary>
    /// The container.
    /// </summary>
    public class Container : MainObject
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the companyname.
        /// </summary>
        public string companyname { get; set; }

        /// <summary>
        /// Gets or sets the onship Yes/No.
        /// </summary>
        public string onship { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        public int weight { get; set; }

        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        public int y { get; set; }

        /// <summary>
        /// Gets or sets the z.
        /// </summary>
        public int z { get; set; }

        #endregion
    }
}