using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFramework.Collection.Generic_Collection
{
    public class Loan
    {
        public string type { get; set; }
    }
    public class Customer
    {
        public int accountno { get; set; }
        public string name { get; set; }

        public List<Loan> loanlist = new List<Loan>();

    }

    public class Account
    {
      
        public string accounttype { get; set; }
        public List<Customer> clist = new List<Customer>();

    }
    class Bank
    {
 /*       static void Main(string[] args)
        {
            List<Account> list = new List<Account>()
            {
                new Account{accounttype="Saving",clist={new Customer { accountno = 1234, name = "Rohit",loanlist={ new Loan { type="Home Loan"} ,
                                                                                                                   new Loan {type="Personal Loan"},
                                                                                                                   new Loan{type="Car Loan"}
                                                                                                                                } 
                                                                      } ,
                                                        new Customer{accountno=1401,name="Ramesh",loanlist={ new Loan { type="Gold Loan"} ,
                                                                                                                   new Loan {type="Personal Loan"},
                                                                                                                   new Loan{type="Car Loan"}
                                                                                                                                }
                                                        } 
                    } 
                },
                new Account
                {
                    accounttype="Current",clist={new Customer { accountno=1461,name="Suresh"},
                                                 new Customer{accountno=1487,name="Rahul"}
                    }
                }
            };
            foreach (Account a in list)
            {
                Console.WriteLine();
            }
        }*/
    }
}
