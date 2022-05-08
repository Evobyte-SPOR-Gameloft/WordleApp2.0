using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleAppOOP
{
    internal class Dictionary
    {
        public string[] WordList { get; }

        public Dictionary(string[] wordList)
        {
            this.WordList = wordList;
        }

        public string WordPicker()
        {
            Random randomWordGenerator = new();
            string chosenWord = this.WordList[randomWordGenerator.Next(0, 5757)];
            return chosenWord;
        }

        public bool DoesContain(string word)
        {
            if (this.WordList.Contains(word)) return true;
            else return false;
        }
    }
}
