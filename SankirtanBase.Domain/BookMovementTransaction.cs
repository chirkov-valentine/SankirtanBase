using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankirtanBase.Domain
{
    public class BookMovementTransaction : XPObject
    {
        public BookMovementTransaction(Session session) : base(session) { }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { SetPropertyValue(nameof(Date), ref _date, value); }
        }

        private BookDebetOperation _bookDebetOperation;

        [Association("BookDebetOperation-BookMovementTransactions")]
        public BookDebetOperation BookDebetOperation
        {
            get { return _bookDebetOperation; }
            set { SetPropertyValue(nameof(BookDebetOperation), ref _bookDebetOperation, value); }
        }

        private BookCreditOperation _bookCreditOperation;

        [Association("BookCreditOperation-BookMovementTransactions")]
        public BookCreditOperation BookCreditOperation
        {
            get { return _bookCreditOperation; }
            set { SetPropertyValue(nameof(BookCreditOperation), ref _bookCreditOperation, value); }
        }
    }
}
