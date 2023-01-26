using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiWidget
{
    internal class KanjiEnglish
    {
        private string kanji;
        private string english;
        private string romanji;
        private string hiragana;
        private string katakana;

        public KanjiEnglish() { }
        public KanjiEnglish(string Kanji, string English) { 
        
            this.kanji = Kanji;
            this.english = English;
        
        }

        public KanjiEnglish(string Kanji, string English, string Romanji)
        {
            this.kanji = Kanji;
            this.english = English;
            this.romanji = Romanji;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="KanjiEnglish"/> class.
        /// </summary>
        /// <param name="JapaneseType">1: Kanji 2: Hiragana 3: Katakana</param>
        public KanjiEnglish(string Japanese, string English, int JapaneseType)
        {
            switch (JapaneseType)
            {
                case 1: this.kanji = Japanese; break;
                case 2: this.hiragana = Japanese; break;
                case 3: this.katakana = Japanese; break;
            }
            this.english = English;
        }

       

        public string Kanji { get { return kanji; } }
        public string English { get { return english; } }

        public string Romanji { get { return romanji; } }

        public string Katakana { get { return katakana; } set { this.katakana = value; } }

        public string Hiragana { get { return hiragana; } set { this.hiragana = value; } }
    }
}
