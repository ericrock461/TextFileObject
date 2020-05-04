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
            this.loadBooksButton = new System.Windows.Forms.Button();
            this.linearOutput = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.linearButton = new System.Windows.Forms.Button();
            this.binaryButton = new System.Windows.Forms.Button();
            this.explainLabel = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.binaryOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addScoreButton
            // 
            this.addScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addScoreButton.Location = new System.Drawing.Point(331, 12);
            this.addScoreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(44, 16);
            this.addScoreButton.TabIndex = 18;
            this.addScoreButton.Text = "Add Score";
            this.addScoreButton.UseVisualStyleBackColor = true;
            this.addScoreButton.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // sortScoresButton
            // 
            this.sortScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortScoresButton.Location = new System.Drawing.Point(331, 2);
            this.sortScoresButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortScoresButton.Name = "sortScoresButton";
            this.sortScoresButton.Size = new System.Drawing.Size(44, 16);
            this.sortScoresButton.TabIndex = 17;
            this.sortScoresButton.Text = "Sort Scores";
            this.sortScoresButton.UseVisualStyleBackColor = true;
            this.sortScoresButton.Click += new System.EventHandler(this.sortScoresButton_Click);
            // 
            // saveScoresButton
            // 
            this.saveScoresButton.Location = new System.Drawing.Point(138, 352);
            this.saveScoresButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveScoresButton.Name = "saveScoresButton";
            this.saveScoresButton.Size = new System.Drawing.Size(116, 37);
            this.saveScoresButton.TabIndex = 16;
            this.saveScoresButton.Text = "Save and Close";
            this.saveScoresButton.UseVisualStyleBackColor = true;
            this.saveScoresButton.Click += new System.EventHandler(this.saveScoresButton_Click);
            // 
            // loadBooksButton
            // 
            this.loadBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadBooksButton.Location = new System.Drawing.Point(138, 22);
            this.loadBooksButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadBooksButton.Name = "loadBooksButton";
            this.loadBooksButton.Size = new System.Drawing.Size(116, 42);
            this.loadBooksButton.TabIndex = 15;
            this.loadBooksButton.Text = "Load Books";
            this.loadBooksButton.UseVisualStyleBackColor = true;
            this.loadBooksButton.Click += new System.EventHandler(this.loadScoresButton_Click);
            // 
            // linearOutput
            // 
            this.linearOutput.BackColor = System.Drawing.Color.White;
            this.linearOutput.Location = new System.Drawing.Point(101, 241);
            this.linearOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linearOutput.Name = "linearOutput";
            this.linearOutput.Size = new System.Drawing.Size(267, 24);
            this.linearOutput.TabIndex = 14;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(337, 28);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(38, 13);
            this.scoreLabel.TabIndex = 22;
            this.scoreLabel.Text = "Score:";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(255, 178);
            this.numberInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(28, 20);
            this.numberInput.TabIndex = 21;
            // 
            // removeButton
            // 
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(331, 22);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(44, 16);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Remove Score";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // linearButton
            // 
            this.linearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.linearButton.ForeColor = System.Drawing.Color.Black;
            this.linearButton.Location = new System.Drawing.Point(12, 241);
            this.linearButton.Name = "linearButton";
            this.linearButton.Size = new System.Drawing.Size(84, 24);
            this.linearButton.TabIndex = 24;
            this.linearButton.Text = "Linear Search";
            this.linearButton.UseVisualStyleBackColor = true;
            this.linearButton.Click += new System.EventHandler(this.linearButton_Click);
            // 
            // binaryButton
            // 
            this.binaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.binaryButton.Location = new System.Drawing.Point(12, 284);
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(84, 24);
            this.binaryButton.TabIndex = 25;
            this.binaryButton.Text = "Binary Search";
            this.binaryButton.UseVisualStyleBackColor = true;
            this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
            // 
            // explainLabel
            // 
            this.explainLabel.AutoSize = true;
            this.explainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainLabel.Location = new System.Drawing.Point(24, 121);
            this.explainLabel.Name = "explainLabel";
            this.explainLabel.Size = new System.Drawing.Size(339, 26);
            this.explainLabel.TabIndex = 26;
            this.explainLabel.Text = "This program will find the title of a book based on its reference number.\r\nYou ma" +
    "y use a linear or a binary search.";
            this.explainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.explainLabel.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.ForeColor = System.Drawing.Color.Black;
            this.enterLabel.Location = new System.Drawing.Point(60, 179);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(190, 17);
            this.enterLabel.TabIndex = 27;
            this.enterLabel.Text = "Enter the reference number:";
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Black;
            this.messageLabel.Location = new System.Drawing.Point(69, 206);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(243, 23);
            this.messageLabel.TabIndex = 28;
            this.messageLabel.Text = "Then choose...";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadLabel
            // 
            this.loadLabel.ForeColor = System.Drawing.Color.Red;
            this.loadLabel.Location = new System.Drawing.Point(128, 70);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(137, 23);
            this.loadLabel.TabIndex = 29;
            this.loadLabel.Text = "Books not loaded";
            this.loadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // binaryOutput
            // 
            this.binaryOutput.BackColor = System.Drawing.Color.White;
            this.binaryOutput.Location = new System.Drawing.Point(101, 284);
            this.binaryOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.binaryOutput.Name = "binaryOutput";
            this.binaryOutput.Size = new System.Drawing.Size(267, 24);
            this.binaryOutput.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.binaryOutput);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.explainLabel);
            this.Controls.Add(this.binaryButton);
            this.Controls.Add(this.linearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.addScoreButton);
            this.Controls.Add(this.sortScoresButton);
            this.Controls.Add(this.saveScoresButton);
            this.Controls.Add(this.loadBooksButton);
            this.Controls.Add(this.linearOutput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button loadBooksButton;
        private System.Windows.Forms.Label linearOutput;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button linearButton;
        private System.Windows.Forms.Button binaryButton;
        private System.Windows.Forms.Label explainLabel;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.Label binaryOutput;
    }
}

