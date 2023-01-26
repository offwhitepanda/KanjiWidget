using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace KanjiWidget
{
    internal class SQLiteRepository
    {
        static string connectionString = @"Data Source=C:\Kanji\Kanji.db;Version=3;";

        public SQLiteConnection createConnection()
        {
            try
            {
                SQLiteConnection myConnection = new SQLiteConnection(connectionString);
                myConnection.Open();
                return myConnection;
            }
            catch { KanjiUI.myKanjiEnglishList.Add(new KanjiEnglish("No Connection", "No Connection")); }


            return null;
        }

        internal List<KanjiEnglish> GetTranslations(List<int> selectedGrades)
        {

            List<KanjiEnglish> myList = new List<KanjiEnglish>();
            SQLiteConnection myConnection = createConnection();

            foreach (int grade in selectedGrades)
            {
                try
                {

                    string query = SQLiteQueryMaker(grade);

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, myConnection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                   
                        foreach (DataRow en in table.Rows)
                        {

                            KanjiEnglish myTranslation = new KanjiEnglish();
                            if (grade == 100)
                            {
                                myTranslation = new KanjiEnglish(en[0].ToString(), en[1].ToString(), 2);
                            }
                            else if (grade == 200)
                            {
                                myTranslation = new KanjiEnglish(en[0].ToString(), en[1].ToString(), 3);
                            }
                            else
                            {
                                myTranslation = new KanjiEnglish(en[0].ToString(), en[1].ToString(), en[2].ToString());
                            }
                               
                            myList.Add(myTranslation);
                        }
                    
                   

                    myConnection.Close();
                }
                catch { myList.Add(new KanjiEnglish("Data Error", "Data Error")); }
                finally { myConnection.Close(); }
            }
            
            

            return myList;
            
            
            
        }

        string SQLiteQueryMaker(int selectedGrade)
        {
            switch (selectedGrade)
            {
                case 1: return "Select Kanji,English,Romanji from Grade1KanjiEnglish";
                case 2: return "Select Kanji,English,Romanji from Grade2KanjiEnglish";
                case 3: return "Select Kanji,English,Romanji from Grade3KanjiEnglish";
                case 4: return "Select Kanji,English,Romanji from Grade4KanjiEnglish";
                case 5: return "Select Kanji,English,Romanji from Grade5KanjiEnglish";
                case 6: return "Select Kanji,English,Romanji from Grade6KanjiEnglish";
                case 7: return "Select Kanji,English,Romanji from GradeSecondaryKanjiEnglish";
                case 100: return "Select Hiragana, English from HiraganaTable";
                case 200: return "Select Katakana,English from KatakanaTable";
            }

            return "Select Kanji,English,Romanji from Grade1KanjiEnglish";
        }
    }
}
