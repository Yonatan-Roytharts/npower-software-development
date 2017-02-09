namespace LoopyChallengeGUI
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
            this.jupiterButton = new System.Windows.Forms.Button();
            this.saturnButton = new System.Windows.Forms.Button();
            this.plutoButton = new System.Windows.Forms.Button();
            this.neptuneButton = new System.Windows.Forms.Button();
            this.mercuryButton = new System.Windows.Forms.Button();
            this.marsButton = new System.Windows.Forms.Button();
            this.venusButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.uranusButton = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jupiterButton
            // 
            this.jupiterButton.Location = new System.Drawing.Point(12, 61);
            this.jupiterButton.Name = "jupiterButton";
            this.jupiterButton.Size = new System.Drawing.Size(75, 23);
            this.jupiterButton.TabIndex = 0;
            this.jupiterButton.Text = "Jupiter";
            this.jupiterButton.UseVisualStyleBackColor = true;
            this.jupiterButton.Click += new System.EventHandler(this.jupiterButton_Click);
            // 
            // saturnButton
            // 
            this.saturnButton.Location = new System.Drawing.Point(251, 91);
            this.saturnButton.Name = "saturnButton";
            this.saturnButton.Size = new System.Drawing.Size(75, 23);
            this.saturnButton.TabIndex = 1;
            this.saturnButton.Text = "Saturn";
            this.saturnButton.UseVisualStyleBackColor = true;
            this.saturnButton.Click += new System.EventHandler(this.saturnButton_Click);
            // 
            // plutoButton
            // 
            this.plutoButton.Location = new System.Drawing.Point(134, 91);
            this.plutoButton.Name = "plutoButton";
            this.plutoButton.Size = new System.Drawing.Size(75, 23);
            this.plutoButton.TabIndex = 2;
            this.plutoButton.Text = "Pluto";
            this.plutoButton.UseVisualStyleBackColor = true;
            this.plutoButton.Click += new System.EventHandler(this.plutoButton_Click);
            // 
            // neptuneButton
            // 
            this.neptuneButton.Location = new System.Drawing.Point(12, 90);
            this.neptuneButton.Name = "neptuneButton";
            this.neptuneButton.Size = new System.Drawing.Size(75, 23);
            this.neptuneButton.TabIndex = 3;
            this.neptuneButton.Text = "Neptune";
            this.neptuneButton.UseVisualStyleBackColor = true;
            this.neptuneButton.Click += new System.EventHandler(this.neptuneButton_Click);
            // 
            // mercuryButton
            // 
            this.mercuryButton.Location = new System.Drawing.Point(251, 61);
            this.mercuryButton.Name = "mercuryButton";
            this.mercuryButton.Size = new System.Drawing.Size(75, 23);
            this.mercuryButton.TabIndex = 4;
            this.mercuryButton.Text = "Mercury";
            this.mercuryButton.UseVisualStyleBackColor = true;
            this.mercuryButton.Click += new System.EventHandler(this.mercuryButton_Click);
            // 
            // marsButton
            // 
            this.marsButton.Location = new System.Drawing.Point(134, 62);
            this.marsButton.Name = "marsButton";
            this.marsButton.Size = new System.Drawing.Size(75, 23);
            this.marsButton.TabIndex = 5;
            this.marsButton.Text = "Mars";
            this.marsButton.UseVisualStyleBackColor = true;
            this.marsButton.Click += new System.EventHandler(this.marsButton_Click);
            // 
            // venusButton
            // 
            this.venusButton.Location = new System.Drawing.Point(134, 120);
            this.venusButton.Name = "venusButton";
            this.venusButton.Size = new System.Drawing.Size(75, 23);
            this.venusButton.TabIndex = 6;
            this.venusButton.Text = "Venus";
            this.venusButton.UseVisualStyleBackColor = true;
            this.venusButton.Click += new System.EventHandler(this.venusButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Red;
            this.quitButton.Location = new System.Drawing.Point(251, 120);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 7;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // uranusButton
            // 
            this.uranusButton.Location = new System.Drawing.Point(12, 120);
            this.uranusButton.Name = "uranusButton";
            this.uranusButton.Size = new System.Drawing.Size(75, 23);
            this.uranusButton.TabIndex = 8;
            this.uranusButton.Text = "Uranus";
            this.uranusButton.UseVisualStyleBackColor = true;
            this.uranusButton.Click += new System.EventHandler(this.uranusButton_Click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(124, 166);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 9;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter your weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loopy Planet Calculator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // outputMessage
            // 
            this.outputMessage.AutoSize = true;
            this.outputMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessage.Location = new System.Drawing.Point(12, 212);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(0, 20);
            this.outputMessage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 262);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.uranusButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.venusButton);
            this.Controls.Add(this.marsButton);
            this.Controls.Add(this.mercuryButton);
            this.Controls.Add(this.neptuneButton);
            this.Controls.Add(this.plutoButton);
            this.Controls.Add(this.saturnButton);
            this.Controls.Add(this.jupiterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jupiterButton;
        private System.Windows.Forms.Button saturnButton;
        private System.Windows.Forms.Button plutoButton;
        private System.Windows.Forms.Button neptuneButton;
        private System.Windows.Forms.Button mercuryButton;
        private System.Windows.Forms.Button marsButton;
        private System.Windows.Forms.Button venusButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button uranusButton;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputMessage;
    }
}

