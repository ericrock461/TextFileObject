using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Security.Permissions;

namespace TextFileObject
{
    public partial class Form1 : Form
    {
        //List<HighScore> scores = new List<HighScore>();
        List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void loadScoresButton_Click(object sender, EventArgs e)
        {
            /*List<string> scoreList = File.ReadAllLines("scoreFile.txt").ToList();

            for (int i = 0; i < scoreList.Count; i += 2)
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i + 1]);

                HighScore hs = new HighScore(name, score);
                scores.Add(hs);
            }*/


            // create a list that will contain book objects, then 
            // create book objects and place them into the list

            List<string> bookslist = File.ReadAllLines("BooksFile.txt").ToList();

            for (int i = 0; i < bookslist.Count; i += 2)
            {
                string title = bookslist[i + 1];
                int number = Convert.ToInt32(bookslist[i]);

                Book b = new Book(title, number);
                books.Add(b);
            }

            loadLabel.Text = "Books loaded!";

            //DisplayResults();
            // We are not going to display all of the books.
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
            foreach (Book b in books)
            {
                tempList.Add(b.title);
                tempList.Add(Convert.ToString(b.number));
            }

            File.WriteAllLines("BooksFile.txt", tempList);

            Application.Exit();
        }

        private void sortScoresButton_Click(object sender, EventArgs e)
        {
            /*scores = scores.OrderByDescending(x => x.score).ToList();
            DisplayResults();*/
        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            /*try
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
            scoreInput.Text = "";*/
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            /*string name = nameRemove.Text;

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

            nameRemove.Text = "";*/
        }

        private void linearButton_Click(object sender, EventArgs e)
        {
               
                int index = Convert.ToInt32(numberInput.Text);
                string result = LinearSearch(books, index);

                linearOutput.Text = result;
                
                //messageLabel.Text = "Error. Enter a valid number";
        }

        public string LinearSearch(List<Book> books, int searchValue)
        {
            foreach (Book b in books)
            {
                if (b.number == searchValue)
                {
                    return b.title;
                }
            }
            return "Not found";
        }


        private void binaryButton_Click(object sender, EventArgs e)
        {           
            int index = Convert.ToInt32(numberInput.Text);
            string result = BinarySearch(books, index);

            binaryOutput.Text = result;
        }

        public string BinarySearch(List<Book> books, int searchValue)
        {
            int low = 0;
            int high = books.Count - 1;
        
                while (high >= low)
                {
                    int middle = (low + high) / 2;
                    int compare = books[middle].number.CompareTo(searchValue);

                    if (compare == 0)
                    {
                        return books[middle].title;
                    }
                    else if (compare < 0)
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle - 1;
                    }


                    /*if (books[middle] == searchValue)
                    {
                        return b.title;
                    }
                    else if (books[middle] < searchValue)
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle - 1;
                    }*/

                }                      

            return "Not found";
        }







        /*public void DisplayResults()
        {
            outputLabel.Text = "";

            foreach (HighScore hs in scores)
            {
                outputLabel.Text += hs.name + " " + hs.score + "\n";
            }
        }*/
    }
}
