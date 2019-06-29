namespace LSystem
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
            this.LSystemPictureBox = new System.Windows.Forms.PictureBox();
            this.GenrateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.InstructionsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LSystemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LSystemPictureBox
            // 
            this.LSystemPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.LSystemPictureBox.Location = new System.Drawing.Point(13, 13);
            this.LSystemPictureBox.Name = "LSystemPictureBox";
            this.LSystemPictureBox.Size = new System.Drawing.Size(400, 400);
            this.LSystemPictureBox.TabIndex = 0;
            this.LSystemPictureBox.TabStop = false;
            this.LSystemPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.LSystemPictureBox_Paint);
            // 
            // GenrateButton
            // 
            this.GenrateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenrateButton.Location = new System.Drawing.Point(13, 420);
            this.GenrateButton.Name = "GenrateButton";
            this.GenrateButton.Size = new System.Drawing.Size(112, 36);
            this.GenrateButton.TabIndex = 1;
            this.GenrateButton.Text = "Generate";
            this.GenrateButton.UseVisualStyleBackColor = true;
            this.GenrateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(322, 420);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 36);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // InstructionsTextbox
            // 
            this.InstructionsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsTextbox.Location = new System.Drawing.Point(447, 13);
            this.InstructionsTextbox.Multiline = true;
            this.InstructionsTextbox.Name = "InstructionsTextbox";
            this.InstructionsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InstructionsTextbox.Size = new System.Drawing.Size(480, 400);
            this.InstructionsTextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Instructions followed by the program to create the image.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstructionsTextbox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.GenrateButton);
            this.Controls.Add(this.LSystemPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LSystemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LSystemPictureBox;
        private System.Windows.Forms.Button GenrateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox InstructionsTextbox;
        private System.Windows.Forms.Label label1;
    }
}

