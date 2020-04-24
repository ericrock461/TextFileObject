using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace TextFileObject
{
    public partial class Form1 : Form
    {
        List<HighScore> scores = new List<HighScore>();

        public Form1()
        {
            InitializeComponent();
        }

        private void loadScoresButton_Click(object sender, EventArgs e)
        {
            List<string> scoreList = File.ReadAllLines("scoreFile.txt").ToList();

            for (int i = 0; i < scoreList.Count; i += 2)
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i + 1]);

                HighScore hs = new HighScore(name, score);
                scores.Add(hs);
            }

            DisplayResults();
        }

        /// <summary>
        /// Take all values from the data object list, convert tem all to string
        /// values, store them all in a temp list of strings, and then save those
        /// values to an external file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveScoresButton_Click(object sender, EventArgs e)
        {
            // list to store all values from object list as strings
            List<string> tempList = new List<string>();

            // Add all info from each HighScore object to temp list
            foreach (HighScore hs in scores)
            {
                tempList.Add(hs.name);
                tempList.Add(Convert.ToString(hs.score));
            }

            File.WriteAllLines("scoreFile.txt", tempList);

            Application.Exit();
        }

        private void sortScoresButton_Click(object sender, EventArgs e)
        {
            scores = scores.OrderByDescending(x => x.score).ToList();
            DisplayResults();
        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameInput.Text;
                int score = Convert.ToInt32(scoreInput.Text);

                HighScore hs = new HighScore(name, score);
                scores.Add(hs);

                DisplayResults();
            }
            catch
            {
                MessageBox.Show("Please enter a name and integer score");
            }

            nameInput.Text = "";
            scoreInput.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string name = nameRemove.Text;

            int index = scores.FindIndex(score => score.name == name);

            if (index >= 0)
            {
                scores.RemoveAt(index);
                MessageBox.Show(name + " removed from scores");
                DisplayResults();
            }
            else
            {
                MessageBox.Show(name + " is not in the list of scores");
            }

            nameRemove.Text = "";
        }

        public void DisplayResults()
        {
            outputLabel.Text = "";

            foreach (HighScore hs in scores)
            {
                outputLabel.Text += hs.name + " " + hs.score + "\n";
            }
        }
    }
}
