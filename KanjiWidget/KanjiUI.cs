using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiWidget
{
    public partial class KanjiUI : Form
    {
        public static int currentIndex = 0;
        public static List<int> selectedGrades = new List<int>();
        public static bool randomized = false;
        public static bool paused = false;

        // Create a timer object
        Timer myTimer = new Timer();

        
        internal static List<KanjiEnglish> myKanjiEnglishList = new List<KanjiEnglish>();
        public KanjiUI()
        {
            InitializeComponent();
            this.TopMost = true;
            MakeKanji();
            NextReading();
            CreateTimer(2);
        }

        public static void MakeKanji()
        {
            myKanjiEnglishList.Clear();
            SQLiteRepository myRepo = new SQLiteRepository();
            if (selectedGrades.Count <= 0)
            {
                selectedGrades.Add(0);
            }
            myKanjiEnglishList = myRepo.GetTranslations(selectedGrades);
            selectedGrades.Clear();
        }

        public void NextReading()
        {
            if (myKanjiEnglishList.Count <= 0)
            {
                kanjiLabel.Text = "Error";
                return;
            }
            if (currentIndex >= myKanjiEnglishList.Count)
            {
                currentIndex = 0;
            }
            if (randomized == false)
            {
                if (myKanjiEnglishList[currentIndex].Kanji == null)
                {
                    if (myKanjiEnglishList[currentIndex].Hiragana == null)
                    {
                        kanjiLabel.Text = myKanjiEnglishList[currentIndex].Katakana;
                    }
                    else
                    {
                        kanjiLabel.Text = myKanjiEnglishList[currentIndex].Hiragana;
                    }
                    
                }
                else
                {
                    kanjiLabel.Text = myKanjiEnglishList[currentIndex].Kanji;
                }
                
                englishLabel.Text = myKanjiEnglishList[currentIndex].English;
                romanjiLabel.Text = myKanjiEnglishList[currentIndex].Romanji;
                currentIndex++;
            }
            else
            {
                Random randomIndex = new Random();
                int randomNumIndex = randomIndex.Next(0, myKanjiEnglishList.Count - 1);
                if (myKanjiEnglishList[randomNumIndex].Kanji == null)
                {

                    if (myKanjiEnglishList[currentIndex].Hiragana == null)
                    {
                        kanjiLabel.Text = myKanjiEnglishList[randomNumIndex].Katakana;
                    }
                    else
                    {
                        kanjiLabel.Text = myKanjiEnglishList[randomNumIndex].Hiragana;
                    }
                    
                }
                else
                {
                    kanjiLabel.Text = myKanjiEnglishList[randomNumIndex].Kanji;
                }
                
                englishLabel.Text = myKanjiEnglishList[randomNumIndex].English;
                romanjiLabel.Text = myKanjiEnglishList[randomNumIndex].Romanji;
                currentIndex = 0;
            }
            
        }
        private void ResetTimer()
        {
            myTimer.Enabled = false;
        }
        private void CreateTimer(int Interval)
        {
            ResetTimer();

            // Set the interval of the timer (in milliseconds)
            myTimer.Interval = Interval * 1000;

            // Attach an event handler to the timer's Tick event
            myTimer.Tick += MyTimer_Tick;

            myTimer.Enabled = true;

            // Start the timer
            myTimer.Start();

            // ...

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            // Code to be executed every time the timer ticks
            if (!paused) NextReading();
            
            
        }

        private void getSelectedGrades()
        {
            selectedGrades.Clear();

            if (grade1CheckBox.Checked) { selectedGrades.Add(1); }
            if (grade2CheckBox.Checked) { selectedGrades.Add(2); }
            if (grade3CheckBox.Checked) { selectedGrades.Add(3); }
            if (grade4CheckBox.Checked) { selectedGrades.Add(4); }
            if (grade5CheckBox.Checked) { selectedGrades.Add(5); }
            if (grade6CheckBox.Checked) { selectedGrades.Add(6); }
            if (gradeSecondaryCheckBox.Checked) { selectedGrades.Add(7); }
            if (hiraganaCheckBox.Checked) { selectedGrades.Add(100); }
            if (katakanaCheckBox.Checked) { selectedGrades.Add(200); }

            MakeKanji();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grade1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }

        private void grade2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }

        private void randomizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (randomizeCheckBox.Checked)
            {
                randomized = true;
            }
            else
            {
                randomized = false;
            }
        }

        private void grade3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (paused) { paused = false;
                pauseButton.Text = "pause";
            } else { paused = true;
                pauseButton.Text = "paused";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateTimer(Convert.ToInt32(comboBox1.SelectedItem));
        }

        private void hiraganaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }

        private void katakanaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }

        private void grade4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }

        private void grade5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }

        private void grade6CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }

        private void gradeSecondaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            getSelectedGrades();
        }
    }
}
