using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Trio_Solitaire
{
    class Card
    {
        private Guid cardId;
        private Bitmap frontFace { get; set; }
        private Bitmap backFace { get; set; }

        private bool whichSide { get; set; } = false;   //false is back, true is front

        private int rank { get; set; } //0-13, ace < 2 < 3 < 4 ... 10 < jack < queen < king

        private string suit { get; set; }

        public Card (int cardRank, string cardSuit) 
        {
            cardId = new Guid();
            rank = cardRank;
            suit = cardSuit;

        }

        public void flip()
        {
            this.whichSide = !whichSide;
        }
    }
}
