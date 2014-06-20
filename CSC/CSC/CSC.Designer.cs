namespace CSC
{
    partial class CSC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabContainer = new System.Windows.Forms.TabPage();
            this.lbGood = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboContainerOnShip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.btAddCompany = new System.Windows.Forms.Button();
            this.lbNewCompany = new System.Windows.Forms.Label();
            this.tbAddCompany = new System.Windows.Forms.TextBox();
            this.comboBedrijfsNaam = new System.Windows.Forms.ComboBox();
            this.btAddContainer = new System.Windows.Forms.Button();
            this.lbGewicht = new System.Windows.Forms.Label();
            this.numricWeight = new System.Windows.Forms.NumericUpDown();
            this.lbTypeContainer = new System.Windows.Forms.Label();
            this.comboContainerType = new System.Windows.Forms.ComboBox();
            this.lbBedrijf = new System.Windows.Forms.Label();
            this.tabIndeling = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.lbLegend = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbLayout = new System.Windows.Forms.Label();
            this.tbLayout = new System.Windows.Forms.TextBox();
            this.comboBestemming = new System.Windows.Forms.ComboBox();
            this.comboTypeSchip = new System.Windows.Forms.ComboBox();
            this.lbBestemming = new System.Windows.Forms.Label();
            this.lbTypeSchip = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbComGood = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricWeight)).BeginInit();
            this.tabIndeling.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabContainer);
            this.TabControl.Controls.Add(this.tabIndeling);
            this.TabControl.Location = new System.Drawing.Point(2, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(469, 443);
            this.TabControl.TabIndex = 0;
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.lbComGood);
            this.tabContainer.Controls.Add(this.lbGood);
            this.tabContainer.Controls.Add(this.label7);
            this.tabContainer.Controls.Add(this.comboContainerOnShip);
            this.tabContainer.Controls.Add(this.label6);
            this.tabContainer.Controls.Add(this.comboPort);
            this.tabContainer.Controls.Add(this.label5);
            this.tabContainer.Controls.Add(this.lbError);
            this.tabContainer.Controls.Add(this.btAddCompany);
            this.tabContainer.Controls.Add(this.lbNewCompany);
            this.tabContainer.Controls.Add(this.tbAddCompany);
            this.tabContainer.Controls.Add(this.comboBedrijfsNaam);
            this.tabContainer.Controls.Add(this.btAddContainer);
            this.tabContainer.Controls.Add(this.lbGewicht);
            this.tabContainer.Controls.Add(this.numricWeight);
            this.tabContainer.Controls.Add(this.lbTypeContainer);
            this.tabContainer.Controls.Add(this.comboContainerType);
            this.tabContainer.Controls.Add(this.lbBedrijf);
            this.tabContainer.Location = new System.Drawing.Point(4, 22);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.Padding = new System.Windows.Forms.Padding(3);
            this.tabContainer.Size = new System.Drawing.Size(461, 417);
            this.tabContainer.TabIndex = 0;
            this.tabContainer.Text = "Container Toevoegen";
            this.tabContainer.UseVisualStyleBackColor = true;
            // 
            // lbGood
            // 
            this.lbGood.AutoSize = true;
            this.lbGood.Location = new System.Drawing.Point(88, 167);
            this.lbGood.Name = "lbGood";
            this.lbGood.Size = new System.Drawing.Size(131, 13);
            this.lbGood.TabIndex = 16;
            this.lbGood.Text = "Container invoeren gelukt!";
            this.lbGood.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min: 4000kg   Max: 30000kg";
            // 
            // comboContainerOnShip
            // 
            this.comboContainerOnShip.FormattingEnabled = true;
            this.comboContainerOnShip.Location = new System.Drawing.Point(109, 110);
            this.comboContainerOnShip.Name = "comboContainerOnShip";
            this.comboContainerOnShip.Size = new System.Drawing.Size(121, 21);
            this.comboContainerOnShip.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Schip:";
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(109, 78);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(121, 21);
            this.comboPort.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bestemming:";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(265, 91);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 10;
            // 
            // btAddCompany
            // 
            this.btAddCompany.Location = new System.Drawing.Point(343, 57);
            this.btAddCompany.Name = "btAddCompany";
            this.btAddCompany.Size = new System.Drawing.Size(100, 23);
            this.btAddCompany.TabIndex = 9;
            this.btAddCompany.Text = "Toevoegen";
            this.btAddCompany.UseVisualStyleBackColor = true;
            this.btAddCompany.Click += new System.EventHandler(this.btAddCompany_Click);
            // 
            // lbNewCompany
            // 
            this.lbNewCompany.AutoSize = true;
            this.lbNewCompany.Location = new System.Drawing.Point(241, 21);
            this.lbNewCompany.Name = "lbNewCompany";
            this.lbNewCompany.Size = new System.Drawing.Size(102, 13);
            this.lbNewCompany.TabIndex = 8;
            this.lbNewCompany.Text = " <== Nieuw Bedrijf  :";
            // 
            // tbAddCompany
            // 
            this.tbAddCompany.Location = new System.Drawing.Point(343, 18);
            this.tbAddCompany.Name = "tbAddCompany";
            this.tbAddCompany.Size = new System.Drawing.Size(100, 20);
            this.tbAddCompany.TabIndex = 7;
            // 
            // comboBedrijfsNaam
            // 
            this.comboBedrijfsNaam.FormattingEnabled = true;
            this.comboBedrijfsNaam.Location = new System.Drawing.Point(109, 18);
            this.comboBedrijfsNaam.Name = "comboBedrijfsNaam";
            this.comboBedrijfsNaam.Size = new System.Drawing.Size(121, 21);
            this.comboBedrijfsNaam.TabIndex = 6;
            // 
            // btAddContainer
            // 
            this.btAddContainer.Location = new System.Drawing.Point(77, 183);
            this.btAddContainer.Name = "btAddContainer";
            this.btAddContainer.Size = new System.Drawing.Size(153, 23);
            this.btAddContainer.TabIndex = 5;
            this.btAddContainer.Text = "Toevoegen";
            this.btAddContainer.UseVisualStyleBackColor = true;
            this.btAddContainer.Click += new System.EventHandler(this.btAddContainer_Click);
            // 
            // lbGewicht
            // 
            this.lbGewicht.AutoSize = true;
            this.lbGewicht.Location = new System.Drawing.Point(24, 143);
            this.lbGewicht.Name = "lbGewicht";
            this.lbGewicht.Size = new System.Drawing.Size(49, 13);
            this.lbGewicht.TabIndex = 4;
            this.lbGewicht.Text = "Gewicht:";
            // 
            // numricWeight
            // 
            this.numricWeight.Location = new System.Drawing.Point(109, 141);
            this.numricWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numricWeight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numricWeight.Name = "numricWeight";
            this.numricWeight.Size = new System.Drawing.Size(71, 20);
            this.numricWeight.TabIndex = 3;
            this.numricWeight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // lbTypeContainer
            // 
            this.lbTypeContainer.AutoSize = true;
            this.lbTypeContainer.Location = new System.Drawing.Point(24, 52);
            this.lbTypeContainer.Name = "lbTypeContainer";
            this.lbTypeContainer.Size = new System.Drawing.Size(82, 13);
            this.lbTypeContainer.TabIndex = 2;
            this.lbTypeContainer.Text = "Type Container:";
            // 
            // comboContainerType
            // 
            this.comboContainerType.FormattingEnabled = true;
            this.comboContainerType.Location = new System.Drawing.Point(109, 49);
            this.comboContainerType.Name = "comboContainerType";
            this.comboContainerType.Size = new System.Drawing.Size(121, 21);
            this.comboContainerType.TabIndex = 1;
            // 
            // lbBedrijf
            // 
            this.lbBedrijf.AutoSize = true;
            this.lbBedrijf.Location = new System.Drawing.Point(24, 21);
            this.lbBedrijf.Name = "lbBedrijf";
            this.lbBedrijf.Size = new System.Drawing.Size(73, 13);
            this.lbBedrijf.TabIndex = 0;
            this.lbBedrijf.Text = "Bedrijfs naam:";
            // 
            // tabIndeling
            // 
            this.tabIndeling.Controls.Add(this.label8);
            this.tabIndeling.Controls.Add(this.label4);
            this.tabIndeling.Controls.Add(this.label3);
            this.tabIndeling.Controls.Add(this.label2);
            this.tabIndeling.Controls.Add(this.label1);
            this.tabIndeling.Controls.Add(this.btGenerate);
            this.tabIndeling.Controls.Add(this.lbLegend);
            this.tabIndeling.Controls.Add(this.btExport);
            this.tabIndeling.Controls.Add(this.textBox1);
            this.tabIndeling.Controls.Add(this.lbLayout);
            this.tabIndeling.Controls.Add(this.tbLayout);
            this.tabIndeling.Controls.Add(this.comboBestemming);
            this.tabIndeling.Controls.Add(this.comboTypeSchip);
            this.tabIndeling.Controls.Add(this.lbBestemming);
            this.tabIndeling.Controls.Add(this.lbTypeSchip);
            this.tabIndeling.Location = new System.Drawing.Point(4, 22);
            this.tabIndeling.Name = "tabIndeling";
            this.tabIndeling.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndeling.Size = new System.Drawing.Size(492, 417);
            this.tabIndeling.TabIndex = 1;
            this.tabIndeling.Text = "Indeling Genereren";
            this.tabIndeling.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Selecteer het type ship en  de bestemming";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(330, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "C = Normale Container";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(330, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "E = Gecoolde Contrainer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(330, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "V = Waardevolle Container";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(330, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "_ = Lege Container";
            // 
            // btGenerate
            // 
            this.btGenerate.Enabled = false;
            this.btGenerate.Location = new System.Drawing.Point(108, 71);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 9;
            this.btGenerate.Text = "Genereer";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // lbLegend
            // 
            this.lbLegend.AutoSize = true;
            this.lbLegend.Location = new System.Drawing.Point(374, 121);
            this.lbLegend.Name = "lbLegend";
            this.lbLegend.Size = new System.Drawing.Size(49, 13);
            this.lbLegend.TabIndex = 8;
            this.lbLegend.Text = "Legenda";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(25, 381);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(180, 23);
            this.btExport.TabIndex = 7;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(325, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 121);
            this.textBox1.TabIndex = 6;
            // 
            // lbLayout
            // 
            this.lbLayout.AutoSize = true;
            this.lbLayout.Location = new System.Drawing.Point(22, 121);
            this.lbLayout.Name = "lbLayout";
            this.lbLayout.Size = new System.Drawing.Size(44, 13);
            this.lbLayout.TabIndex = 5;
            this.lbLayout.Text = "Indeling";
            // 
            // tbLayout
            // 
            this.tbLayout.Location = new System.Drawing.Point(22, 140);
            this.tbLayout.Multiline = true;
            this.tbLayout.Name = "tbLayout";
            this.tbLayout.ReadOnly = true;
            this.tbLayout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLayout.Size = new System.Drawing.Size(253, 223);
            this.tbLayout.TabIndex = 4;
            // 
            // comboBestemming
            // 
            this.comboBestemming.FormattingEnabled = true;
            this.comboBestemming.Location = new System.Drawing.Point(108, 43);
            this.comboBestemming.Name = "comboBestemming";
            this.comboBestemming.Size = new System.Drawing.Size(121, 21);
            this.comboBestemming.TabIndex = 3;
            this.comboBestemming.SelectedIndexChanged += new System.EventHandler(this.comboBestemming_SelectedIndexChanged);
            // 
            // comboTypeSchip
            // 
            this.comboTypeSchip.FormattingEnabled = true;
            this.comboTypeSchip.Location = new System.Drawing.Point(108, 13);
            this.comboTypeSchip.Name = "comboTypeSchip";
            this.comboTypeSchip.Size = new System.Drawing.Size(121, 21);
            this.comboTypeSchip.TabIndex = 2;
            // 
            // lbBestemming
            // 
            this.lbBestemming.AutoSize = true;
            this.lbBestemming.Location = new System.Drawing.Point(19, 46);
            this.lbBestemming.Name = "lbBestemming";
            this.lbBestemming.Size = new System.Drawing.Size(67, 13);
            this.lbBestemming.TabIndex = 1;
            this.lbBestemming.Text = "Bestemming:";
            // 
            // lbTypeSchip
            // 
            this.lbTypeSchip.AutoSize = true;
            this.lbTypeSchip.Location = new System.Drawing.Point(19, 16);
            this.lbTypeSchip.Name = "lbTypeSchip";
            this.lbTypeSchip.Size = new System.Drawing.Size(64, 13);
            this.lbTypeSchip.TabIndex = 0;
            this.lbTypeSchip.Text = "Type Schip:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbComGood
            // 
            this.lbComGood.AutoSize = true;
            this.lbComGood.Location = new System.Drawing.Point(338, 41);
            this.lbComGood.Name = "lbComGood";
            this.lbComGood.Size = new System.Drawing.Size(112, 13);
            this.lbComGood.TabIndex = 17;
            this.lbComGood.Text = "Bedrijf invoeren gelukt";
            this.lbComGood.Visible = false;
            // 
            // CSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 454);
            this.Controls.Add(this.TabControl);
            this.Name = "CSC";
            this.Text = "CSC";
            this.Load += new System.EventHandler(this.CSC_Load);
            this.TabControl.ResumeLayout(false);
            this.tabContainer.ResumeLayout(false);
            this.tabContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricWeight)).EndInit();
            this.tabIndeling.ResumeLayout(false);
            this.tabIndeling.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabContainer;
        private System.Windows.Forms.TabPage tabIndeling;
        private System.Windows.Forms.Label lbBedrijf;
        private System.Windows.Forms.ComboBox comboContainerType;
        private System.Windows.Forms.Label lbTypeContainer;
        private System.Windows.Forms.Label lbGewicht;
        private System.Windows.Forms.NumericUpDown numricWeight;
        private System.Windows.Forms.Label lbTypeSchip;
        private System.Windows.Forms.TextBox tbAddCompany;
        private System.Windows.Forms.ComboBox comboBedrijfsNaam;
        private System.Windows.Forms.Button btAddContainer;
        private System.Windows.Forms.ComboBox comboBestemming;
        private System.Windows.Forms.ComboBox comboTypeSchip;
        private System.Windows.Forms.Label lbBestemming;
        private System.Windows.Forms.Button btAddCompany;
        private System.Windows.Forms.Label lbNewCompany;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbLayout;
        private System.Windows.Forms.TextBox tbLayout;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label lbLegend;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContainerOnShip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbGood;
        private System.Windows.Forms.Label lbComGood;
    }
}