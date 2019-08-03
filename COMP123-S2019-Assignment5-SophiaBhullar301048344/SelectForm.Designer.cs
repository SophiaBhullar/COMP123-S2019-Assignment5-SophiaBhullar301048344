namespace COMP123_S2019_Assignment5_SophiaBhullar301048344
{
    partial class SelectForm
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.MakeASelectionLabel = new System.Windows.Forms.Label();
            this.SelectedHardwareLabel = new System.Windows.Forms.Label();
            this.SelectedHarwareTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 67);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(760, 388);
            this.DataGridView.TabIndex = 0;
            // 
            // MakeASelectionLabel
            // 
            this.MakeASelectionLabel.AutoSize = true;
            this.MakeASelectionLabel.Font = new System.Drawing.Font("Script MT Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeASelectionLabel.ForeColor = System.Drawing.Color.Maroon;
            this.MakeASelectionLabel.Location = new System.Drawing.Point(234, 9);
            this.MakeASelectionLabel.Name = "MakeASelectionLabel";
            this.MakeASelectionLabel.Size = new System.Drawing.Size(295, 48);
            this.MakeASelectionLabel.TabIndex = 1;
            this.MakeASelectionLabel.Text = "Make a Selection";
            this.MakeASelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedHardwareLabel
            // 
            this.SelectedHardwareLabel.AutoSize = true;
            this.SelectedHardwareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedHardwareLabel.Location = new System.Drawing.Point(61, 499);
            this.SelectedHardwareLabel.Name = "SelectedHardwareLabel";
            this.SelectedHardwareLabel.Size = new System.Drawing.Size(260, 31);
            this.SelectedHardwareLabel.TabIndex = 2;
            this.SelectedHardwareLabel.Text = "Selected Hardware :";
            // 
            // SelectedHarwareTextBox
            // 
            this.SelectedHarwareTextBox.Location = new System.Drawing.Point(327, 499);
            this.SelectedHarwareTextBox.Multiline = true;
            this.SelectedHarwareTextBox.Name = "SelectedHarwareTextBox";
            this.SelectedHarwareTextBox.ReadOnly = true;
            this.SelectedHarwareTextBox.Size = new System.Drawing.Size(404, 30);
            this.SelectedHarwareTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(12, 562);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 39);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(694, 562);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(78, 37);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectedHarwareTextBox);
            this.Controls.Add(this.SelectedHardwareLabel);
            this.Controls.Add(this.MakeASelectionLabel);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label MakeASelectionLabel;
        private System.Windows.Forms.Label SelectedHardwareLabel;
        private System.Windows.Forms.TextBox SelectedHarwareTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}

