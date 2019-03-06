using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardClasses
{
    public class Card
    {
        private int suit;   //the suit can range from 1 to 4
        private int value;  //the value  can range from 1 to 13

        private string[] suits = { "????", "clubs", "diamonds", "hearts", "spades" };
        private string[] values = { "???", "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };

        //Default card of ace of clubs constructed
        public Card()
        {
            value = 1;
            suit = 1;
        }

        //Card with specified value and suit created
        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                this.suit = value;
            }
        }

        public bool IsBlack()
        {
            if (suit == 1 || suit == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool IsQueen()
        {
            if (value == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool IsClub()
        {
            if (suit == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDiamond()
        {
            if (suit == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsHeart()
        {
            if (suit == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSpade()
        {
            if (suit == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFaceCard()
        {
            if (value >= 11 && value <= 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FileName
        {
            get
            {
                return "card" + values[value].Substring(0,1) + suits[suit].Substring(0, 1) + ".jpg";
            }
        }

        //Checks for a match on values of two cards
        //could use "value" instead of "this.value"
        public bool HasMatchingValue (Card other)
        {
            if (other.Value == this.value)
                return true;
            else
                return false;
        }

        //Sets the image of the given PictureBox to the proper filename
        public void Show(PictureBox p)
        {
            p.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Cards\\" + FileName);
        }

        //Sets the image of the given PictureBox to the card back image
        public void ShowBack(PictureBox p)
        {
            p.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Cards\\black_back.jpg");
        }


        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }
    }
}
