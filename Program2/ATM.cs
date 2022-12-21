using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class ATM
    {
        private int denom20;
        private int denom50;
        private int denom100;
        


        public ATM(int denom20, int denom50, int denom100)
        {
            this.denom20 = denom20;
            this.denom50 = denom50;
            this.denom100 = denom100;
        }

        public void Add(int sum)
        {
            
        }

        private bool Cash(int sum)
        {    
            if ((this.denom20 * 20 + this.denom50 * 50 + this.denom100) <= sum) 
                return true;
            else return false;
        }


        public void WithdrawMoney(int sum)
        {
          

            if (Cash(sum) != true) Console.WriteLine("no money");

        }

        public bool Kolvod20(int sum)
        {
            int ost = sum % 20;

            if (ost == 0)
                return true;
            else return false;

        }


    }



}
