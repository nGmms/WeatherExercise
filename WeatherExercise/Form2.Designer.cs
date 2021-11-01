
namespace WeatherExercise
{
    partial class settingsForm
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
            this.preferredUnitLabel = new System.Windows.Forms.Label();
            this.celsiusRadioButton = new System.Windows.Forms.RadioButton();
            this.fahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // preferredUnitLabel
            // 
            this.preferredUnitLabel.AutoSize = true;
            this.preferredUnitLabel.Location = new System.Drawing.Point(31, 21);
            this.preferredUnitLabel.Name = "preferredUnitLabel";
            this.preferredUnitLabel.Size = new System.Drawing.Size(72, 13);
            this.preferredUnitLabel.TabIndex = 0;
            this.preferredUnitLabel.Text = "Preferred Unit";
            // 
            // celsiusRadioButton
            // 
            this.celsiusRadioButton.AutoSize = true;
            this.celsiusRadioButton.Location = new System.Drawing.Point(109, 21);
            this.celsiusRadioButton.Name = "celsiusRadioButton";
            this.celsiusRadioButton.Size = new System.Drawing.Size(72, 17);
            this.celsiusRadioButton.TabIndex = 1;
            this.celsiusRadioButton.TabStop = true;
            this.celsiusRadioButton.Text = "Celsius °C";
            this.celsiusRadioButton.UseVisualStyleBackColor = true;
            // 
            // fahrenheitRadioButton
            // 
            this.fahrenheitRadioButton.AutoSize = true;
            this.fahrenheitRadioButton.Location = new System.Drawing.Point(109, 44);
            this.fahrenheitRadioButton.Name = "fahrenheitRadioButton";
            this.fahrenheitRadioButton.Size = new System.Drawing.Size(88, 17);
            this.fahrenheitRadioButton.TabIndex = 2;
            this.fahrenheitRadioButton.TabStop = true;
            this.fahrenheitRadioButton.Text = "Fahrenheit °F";
            this.fahrenheitRadioButton.UseVisualStyleBackColor = true;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 85);
            this.Controls.Add(this.fahrenheitRadioButton);
            this.Controls.Add(this.celsiusRadioButton);
            this.Controls.Add(this.preferredUnitLabel);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preferredUnitLabel;
        private System.Windows.Forms.RadioButton celsiusRadioButton;
        private System.Windows.Forms.RadioButton fahrenheitRadioButton;
    }
}