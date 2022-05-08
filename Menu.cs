using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WordleAppOOP.Utility;

namespace WordleAppOOP
{
    internal class Menu
    {
        public string OptionOne { get; }
        public string OptionTwo { get; }
        public string OptionThree { get; }
        public string OptionFour { get; }
        public string OptionFive { get; }

        #pragma warning disable CS8618
        public Menu(string optionOne)
        {
            this.OptionOne = optionOne;
        }
        public Menu(string optionOne, string optionTwo)
        {
            this.OptionOne = optionOne;
            this.OptionTwo = optionTwo;
        }
        public Menu(string optionOne, string optionTwo, string optionThree)
        {
            this.OptionOne = optionOne;
            this.OptionTwo = optionTwo;
            this.OptionThree = optionThree;
        }
        public Menu(string optionOne, string optionTwo, string optionThree, string optionFour)
        {
            this.OptionOne = optionOne;
            this.OptionTwo = optionTwo;
            this.OptionThree = optionThree;
            this.OptionFour = optionFour;
        }
        public Menu(string optionOne, string optionTwo, string optionThree, string optionFour, string optionFive)
        {
            this.OptionOne = optionOne;
            this.OptionTwo = optionTwo;
            this.OptionThree = optionThree;
            this.OptionFour = optionFour;
            this.OptionFive = optionFive;
        }
    }
}
