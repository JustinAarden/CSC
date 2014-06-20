// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CSC.cs" company="">
//   
// </copyright>
// <summary>
//   The csc.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSC
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using BussinessLayer;

    using ObjectLayer;

    /// <summary>
    /// The csc.
    /// </summary>
    public partial class CSC : Form
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CSC"/> class.
        /// </summary>
        public CSC()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update list.
        /// </summary>
        public void UpdateList()
        {
            List<Port> ports = BLPort.GetPorts();
            this.comboBestemming.Items.Clear();
            this.comboPort.Items.Clear();
            foreach (Port port in ports)
            {
                this.comboBestemming.Items.Add(port.name);
                this.comboPort.Items.Add(port.name);
            }

            List<Ship> ships = BLShip.GetShips();
            this.comboTypeSchip.Items.Clear();
            this.comboContainerOnShip.Items.Clear();
            foreach (Ship ship in ships)
            {
                this.comboTypeSchip.Items.Add(ship.type);
                this.comboContainerOnShip.Items.Add(ship.type);
            }

            List<Company> companies = BLContainer.GetCompanies();
            this.comboBedrijfsNaam.Items.Clear();
            foreach (Company company in companies)
            {
                this.comboBedrijfsNaam.Items.Add(company.name);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The cs c_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CSC_Load(object sender, EventArgs e)
        {
            this.UpdateList();
            this.ContainerType();
        }

        /// <summary>
        /// The container type.
        /// </summary>
        private void ContainerType()
        {
            string[] containertype = { "_", "C", "V", "E" };
            this.comboContainerType.DataSource = containertype;
        }

        /// <summary>
        /// The bt add company_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btAddCompany_Click(object sender, EventArgs e)
        {
            var company = new InsertClass();
            if (this.tbAddCompany.Text != string.Empty)
            {
                company.AddCompanies(this.tbAddCompany.Text);
                this.UpdateList();
                this.tbAddCompany.Clear();
                lbComGood.Visible = true;
            }
            else
            {
                this.tbAddCompany.Text = "Voer bedrijfsnaam in";
            }
        }

        /// <summary>
        /// The bt add container_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btAddContainer_Click(object sender, EventArgs e)
        {
            var container = new InsertClass();
            string containertype = this.comboContainerType.SelectedItem.ToString();
            string weight = this.numricWeight.Text;
            string companyname = this.comboBedrijfsNaam.SelectedItem.ToString();
            string ship = this.comboContainerOnShip.SelectedItem.ToString();
            string port = this.comboPort.SelectedItem.ToString();
            if (containertype != null && companyname != null)
            {
                container.AddContainer(containertype, weight, companyname, port, ship); //passes everything to the insertclass
                lbGood.Visible = true;
            }
        }

        /// <summary>
        /// The bt export_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btExport_Click(object sender, EventArgs e)
        {
            {
                var folderBrowserDialog1 = new FolderBrowserDialog();

                // Set the help text description for the FolderBrowserDialog. 
                folderBrowserDialog1.Description = "Selecteer waar u het bestand wilt opslaan.";

                // Do not allow the user to create new files via the FolderBrowserDialog. 
                folderBrowserDialog1.ShowNewFolderButton = false;

                // Default to the My Documents folder. 
                folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Set a variable to the My Documents path. 
                    string comboship = this.comboTypeSchip.SelectedItem.ToString();
                    string port = this.comboBestemming.SelectedItem.ToString();
                    var company = new Company();
                    var container = new Container();
                    string date = DateTime.Now.ToString("dd-MM-yyyy"); //sets the date
                    List<Container> containers = BLContainer.GetContainers(comboship, port);
                    string mydocpath = folderBrowserDialog1.SelectedPath;
                    var str = new StringBuilder();

                    containers = containers.OrderBy(o => container.companyname).ToList(); //sorts the list on companyname
                    str.AppendLine("Gemaakt op:  " + date); //sets date in document
                    str.AppendLine();
                    str.AppendLine("Bestemming:  " + port);//sets selected desination
                    str.AppendLine();
                    str.AppendLine("Schip type:  " + comboship); //sets selected ship
                    str.AppendLine();

                    foreach (Container containerlist in containers)
                    {
                        str.AppendLine(
                            string.Format(
                                "{0}: Container ID:{1}  -  X:{2}  Y:{3}  Z:{4}", 
                                containerlist.companyname, 
                                containerlist.id, 
                                containerlist.x, 
                                containerlist.y, 
                                containerlist.z));
                    }

                    using (var outfile = new StreamWriter(mydocpath + @"\CSC Export.txt"))
                    {
                        outfile.Write(str.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// The bt generate_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btGenerate_Click(object sender, EventArgs e)
        {
            this.tbLayout.Clear();
            string comboship = this.comboTypeSchip.SelectedItem.ToString();
            string port = this.comboBestemming.SelectedItem.ToString();
            var listLayer = new List<int>();
            var listWidth = new List<int>();
            var listLength = new List<int>();
            var listNamen = new List<string>();
            var listcontainer = new List<string>();
            var containerx = new List<int>();
            var containery = new List<int>();
            var containerz = new List<int>();

            // List<Container> containers = BLContainer.GetContainers(ship,port);
            List<Ship> ships = BLShip.GetShips();
            foreach (Ship ship in ships)
            {
                listLayer.Add(ship.height);
                listWidth.Add(ship.width);
                listLength.Add(ship.length);
                listNamen.Add(ship.type);
                listcontainer.Add(ship.shipcontainer);
            }

            List<Container> containers = BLContainer.GetContainers(comboship, port);
            foreach (Container container in containers)
            {
                listcontainer.Add(container.type);
            }

            int[] layer = listLayer.ToArray();
            int[] width = listWidth.ToArray();
            int[] length = listLength.ToArray();
            string[] shiptype = listNamen.ToArray();
            string[] containertype = listcontainer.ToArray();

            int selected = int.MaxValue;

            for (int i = 0; i < shiptype.Length; i++)
            {
                if (this.comboTypeSchip.Text == shiptype[i])
                {
                    selected = i;
                }
            }

            for (int x = 0; x < layer[selected]; x++)
            {
                // hoogte
                containerx.Add(x); //Adds cordinate to container
                this.tbLayout.AppendText("Laag " + (x + 1) + " :");
                for (int y = 0; y < width[selected]; y++) // Sets value for width row1
                {
                    // breedte
                    containery.Add(y); //Adds cordinate to container

                    this.tbLayout.AppendText("\n");
                    var cooled = new StringBuilder("E ");
                    this.tbLayout.AppendText(cooled.ToString());

                    for (int z = 1; z < length[selected]; z++) //Set value from lenghtrow 1
                    {
                        // lengt
                        containerz.Add(z); //Adds cordinate to container
                        var aStringBuilder = new StringBuilder("_ ");
                        this.tbLayout.AppendText(aStringBuilder.ToString());
                    }
                }

                this.tbLayout.AppendText("\n");
                this.tbLayout.AppendText("\n");
            }
        }

        /// <summary>
        /// The label 1_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>


        #endregion

        private void comboBestemming_SelectedIndexChanged(object sender, EventArgs e)
        {
            btGenerate.Enabled = true;
        }
    }
}