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

        private Contractor _fromContractor;

        [Association("FromContractor-BookMovementTransactions")]
        public Contractor FromContractor
        {
            get { return _fromContractor; }
            set { SetPropertyValue(nameof(FromContractor), ref _fromContractor, value); }
        }

        private Contractor _toContractor;

        [Association("ToContractor-BookMovementTransactions")]
        public Contractor ToContractor
        {
            get { return _toContractor; }
            set { SetPropertyValue(nameof(ToContractor), ref _toContractor, value); }
        }

        [Association("BookMovementTransaction-BookMovementLineItems")]
        public XPCollection<BookMovementLineItem> BookSaleLineItems
        {
            get { return GetCollection<BookMovementLineItem>(); }
        }
    }
}
