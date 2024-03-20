using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class standardUser : baseUser
    {
        public bool Student {  get; set; }
        public double Wallet { get; set; }
        public string Subscription {  get; set; }
        
        public standardUser(string name, string password, string email, double wallet, bool student=false, string subscription="standard") : base(name, password, email, false) 
        {
            Wallet = wallet;
        }
    }
}
