using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class BookSaleTransaction : XPObject
    {
        public BookSaleTransaction(Session session) : base(session) { }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { SetPropertyValue(nameof(Date), ref _date, value); }
        }

        private BookDebetOperation _bookDebetOperation;

        [Association("BookDebetOperation-BookSaleTransactions")]
        public BookDebetOperation BookDebetOperation
        {
            get { return _bookDebetOperation; }
            set { SetPropertyValue(nameof(BookDebetOperation), ref _bookDebetOperation, value); }
        }

        private MoneyDebetOperation _moneyDebetOperation;

        [Association("MoneyDebetOperation-BookSaleTransactions")]
        public MoneyDebetOperation MoneyDebetOperation
        {
            get { return _moneyDebetOperation; }
            set { SetPropertyValue(nameof(MoneyDebetOperation), ref _moneyDebetOperation, value); }
        }
    }
}
