using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Person person, bank;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            person = new Person(MyName.Text, 0);
            bank = new Person(BankName.Text, 30000);
            MyName.Enabled = false;
            BankName.Enabled = false;
            lb_MyName.Text = MyName.Text;
            lb_BankName.Text = BankName.Text;
            updateMoney();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            person.borrow(bank, int.Parse(txtAmount.Text));
            updateMoney();

        }

        private void btn_Repay_Click(object sender, EventArgs e)
        {
            person.repay(bank, int.Parse(txtAmount.Text));
            updateMoney();

        }

        private void updateMoney()
        {
            lb_MyMoney.Text = "" + person.Money;
            lb_BankMoney.Text = "" + bank.Money;
        }
    }
}
