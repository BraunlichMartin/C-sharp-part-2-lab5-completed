using CardClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestCardConstructors();

            Card aS = new Card(1, 4);
            Card qH = new Card(12, 3);

            TestCardIsMethods(aS);
            TestCardIsMethods(qH);

            TestHasMatchingValue();

            

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestHasMatchingValue()
        {
            Console.WriteLine("Testing has matching value");

            Card aS = new Card(1, 4);
            Card qH = new Card(12, 3);

            Console.WriteLine("Expecting card value not to match");
            if (aS.HasMatchingValue(qH))
                Console.WriteLine("the card values match");
            else
                Console.WriteLine("The card values do not match");

            Card qS = new Card(1, 4);
            

            Console.WriteLine("Expecting card value to match");
            if (qS.HasMatchingValue(qH))
                Console.WriteLine("the card values match");
            else
                Console.WriteLine("The card values do not match");
        }
        static void TestCardConstructors()
        {
            Card card1 = new Card();
            Card card2 = new Card(11, 4);

            Console.WriteLine("Testing Constructors");
            Console.WriteLine("Default Constructor. Expecting Ace of Clubs: " + card1);
            Console.WriteLine("Default Constructor. Expecting Jack of Spades: " + card2);
        }

        static void TestCardIsMethods(Card card)
        {
            Card card1 = new Card(11, 4);
            Card card2 = new Card(11, 3);
            Card card3 = new Card(12, 3);
            Card card4 = new Card(2, 4);

            Console.WriteLine("Testing TestCardIsMethods");
            Console.WriteLine("Expecting true for IsFaceCard() when applied to (11, 4) ie Jack of Spades: " + card1.IsFaceCard());
            Console.WriteLine("Expecting false for IsFaceCard() when applied to (2, 4) ie two of Spades: " + card4.IsFaceCard());
            Console.WriteLine("Expecting true for isHeart() when applied to (11,3) ie Jack of Hearts: " + card2.IsHeart());
            Console.WriteLine("Expecting false for isHeart() when applied to (11,4) ie Jack of Spades: " + card1.IsHeart());
            Console.WriteLine("Expecting true for IsQueen() when applied to (12,3) ie Queen of Hearts: " + card3.IsQueen());
            Console.WriteLine("Expecting false for IsQueen() when applied to (11,4) ie Jack of Spades: " + card1.IsQueen());
            Console.WriteLine("Expecting true for IsBlack() when applied to (11,4) ie Jack of Spades: " + card1.IsBlack());
            Console.WriteLine("Expecting false for IsBlack() when applied to (11,3) ie Jack of Spades: " + card2.IsBlack());
        }
    }
}
