using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vveennyy
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.DataInput();
            Console.WriteLine(account.ToString());
            Console.ReadKey();
        }
    }
}
