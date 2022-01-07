using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class Contractor : XPObject
    {
        public Contractor(Session session) : base(session) { }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetPropertyValue(nameof(Name), ref _name, value); }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { SetPropertyValue(nameof(Surname), ref _surname, value); }
        }

        private string _patronicName;

        public string PatronicName
        {
            get { return _patronicName; }
            set { SetPropertyValue(nameof(PatronicName), ref _patronicName, value); }
        }

        private string _spiritualName;

        public string SpiritualName
        {
            get { return _spiritualName; }
            set { SetPropertyValue(nameof(SpiritualName), ref _spiritualName, value); }
        }

        [Association("Contractor-BookBalances")]
        public XPCollection<BookBalance> BookBalances
        {
            get { return GetCollection<BookBalance>(); }
        }

        [Association("ToContractor-BookMovementTransactions")]
        public XPCollection<BookMovementTransaction> BookMovementTransactionsTo
        {
            get { return GetCollection<BookMovementTransaction>(); }
        }


        [Association("FromContractor-BookMovementTransactions")]
        public XPCollection<BookMovementTransaction> BookMovementTransactionsFrom
        {
            get { return GetCollection<BookMovementTransaction>(); }
        }

        [Association("Contractor-BookSaleTransactions")]
        public XPCollection<BookSaleTransaction> BookSaleTransactions
        {
            get { return GetCollection<BookSaleTransaction>(); }
        }

        [Association("Contractor-MoneyCreditOperations")]
        public XPCollection<MoneyCreditOperation> MoneyCreditOperations
        {
            get { return GetCollection<MoneyCreditOperation>(); }
        }


        [Association("Contractor-MoneyDebetOperations")]
        public XPCollection<MoneyDebetOperation> MoneyDebetOperations
        {
            get { return GetCollection<MoneyDebetOperation>(); }
        }
    }
}
