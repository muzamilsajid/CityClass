namespace CityClass
{
    partial class Form1
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
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.btnChangeCityName = new System.Windows.Forms.Button();
            this.listCityDetails = new System.Windows.Forms.ListBox();
            this.listBoxPersonDetails = new System.Windows.Forms.ListBox();
            this.listBoxPersons = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(13, 37);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(100, 20);
            this.txtCityName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City Name";
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(120, 33);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(75, 23);
            this.btnAddCity.TabIndex = 2;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.BtnAddCity_Click);
            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.Location = new System.Drawing.Point(13, 64);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(100, 264);
            this.listBoxCities.TabIndex = 3;
            this.listBoxCities.SelectedIndexChanged += new System.EventHandler(this.ListBoxCities_SelectedIndexChanged);
            // 
            // btnChangeCityName
            // 
            this.btnChangeCityName.Location = new System.Drawing.Point(201, 33);
            this.btnChangeCityName.Name = "btnChangeCityName";
            this.btnChangeCityName.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCityName.TabIndex = 4;
            this.btnChangeCityName.Text = "Change City Name:";
            this.btnChangeCityName.UseVisualStyleBackColor = true;
            this.btnChangeCityName.Click += new System.EventHandler(this.BtnChangeCityName_Click);
            // 
            // listCityDetails
            // 
            this.listCityDetails.FormattingEnabled = true;
            this.listCityDetails.Location = new System.Drawing.Point(120, 64);
            this.listCityDetails.Name = "listCityDetails";
            this.listCityDetails.Size = new System.Drawing.Size(219, 264);
            this.listCityDetails.TabIndex = 5;
            // 
            // listBoxPersonDetails
            // 
            this.listBoxPersonDetails.FormattingEnabled = true;
            this.listBoxPersonDetails.Location = new System.Drawing.Point(595, 64);
            this.listBoxPersonDetails.Name = "listBoxPersonDetails";
            this.listBoxPersonDetails.Size = new System.Drawing.Size(219, 264);
            this.listBoxPersonDetails.TabIndex = 8;
            // 
            // listBoxPersons
            // 
            this.listBoxPersons.FormattingEnabled = true;
            this.listBoxPersons.Location = new System.Drawing.Point(468, 64);
            this.listBoxPersons.Name = "listBoxPersons";
            this.listBoxPersons.Size = new System.Drawing.Size(121, 264);
            this.listBoxPersons.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(468, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(574, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(680, 35);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 10;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 503);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.listBoxPersonDetails);
            this.Controls.Add(this.listBoxPersons);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.listCityDetails);
            this.Controls.Add(this.btnChangeCityName);
            this.Controls.Add(this.listBoxCities);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCityName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.ListBox listBoxCities;
        private System.Windows.Forms.Button btnChangeCityName;
        private System.Windows.Forms.ListBox listCityDetails;
        private System.Windows.Forms.ListBox listBoxPersonDetails;
        private System.Windows.Forms.ListBox listBoxPersons;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAddPerson;
    }
}

