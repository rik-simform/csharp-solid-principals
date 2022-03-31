using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    internal class Customer_Account
    {
        public string bank_name;
        public long acc_no;
        public string cust_name;

        public Customer_Account(long acc_no,string cust_name )
        {
            this.acc_no = acc_no;
            this.cust_name = cust_name;
        }

        // This Method will display the account details of the customer class
        public void print_info()
        {
            Console.WriteLine("Bank Name: " + bank_name);
            Console.WriteLine("Account Number: " + acc_no);
            Console.WriteLine("Customer Name: " + cust_name);
        }
    }
}
