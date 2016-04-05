using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackMVC
{
    public class Card
    {
        private string Suit;
        private string Face;
        private int Value;

        public Card(string s, string f, int v)
        {
            this.Suit = s;
            this.Face = f;
            this.Value = v;
        }

        public string getSuit()
        {
            return this.Suit;
        }
        public string getFace()
        {
            return this.Face;
        }
        public int getValue()
        {
            return this.Value;
        }
        public int setA()
        {
            if (this.Face == "Ace")
            {
                this.Face = "Ace(1)";
                this.Value = 1;
                return 1;
            }
            return 0;
        }


    }
}
