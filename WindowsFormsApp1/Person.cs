using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person
    {
        public string Name;

        public int Money;

        public Person(string Name,int Money)
        {
            this.Name = Name;
            this.Money = Money;
        }

        public void borrow(Person lender, int money)
        {
            lender.Money -= Money;
            this.Money += Money;
        }

        public void repay(Person lender,int money)
        {
            this.Money -= money;
            lender.Money += money;
        }
    }
}
