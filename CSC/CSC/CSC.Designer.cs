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
            this.btAddCompany = new System.Windows.Forms.Button();
            this.lbNewCompany = new System.Windows.Forms.Label();
            this.tbAddCompany = new System.Windows.Forms.TextBox();
            this.comboBedrijfsNaam = new System.Windows.Forms.ComboBox();
            this.btAddContainer = new System.Windows.Forms.Button();
            this.lbGewicht = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbTypeContainer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbBedrijf = new System.Windows.Forms.Label();
            this.tabIndeling = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbLayout = new System.Windows.Forms.Label();
            this.tbLayout = new System.Windows.Forms.TextBox();
            this.comboBestemming = new System.Windows.Forms.ComboBox();
            this.comboTypeSchip = new System.Windows.Forms.ComboBox();
            this.lbBestemming = new System.Windows.Forms.Label();
            this.lbTypeSchip = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btExport = new System.Windows.Forms.Button();
            this.lbLegend = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.TabControl.Size = new System.Drawing.Size(500, 443);
            this.TabControl.TabIndex = 0;
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.btAddCompany);
            this.tabContainer.Controls.Add(this.lbNewCompany);
            this.tabContainer.Controls.Add(this.tbAddCompany);
            this.tabContainer.Controls.Add(this.comboBedrijfsNaam);
            this.tabContainer.Controls.Add(this.btAddContainer);
            this.tabContainer.Controls.Add(this.lbGewicht);
            this.tabContainer.Controls.Add(this.numericUpDown1);
            this.tabContainer.Controls.Add(this.lbTypeContainer);
            this.tabContainer.Controls.Add(this.comboBox1);
            this.tabContainer.Controls.Add(this.lbBedrijf);
            this.tabContainer.Location = new System.Drawing.Point(4, 22);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.Padding = new System.Windows.Forms.Padding(3);
            this.tabContainer.Size = new System.Drawing.Size(492, 417);
            this.tabContainer.TabIndex = 0;
            this.tabContainer.Text = "Container Toevoegen";
            this.tabContainer.UseVisualStyleBackColor = true;
            // 
            // btAddCompany
            // 
            this.btAddCompany.Location = new System.Drawing.Point(343, 47);
            this.btAddCompany.Name = "btAddCompany";
            this.btAddCompany.Size = new System.Drawing.Size(100, 23);
            this.btAddCompany.TabIndex = 9;
            this.btAddCompany.Text = "Toevoegen";
            this.btAddCompany.UseVisualStyleBackColor = true;
            // 
            // lbNewCompany
            // 
            this.lbNewCompany.AutoSize = true;
            this.lbNewCompany.Location = new System.Drawing.Point(265, 21);
            this.lbNewCompany.Name = "lbNewCompany";
            this.lbNewCompany.Size = new System.Drawing.Size(72, 13);
            this.lbNewCompany.TabIndex = 8;
            this.lbNewCompany.Text = "Nieuw Bedrijf:";
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
            this.btAddContainer.Location = new System.Drawing.Point(27, 140);
            this.btAddContainer.Name = "btAddContainer";
            this.btAddContainer.Size = new System.Drawing.Size(153, 23);
            this.btAddContainer.TabIndex = 5;
            this.btAddContainer.Text = "Toevoegen";
            this.btAddContainer.UseVisualStyleBackColor = true;
            // 
            // lbGewicht
            // 
            this.lbGewicht.AutoSize = true;
            this.lbGewicht.Location = new System.Drawing.Point(24, 93);
            this.lbGewicht.Name = "lbGewicht";
            this.lbGewicht.Size = new System.Drawing.Size(49, 13);
            this.lbGewicht.TabIndex = 4;
            this.lbGewicht.Text = "Gewicht:";
            this.lbGewicht.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 91);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            30000,
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
            this.lbTypeContainer.Click += new System.EventHandler(this.lbTypeContainer_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lbBedrijf
            // 
            this.lbBedrijf.AutoSize = true;
            this.lbBedrijf.Location = new System.Drawing.Point(24, 21);
            this.lbBedrijf.Name = "lbBedrijf";
            this.lbBedrijf.Size = new System.Drawing.Size(73, 13);
            this.lbBedrijf.TabIndex = 0;
            this.lbBedrijf.Text = "Bedrijfs naam:";
            this.lbBedrijf.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabIndeling
            // 
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 223);
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
            this.tbLayout.Size = new System.Drawing.Size(284, 223);
            this.tbLayout.TabIndex = 4;
            // 
            // comboBestemming
            // 
            this.comboBestemming.FormattingEnabled = true;
            this.comboBestemming.Location = new System.Drawing.Point(108, 43);
            this.comboBestemming.Name = "comboBestemming";
            this.comboBestemming.Size = new System.Drawing.Size(121, 21);
            this.comboBestemming.TabIndex = 3;
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
            this.lbTypeSchip.Click += new System.EventHandler(this.label2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(25, 381);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(180, 23);
            this.btExport.TabIndex = 7;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
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
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(108, 71);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 9;
            this.btGenerate.Text = "Genereer";
            this.btGenerate.UseVisualStyleBackColor = true;
            // 
            // CSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 454);
            this.Controls.Add(this.TabControl);
            this.Name = "CSC";
            this.Text = "CSC";
            this.Load += new System.EventHandler(this.CSC_Load);
            this.TabControl.ResumeLayout(false);
            this.tabContainer.ResumeLayout(false);
            this.tabContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabIndeling.ResumeLayout(false);
            this.tabIndeling.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabContainer;
        private System.Windows.Forms.TabPage tabIndeling;
        private System.Windows.Forms.Label lbBedrijf;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbTypeContainer;
        private System.Windows.Forms.Label lbGewicht;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbLayout;
        private System.Windows.Forms.TextBox tbLayout;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label lbLegend;
        private System.Windows.Forms.Button btExport;
    }
}