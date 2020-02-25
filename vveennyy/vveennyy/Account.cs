using System;
using InputAccuracy;

namespace vveennyy
{
    class Account
    {
        private string _Nomination { get; set; }
        private int _AccountNumber { get; set; }
        private double _Amount { get; set; }
        public Account()
        {
            this._Nomination = "No name";
            this._AccountNumber = 0000;
            this._Amount = 0.0f;
        }
        public Account(string _nomination, int _accountNumber, double _amount)
        {
            this._Nomination = _nomination;
            this._AccountNumber = _accountNumber;
            this._Amount = _amount;
        }
        public string NominationEdit(string _nomination)
        {
            this._Nomination = _nomination;
            return _nomination;
        }
        public int AccountNumberEdit(int _accountNumber)
        {
            this._AccountNumber = _accountNumber;
            return _accountNumber;
        }
        public double AmountEdit(double _amount)
        {
            this._Amount = _amount;
            return _amount;
        }
        public string NominationInfo()
        {

            return this._Nomination;
        }
        public int AccountNumberInfo()
        {

            return this._AccountNumber;
        }
        public double AmountInfo()
        {

            return this._Amount;
        }
        public override string ToString()
        {
            return string.Format("наименование:{0}\nНомер счета:{1}\nСумму:{2}", this._Nomination, this._AccountNumber, this._Amount);
        }
        public void DataInput()
        {
            Class1 input = new Class1();
            Console.WriteLine("введите наименование");
            NominationEdit(input._stringName(Console.ReadLine()));
            Console.WriteLine("введите номер счета");
            AccountNumberEdit(Convert.ToInt32(input._int(Console.ReadLine())));
            Console.WriteLine("введите сумму");
            AmountEdit(Convert.ToDouble(input._double(Console.ReadLine())));
        }
    }
}
