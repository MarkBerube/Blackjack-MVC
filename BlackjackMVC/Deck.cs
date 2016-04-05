using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlackjackMVC
{

    public static class Globals
    {
        public static Deck D;
        public static Deck MyHand;
        public static Deck DealerHand;
        public static Random rnd = new Random();
    }

    public class Deck
    {

        private List<Card> D;


        public Deck()
        {
            this.D = new List<Card>();
        }

        public int SumValue()
        {
            int sum = 0;
            int i = 0;
            while (i < D.Count())
            {

                sum += D[i].getValue();
                i++;
            }

            return sum;

        }
        public void Ace1Set()
        {
            int i = 0;
            int j = 0;
            while (i < D.Count && j == 0 )
            {
                j = D[i].setA();
                i++;
            }

        }

        public void AddCard(Card c)
        {
            D.Add(c);
        }

        public Card TakeTopCard()
        {
            
            int r = Globals.rnd.Next(D.Count);
            Card buff = D[r];

            D.Remove(buff);
            return buff;
        }


    }
   

}
