
namespace WeatherExercise
{
    partial class mainForm
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.localTimeLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.locationTextLabel = new System.Windows.Forms.Label();
            this.localTimeTextLabel = new System.Windows.Forms.Label();
            this.temperatureTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(53, 64);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(53, 97);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Location";
            // 
            // localTimeLabel
            // 
            this.localTimeLabel.AutoSize = true;
            this.localTimeLabel.Location = new System.Drawing.Point(53, 130);
            this.localTimeLabel.Name = "localTimeLabel";
            this.localTimeLabel.Size = new System.Drawing.Size(59, 13);
            this.localTimeLabel.TabIndex = 2;
            this.localTimeLabel.Text = "Local Time";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(53, 159);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(67, 13);
            this.temperatureLabel.TabIndex = 3;
            this.temperatureLabel.Text = "Temperature";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(132, 64);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(248, 62);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_ClickAsync);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(329, 61);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // locationTextLabel
            // 
            this.locationTextLabel.AutoSize = true;
            this.locationTextLabel.Location = new System.Drawing.Point(132, 97);
            this.locationTextLabel.Name = "locationTextLabel";
            this.locationTextLabel.Size = new System.Drawing.Size(0, 13);
            this.locationTextLabel.TabIndex = 7;
            // 
            // localTimeTextLabel
            // 
            this.localTimeTextLabel.AutoSize = true;
            this.localTimeTextLabel.Location = new System.Drawing.Point(132, 130);
            this.localTimeTextLabel.Name = "localTimeTextLabel";
            this.localTimeTextLabel.Size = new System.Drawing.Size(0, 13);
            this.localTimeTextLabel.TabIndex = 8;
            // 
            // temperatureTextLabel
            // 
            this.temperatureTextLabel.AutoSize = true;
            this.temperatureTextLabel.Location = new System.Drawing.Point(132, 159);
            this.temperatureTextLabel.Name = "temperatureTextLabel";
            this.temperatureTextLabel.Size = new System.Drawing.Size(0, 13);
            this.temperatureTextLabel.TabIndex = 9;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 221);
            this.Controls.Add(this.temperatureTextLabel);
            this.Controls.Add(this.localTimeTextLabel);
            this.Controls.Add(this.locationTextLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.localTimeLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.searchLabel);
            this.Name = "mainForm";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label localTimeLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label locationTextLabel;
        private System.Windows.Forms.Label localTimeTextLabel;
        private System.Windows.Forms.Label temperatureTextLabel;
    }
}

