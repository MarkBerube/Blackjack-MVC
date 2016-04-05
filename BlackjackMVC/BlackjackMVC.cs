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
    public partial class BlackjackMVC : Form
    {
        public BlackjackMVC()
        {
            InitializeComponent();


        }

        private void hitButton_Click(object sender, EventArgs e)
        {
           CardController c = new CardController();
           c.AddCard(Globals.MyHand, c.DeckTake2Hand(Globals.D, listMyHand));
           if (c.CheckLose(Globals.MyHand) == true)
           {
               statusLabel.Text = "Player Loses";

           }
          
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            CardController c = new CardController();
            Globals.MyHand = c.CreateDeck();
            Globals.DealerHand = c.CreateDeck();
            Globals.D = c.CreateDeck();
            c.ClearHand(listMyHand);
            c.ClearHand(listDealerHand);
            statusLabel.Text = "Ready";
            c.Add52(Globals.D);
            c.AddCard(Globals.MyHand,c.DeckTake2Hand(Globals.D, listMyHand));
            c.AddCard(Globals.DealerHand, c.DeckTake2Hand(Globals.D, listDealerHand));
            c.AddCard(Globals.MyHand, c.DeckTake2Hand(Globals.D, listMyHand));
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            CardController c = new CardController();
            c.AddCard(Globals.DealerHand, c.DeckTake2Hand(Globals.D, listDealerHand));
            if (c.Check21(Globals.DealerHand))
            {
                statusLabel.Text = "Dealer Wins";
            }
            else if (c.Check21(Globals.MyHand))
            {
                statusLabel.Text = "Player Wins";
            }

            //1st pass
            if (c.Check17(Globals.DealerHand))
            {
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer Wins";
                }
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer Wins";
                }
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Player Wins";
                }
                
            }
            else  c.AddCard(Globals.DealerHand, c.DeckTake2Hand(Globals.D, listDealerHand));

            if (c.CheckLose(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Player Win";

            }
            //2nd pass
            if (c.Check17(Globals.DealerHand))
            {
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer Wins";
                }
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer Wins";
                }
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Player Wins";
                }
            }
            else c.AddCard(Globals.DealerHand, c.DeckTake2Hand(Globals.D, listDealerHand));

            if (c.CheckLose(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Player Win";

            }

            //third pass

            if (c.Check17(Globals.DealerHand))
            {
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer Wins";
                }
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer Wins";
                }
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Player Wins";
                }
            }
            else c.AddCard(Globals.DealerHand, c.DeckTake2Hand(Globals.D, listDealerHand));

            if (c.CheckLose(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Player Win";

            }

            //fourth pass

            if (c.Check17(Globals.DealerHand))
            {
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer Wins";
                }
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer Wins";
                }
                if (c.CompareValue(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Player Wins";
               } 
            }
            else c.AddCard(Globals.DealerHand, c.DeckTake2Hand(Globals.D, listDealerHand));

            if (c.CheckLose(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Player Win";

            }


        }


    }

    



}
