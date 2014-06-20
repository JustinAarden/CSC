// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ship.cs" company="">
//   
// </copyright>
// <summary>
//   The ship.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectLayer
{
    /// <summary>
    /// The ship.
    /// </summary>
    public class Ship : MainObject
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public int length { get; set; }

        /// <summary>
        /// Gets or sets the power.
        /// </summary>
        public int power { get; set; }

        /// <summary>
        /// Gets or sets the shipcontainer.
        /// </summary>
        public string shipcontainer { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public int width { get; set; }

        #endregion
    }
}