namespace TextFileObject
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
            this.addScoreButton = new System.Windows.Forms.Button();
            this.sortScoresButton = new System.Windows.Forms.Button();
            this.saveScoresButton = new System.Windows.Forms.Button();
            this.loadScoresButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreInput = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.name2Label = new System.Windows.Forms.Label();
            this.nameRemove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addScoreButton
            // 
            this.addScoreButton.Location = new System.Drawing.Point(225, 114);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(154, 50);
            this.addScoreButton.TabIndex = 18;
            this.addScoreButton.Text = "Add Score";
            this.addScoreButton.UseVisualStyleBackColor = true;
            this.addScoreButton.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // sortScoresButton
            // 
            this.sortScoresButton.Location = new System.Drawing.Point(225, 24);
            this.sortScoresButton.Name = "sortScoresButton";
            this.sortScoresButton.Size = new System.Drawing.Size(154, 46);
            this.sortScoresButton.TabIndex = 17;
            this.sortScoresButton.Text = "Sort Scores";
            this.sortScoresButton.UseVisualStyleBackColor = true;
            this.sortScoresButton.Click += new System.EventHandler(this.sortScoresButton_Click);
            // 
            // saveScoresButton
            // 
            this.saveScoresButton.Location = new System.Drawing.Point(228, 470);
            this.saveScoresButton.Name = "saveScoresButton";
            this.saveScoresButton.Size = new System.Drawing.Size(154, 46);
            this.saveScoresButton.TabIndex = 16;
            this.saveScoresButton.Text = "Save and Close";
            this.saveScoresButton.UseVisualStyleBackColor = true;
            this.saveScoresButton.Click += new System.EventHandler(this.saveScoresButton_Click);
            // 
            // loadScoresButton
            // 
            this.loadScoresButton.Location = new System.Drawing.Point(36, 24);
            this.loadScoresButton.Name = "loadScoresButton";
            this.loadScoresButton.Size = new System.Drawing.Size(154, 46);
            this.loadScoresButton.TabIndex = 15;
            this.loadScoresButton.Text = "Load Scores";
            this.loadScoresButton.UseVisualStyleBackColor = true;
            this.loadScoresButton.Click += new System.EventHandler(this.loadScoresButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(36, 270);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(346, 173);
            this.outputLabel.TabIndex = 14;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(91, 114);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(99, 22);
            this.nameInput.TabIndex = 19;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 118);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Name:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(36, 146);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(49, 17);
            this.scoreLabel.TabIndex = 22;
            this.scoreLabel.Text = "Score:";
            // 
            // scoreInput
            // 
            this.scoreInput.Location = new System.Drawing.Point(91, 142);
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(99, 22);
            this.scoreInput.TabIndex = 21;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(225, 198);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(154, 50);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Remove Score";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(36, 202);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(49, 17);
            this.name2Label.TabIndex = 25;
            this.name2Label.Text = "Name:";
            // 
            // nameRemove
            // 
            this.nameRemove.Location = new System.Drawing.Point(91, 198);
            this.nameRemove.Name = "nameRemove";
            this.nameRemove.Size = new System.Drawing.Size(99, 22);
            this.nameRemove.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 554);
            this.Controls.Add(this.name2Label);
            this.Controls.Add(this.nameRemove);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.addScoreButton);
            this.Controls.Add(this.sortScoresButton);
            this.Controls.Add(this.saveScoresButton);
            this.Controls.Add(this.loadScoresButton);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addScoreButton;
        private System.Windows.Forms.Button sortScoresButton;
        private System.Windows.Forms.Button saveScoresButton;
        private System.Windows.Forms.Button loadScoresButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreInput;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label name2Label;
        private System.Windows.Forms.TextBox nameRemove;
    }
}

