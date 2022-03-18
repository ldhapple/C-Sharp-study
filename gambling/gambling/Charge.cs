using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gamblingDLL;

namespace gambling
{
    class Charge : GambleGame
    {
        
        public override void Roll_Click()
        {
            Form1 charge = new Form1();
            charge.Charge();
        }

        public override void Bet_Click()
        {

        }
    }
}
