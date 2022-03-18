using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamblingDLL
{
    public interface IClickButton
    {
        void Roll_Click();
        void Bet_Click();
    }

    abstract public class GambleGame : IClickButton
    {
        public abstract void Roll_Click();
        public abstract void Bet_Click();

    }

    public class Money
    {
        public static Money instance;
        public int capacity = 1000000;

        public static Money GetInstance()
        {
            if(instance == null)
            {
                instance = new Money();
            }

            return instance;
        }
    }
}
