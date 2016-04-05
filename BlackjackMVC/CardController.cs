using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackMVC
{
   public class CardController
    {


       public int CompareValue(Deck d, Deck m)
       {

           if (d.SumValue() > m.SumValue()) return 3;
           if (d.SumValue() == m.SumValue()) return 2;
           if (d.SumValue() < m.SumValue()) return 1;
           return 0;
       }

       public bool CheckLose(Deck d)
       {

           if (d.SumValue() > 21)
           {
               d.Ace1Set();
               if (d.SumValue() > 21)
               {
                   d.Ace1Set();
                   if (d.SumValue() > 21)
                   {
                       d.Ace1Set();
                       if (d.SumValue() > 21)
                       {
                           d.Ace1Set();
                           if (d.SumValue() > 21)
                           { return true; }
                       }
                       else return false;
                   }
                   else return false;
               }
               else return false;


           }
           else return false;

           return false;
             

       }

       public bool Check17(Deck d)
       {

           if (d.SumValue() >= 17)
           {
               d.Ace1Set();
               if (d.SumValue() >= 17)
               {
                   d.Ace1Set();
                   if (d.SumValue() >= 17)
                   {
                       d.Ace1Set();
                       if (d.SumValue() >= 17)
                       {
                           d.Ace1Set();
                           if (d.SumValue() >= 17)
                           { return true; }
                       }
                       else return false;
                   }
                   else return false;
               }
               else return false;


           }
           else return false;

           return false;


       }

       public bool Check21(Deck d)
       {
           if (d.SumValue() == 21) return true;
           return false;

       }

       public string CheckWin(Deck m, Deck d)
       {

           if (d.SumValue() > 21) return "Dealer Wins!";
           if (m.SumValue() > 21) return "Player Wins!";

           if (d.SumValue() > m.SumValue())
           {
               return "Dealer Wins!";

           }
           if (d.SumValue() < m.SumValue())
           {
               return "Player Wins!";

           }
           return "How'd you get there?";



       }

        public Card DeckTake2Hand(Deck d,ListView v)
        {

            Card c = d.TakeTopCard();
            ListViewItem item = new ListViewItem(c.getFace());
            item.SubItems.Add(c.getSuit());
            item.SubItems.Add(c.getValue().ToString());
            v.Items.Add(item);
            return c;

        }
        public void ClearHand(ListView L)
        {
            L.Items.Clear();
        }
        public Deck CreateDeck()
        {
            Deck buff = new Deck();
            return buff;
        }

        public void AddCard(Deck d, Card c)
        {

            d.AddCard(c);

        }

        public void Add52(Deck d)
        {
            string suit = "Clover";
            Card ac;
            
            ac = new Card(suit,"Ace",11);
            d.AddCard(ac);

            ac = new Card(suit,"Two",2);
            d.AddCard(ac);

            ac = new Card(suit, "Three", 3);
            d.AddCard(ac);

            ac = new Card(suit, "Four", 4);
            d.AddCard(ac);

            ac = new Card(suit, "Five", 5);
            d.AddCard(ac);

            ac = new Card(suit, "Six", 6);
            d.AddCard(ac);

            ac = new Card(suit, "Seven", 7);
            d.AddCard(ac);

            ac = new Card(suit, "Eight", 8);
            d.AddCard(ac);

            ac = new Card(suit, "Nine", 9);
            d.AddCard(ac);

            ac = new Card(suit, "Ten", 10);
            d.AddCard(ac);

            ac = new Card(suit, "Jack", 10);
            d.AddCard(ac);

            ac = new Card(suit, "Queen", 10);
            d.AddCard(ac);

            ac = new Card(suit, "King", 10);
            d.AddCard(ac);

            suit = "Spade";

            ac = new Card(suit, "Ace", 11);
            d.AddCard(ac);

            ac = new Card(suit, "Two", 2);
            d.AddCard(ac);

            ac = new Card(suit, "Three", 3);
            d.AddCard(ac);

            ac = new Card(suit, "Four", 4);
            d.AddCard(ac);

            ac = new Card(suit, "Five", 5);
            d.AddCard(ac);

            ac = new Card(suit, "Six", 6);
            d.AddCard(ac);

            ac = new Card(suit, "Seven", 7);
            d.AddCard(ac);

            ac = new Card(suit, "Eight", 8);
            d.AddCard(ac);

            ac = new Card(suit, "Nine", 9);
            d.AddCard(ac);

            ac = new Card(suit, "Ten", 10);
            d.AddCard(ac);

            ac = new Card(suit, "Jack", 10);
            d.AddCard(ac);

            ac = new Card(suit, "Queen", 10);
            d.AddCard(ac);

            ac = new Card(suit, "King", 10);
            d.AddCard(ac);

            suit = "Heart";

            ac = new Card(suit, "Ace", 11);
            d.AddCard(ac);

            ac = new Card(suit, "Two", 2);
            d.AddCard(ac);

            ac = new Card(suit, "Three", 3);
            d.AddCard(ac);

            ac = new Card(suit, "Four", 4);
            d.AddCard(ac);

            ac = new Card(suit, "Five", 5);
            d.AddCard(ac);

            ac = new Card(suit, "Six", 6);
            d.AddCard(ac);

            ac = new Card(suit, "Seven", 7);
            d.AddCard(ac);

            ac = new Card(suit, "Eight", 8);
            d.AddCard(ac);

            ac = new Card(suit, "Nine", 9);
            d.AddCard(ac);

            ac = new Card(suit, "Ten", 10);
            d.AddCard(ac);

            ac = new Card(suit, "Jack", 10);
            d.AddCard(ac);

            ac = new Card(suit, "Queen", 10);
            d.AddCard(ac);

            ac = new Card(suit, "King", 10);
            d.AddCard(ac);

            suit = "Diamond";

            ac = new Card(suit, "Ace", 11);
            d.AddCard(ac);

            ac = new Card(suit, "Two", 2);
            d.AddCard(ac);

            ac = new Card(suit, "Three", 3);
            d.AddCard(ac);

            ac = new Card(suit, "Four", 4);
            d.AddCard(ac);

            ac = new Card(suit, "Five", 5);
            d.AddCard(ac);

            ac = new Card(suit, "Six", 6);
            d.AddCard(ac);

            ac = new Card(suit, "Seven", 7);
            d.AddCard(ac);

            ac = new Card(suit, "Eight", 8);
            d.AddCard(ac);

            ac = new Card(suit, "Nine", 9);
            d.AddCard(ac);

            ac = new Card(suit, "Ten", 10);
            d.AddCard(ac);

            ac = new Card(suit, "Jack", 10);
            d.AddCard(ac);

            ac = new Card(suit, "Queen", 10);
            d.AddCard(ac);

            ac = new Card(suit, "King", 10);
            d.AddCard(ac);



        }


    }
}
