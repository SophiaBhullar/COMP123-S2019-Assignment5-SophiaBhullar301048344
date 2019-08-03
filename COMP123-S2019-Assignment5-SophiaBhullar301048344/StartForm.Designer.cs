namespace COMP123_S2019_Assignment5_SophiaBhullar301048344
{
    partial class StartForm
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
            this.StartANewOrderButton = new System.Windows.Forms.Button();
            this.LoadASavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartANewOrderButton
            // 
            this.StartANewOrderButton.Location = new System.Drawing.Point(260, 433);
            this.StartANewOrderButton.Name = "StartANewOrderButton";
            this.StartANewOrderButton.Size = new System.Drawing.Size(254, 43);
            this.StartANewOrderButton.TabIndex = 0;
            this.StartANewOrderButton.Text = "Start a new order";
            this.StartANewOrderButton.UseVisualStyleBackColor = true;
            this.StartANewOrderButton.Click += new System.EventHandler(this.StartANewOrderButton_Click);
            // 
            // LoadASavedOrderButton
            // 
            this.LoadASavedOrderButton.Location = new System.Drawing.Point(260, 508);
            this.LoadASavedOrderButton.Name = "LoadASavedOrderButton";
            this.LoadASavedOrderButton.Size = new System.Drawing.Size(254, 40);
            this.LoadASavedOrderButton.TabIndex = 1;
            this.LoadASavedOrderButton.Text = "Load a saved order";
            this.LoadASavedOrderButton.UseVisualStyleBackColor = true;
            this.LoadASavedOrderButton.Click += new System.EventHandler(this.LoadASavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(705, 601);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(83, 37);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COMP123_S2019_Assignment5_SophiaBhullar301048344.Properties.Resources.DollarComputers2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(226, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 310);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadASavedOrderButton);
            this.Controls.Add(this.StartANewOrderButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartANewOrderButton;
        private System.Windows.Forms.Button LoadASavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}